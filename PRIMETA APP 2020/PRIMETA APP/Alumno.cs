using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PRIMETA_APP
{
    public class Alumno:Personas
    {
        public int Legajo { get; set; }
        public IList<Materia>Materias { get; set; }

        public int Tel_1 { get; set; }

        public int Tel_2 { get; set; }

        public string Mail { get; set; }

        public Notas notas { get; set; }

        public bool alta { get; set; }


    }
}
