using DATAproject.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DATAproject.Entities
{
    public class Userr
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }

        public UserRole Role { get; set; }
        public int? EmployeeTypeId { get; set; }
        public EmployeeType? EmployeeType { get; set; }

        public ICollection<Pet> Pets { get; set; } = new List<Pet>();

        public ICollection<Appointment> EmployeeAppointments { get; set; } = new List<Appointment>();
    }
}
