using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya.Model
{
    public class Check
    {
        public int Id { get; set; }

        public int ZakazId { get; set; }

        public virtual Zakaz Zakaz { get; set; }

        public int PersonalId { get; set; }

        public virtual Personal Personal { get; set; }

        public string NameBlud { get; set; }

        public string PriceBlud { get; set; }

        public int StoimObsl { get; set; }
        
        public int Stol { get; set; }

        public int ItogVsego { get; set; }


    }
}
