using peliculasAPI.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace peliculasAPI.DTOs
{
    public class CredencialesUsuario
    {
        [EmailAddress]
        [Requiered]
        public string Email { get; set; }

        [Requiered]
        public string Password { get; set; }
    }
}