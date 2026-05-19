using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAproject.Entities
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public string Reason { get; set; }

        public int PetId { get; set; }
        public Pet Pet { get; set; }

        public int EmployeeId { get; set; }
        public Userr Employee { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
