using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      private readonly DataContext _context;

        public EventoController(DataContext context)
        {
           _context = context;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorchingtt"
        };


        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _context.Eventos;
        }

         [HttpGet("{id}")]
        public Evento GetById(int id)
        {
           return _context.Eventos.FirstOrDefault(x=>x.EventoId == id);
        }

        [HttpPost]
        public String Post()
        {
           return "Exemplo Post";
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {
           return $"Exemplo Put {id}";
        }
    }
}
