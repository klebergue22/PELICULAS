using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace peliculasAPI.DTOs
{
    public class LandingPageDTO
    {
        public List<PeliculaDTO> EnCines { get; set; }
        public List<PeliculaDTO> ProximosEstrenos { get; set; }
    }
}