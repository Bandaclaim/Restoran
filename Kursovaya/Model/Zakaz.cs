using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya.Model
{
    public class Zakaz
    {
        public int Id { get; set; }

        public string Names { get; set; }

        public string Prices { get; set; }

        public int Itogo { get; set; }

        public virtual ICollection<Check> Checks { get; set; }

        public Zakaz()
        {
            Checks = new List<Check>();
        }
        public string IdZakaz => Id.ToString();
        public override string ToString()
        {
            return IdZakaz;
        }
    }
}
