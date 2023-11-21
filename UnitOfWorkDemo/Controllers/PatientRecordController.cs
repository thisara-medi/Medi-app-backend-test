using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PMS.Core.Models;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web.Helpers;
using UnitOfWorkDemo.Services;
using UnitOfWorkDemo.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PMS.Endpoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientRecordController : ControllerBase
    {
        public readonly IPatientRecordService _patientRecordService;

        public PatientRecordController(IPatientRecordService patientRecordService)
        {
            this._patientRecordService = patientRecordService;
        }

        [HttpGet("GetPatientRecordList")]
        public async Task<IActionResult> GetPatientRecordList()
        {
            var results = await _patientRecordService.GetPatientRecordsAsQuarable().ToListAsync();
            if (results == null)
            {
                return NotFound();
            }
            // Use JsonSerializerOptions with ReferenceHandler.Preserve
            var jsonOptions = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            // Serialize the results to JSON
            var json = JsonConvert.SerializeObject(results, jsonOptions);

            return Ok(JsonConvert.DeserializeObject<List<PatientMedicalRecordDetails>>(json));
        }

        [HttpGet("GetPatientRecordsBySearchString/{searchstring}")]
        public async Task<IActionResult> GetPatientRecordsBySearchString(string searchstring)
        {
            string[] searchstrings = searchstring.Split(',','/','|');

            var patientRecords = _patientRecordService.GetPatientRecordsAsQuarable();
             
            if (searchstrings.Count()>= 1 && !string.IsNullOrWhiteSpace(searchstrings[0]))
            {
                var name = searchstrings[0];
                patientRecords = patientRecords.Where(x => (x.PatientProfile.FirstName + x.PatientProfile.LastName).Contains(name));
            }
             
            if (searchstrings.Count() >= 2 && !string.IsNullOrWhiteSpace(searchstrings[1]))
            {
                var userId = searchstrings[1];
                patientRecords = patientRecords.Where(x => x.PatientProfileID.ToString().Contains(userId));
            }
             
            if (searchstrings.Count() >= 3 && !string.IsNullOrWhiteSpace(searchstrings[2]))
            {
                patientRecords = patientRecords.Where(x => x.PatientProfile.NIC.Contains(searchstrings[2], StringComparison.OrdinalIgnoreCase));
            }

            var results = patientRecords.ToList();
            if (results == null)
            {
                return NotFound();
            }
            // Use JsonSerializerOptions with ReferenceHandler.Preserve
            var jsonOptions = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            // Serialize the results to JSON
            var json = JsonConvert.SerializeObject(results, jsonOptions);

            return Ok(JsonConvert.DeserializeObject<List<PatientMedicalRecordDetails>>(json));
        }


        [HttpGet("GetPatientRecordsByReason/{reason}")]
        public async Task<IActionResult> GetPatientRecordsByReason(string reason)
        {
            var results = await _patientRecordService.GetPatientRecordsAsQuarable().Where(x=> x.Reason.ReasonDescription.ToLower().Contains(reason.ToLower())).ToListAsync();

            if (results != null)
            {
                // Use JsonSerializerOptions with ReferenceHandler.Preserve
                var jsonOptions = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                };

                // Serialize the results to JSON
                var json = JsonConvert.SerializeObject(results, jsonOptions);

                return Ok(JsonConvert.DeserializeObject<List<PatientMedicalRecordDetails>>(json));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetPatientRecordsByDate/")]
        public async Task<IActionResult> GetPatientRecordsByDate(DateTime fromdate, DateTime? todate)
        {
            var results = await _patientRecordService.GetPatientRecordsAsQuarable().Where(x => x.CreatedDate>= fromdate && x.CreatedDate<=todate).ToListAsync();

            if (results != null)
            {
                // Use JsonSerializerOptions with ReferenceHandler.Preserve
                var jsonOptions = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                };

                // Serialize the results to JSON
                var json = JsonConvert.SerializeObject(results, jsonOptions);

                return Ok(JsonConvert.DeserializeObject<List<PatientMedicalRecordDetails>>(json));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetPatientRecordById/{patientRecordId}")]
        public async Task<IActionResult> GetPatientRecordById(int patientId)
        {
            var patientDetails = await _patientRecordService.GetPatientRecordById(patientId);

            if (patientDetails != null)
            {
                return Ok(patientDetails);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost("AddPatientRecord")]
        public async Task<IActionResult> AddPatientRecord(PatientMedicalRecordDetails patientDetails)
        {
            var isPatientCreated = await _patientRecordService.CreatePatientRecord(patientDetails);

            if (isPatientCreated)
            {
                return Ok(isPatientCreated);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut("UpdatePatientRecord")]
        public async Task<IActionResult> UpdatePatientRecord(PatientMedicalRecordDetails patientDetails)
        {
            if (patientDetails != null)
            {
                var isPatientUpdated = await _patientRecordService.UpdatePatientRecord(patientDetails);
                if (isPatientUpdated)
                {
                    return Ok(isPatientUpdated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete("DeletePatientRecord/{patientRecordId}")]
        public async Task<IActionResult> DeletePatientRecord(int patientRecordId)
        {
            var isPatientRecordCreated = await _patientRecordService.DeletePatientRecord(patientRecordId);

            if (isPatientRecordCreated)
            {
                return Ok(isPatientRecordCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetRecordByPatientId/{patientRecordId}")]
        public async Task<IActionResult> GetRecordByPatientId(int patientRecordId)
        {
            var patientDetails = await _patientRecordService.GetRecordByPatientId(patientRecordId);

            if (patientDetails != null)
            {
                return Ok(patientDetails);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
