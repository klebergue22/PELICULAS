using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using peliculasAPI.DTOs;
using peliculasAPI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace peliculasAPI.Controllers
{
    [Route("api/actores")]
    [ApiController]
    public class ActoresController:ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ActoresController(ApplicationDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<ActionResult> Post([FromForm]ActorCreacionDTO actorCreacionDTO)
        {
          /*  var actor = mapper.Map<Actor>(actorCreacionDTO);
            context.Add(actor);
            await context.SaveChangesAsync();*/
            return NoContent();
        }
    }
}
