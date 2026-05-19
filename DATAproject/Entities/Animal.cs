using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAproject.Entities
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        public ICollection<Breed> Breeds { get; set; }  = new List<Breed>();
    }
}
