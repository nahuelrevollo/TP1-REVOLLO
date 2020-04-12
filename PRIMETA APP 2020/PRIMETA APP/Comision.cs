using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMETA_APP
{
    public class Comision
    {
        public int ID { get; set; }
        public IList<Profesor> Profesores { get; set; }
        public IList<Alumno> Alumnos { get; set; }
        public IList<Ayudante> ayudantes { get; set; }
        public string Aula { get; set; }
        public Horario horario { get; set; }

    }
}
