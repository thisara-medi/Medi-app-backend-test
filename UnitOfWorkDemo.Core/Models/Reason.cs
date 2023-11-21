using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Models
{
    public class Reason
    {
        [Key]
        public long ReasonID { get; set; }
        public string ReasonDescription { get; set; }
    }
}
