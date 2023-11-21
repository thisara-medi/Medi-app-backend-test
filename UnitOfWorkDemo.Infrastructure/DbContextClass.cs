using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using PMS.Core.Models;

namespace UnitOfWorkDemo.Infrastructure
{
    public class DbContextClass :DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientMedicalRecordDetails> PatientRecord { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
