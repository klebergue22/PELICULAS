﻿using peliculasAPI.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace peliculasAPI.Entidades
{
    public class Genero
    {
        public int Id { get; set; }

        [Requiered(ErrorMessage = "El campo{0} es requerido")]
        [StringLength(maximumLength: 50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }

        public List<PeliculaGeneros> PeliculaGeneros { get; set; }
    }
}