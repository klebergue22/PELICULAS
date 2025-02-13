﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace peliculasAPI.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Requiered]
        [StringLength(maximumLength: 300)]
        public string Titulo { get; set; }

        public string Resumen { get; set; }
        public string Trailer { get; set; }
        public bool EnCines { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string Poster { get; set; }

        public List<PeliculasActores> PeliculasActores { get; set; }
        public List<PeliculaGeneros> PeliculaGeneros { get; set; }
        public List<PeliculasCines> PeliculasCines { get; set; }
    }
}