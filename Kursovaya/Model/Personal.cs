using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Kursovaya.Model
{
    public class Personal
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string SecondName { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(30)]
        public string Doljnost { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [MaxLength(12)]
        public string Telephone { get; set; }


       public virtual ICollection<Check> Checks { get; set; }


        
        public string FIO => SecondName + " " + FirstName + " " + LastName;

        public Personal()
        {
            Checks = new List<Check>();
        }

        public override string ToString()
        {
            return FIO;
        }
    }
}
