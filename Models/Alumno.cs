using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducacionDos.Models
{
    public class Alumno
    {
            [Key]
            public int IdAlumno { get; set; }


            public string Apellido { get; set; }

            public string Nombre { get; set; }



            public DateTime FechaNacimiento { get; set; }


            public string Telefono { get; set; }


            public int IdPais { get; set; }

            public int IdCiudad { get; set; }

            public int IdCurso { get; set; }
        }
}
