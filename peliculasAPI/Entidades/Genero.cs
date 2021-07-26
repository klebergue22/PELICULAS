using peliculasAPI.Validaciones;
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

        public string Nombre { get; set; }
    }
}