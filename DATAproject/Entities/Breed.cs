using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAproject.Entities
{
    public class Breed
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int AnimalId { get; set; }

        public Animal Animal { get; set; }

        public ICollection<Pet> Pets { get; set; } = new List<Pet>();
    }
}
