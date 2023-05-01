using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya.Model
{
    public class Zayavka
    {
        public int Id { get; set; }

        [Required]
        public string Event { get; set; }
        [Required]
        public DateTime DataSostavlen { get; set; }
        [Required]
        public DateTime DataEvent { get; set; }

        [Required]
        [MaxLength(30)]
        public string FIOClient { get; set; }

        [MaxLength(12)]
        public string Telephone { get; set; }

        public int Count { get; set; }

        public string TimeHot { get; set; }


    }
}
