using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMETA_APP
{
    public class Profesor:Personas
    {
        public int Legajo { get; set; }
        public IList<Materia> Materias { get; set; }
        public int Tel_1 { get; set; }
        public int Tel_2 { get; set; }
        public string Mail { get; set; }
        public Ayudante Ayudante { get; set; }
        public bool Alta { get; set; }

    }
}
