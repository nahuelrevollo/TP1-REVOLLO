using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PRIMETA_APP
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public char Tipo { get; set; }
        public char Modalidad { get; set; }
        public bool Alta { get; set; }

    }
}
