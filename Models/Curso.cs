﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducacionDos.Models
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }

        public string Descripcion { get; set; }
    }
}
