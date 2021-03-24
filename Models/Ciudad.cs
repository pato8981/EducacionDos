using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducacionDos.Models
{
    public class Ciudad
    {
        [Key]
        public int IdCiudad { get; set; }

        public int IdPais { get; set; }

        public string Descripcion { get; set; }
    }
}
