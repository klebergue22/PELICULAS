using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace peliculasAPI.Entidades
{
    public class Cine
    {
        public int Id { get; set; }

        [Requiered]
        [StringLength(maximumLength: 75)]
        public string Nombre { get; set; }

        public Point Ubicacion { get; set; }

        public List<PeliculasCines> PeliculasCines { get; set; }
    }
}