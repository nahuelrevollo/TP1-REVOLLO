using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PRIMETA_APP
{
    public class Materia
    {

        public int ID { get; set; }
        public string Nombre { get; set; }
        public Carrera carrera { get; set; }
        public Comision comision { get; set; }
        public bool Alta { get; set; }


    }
}
