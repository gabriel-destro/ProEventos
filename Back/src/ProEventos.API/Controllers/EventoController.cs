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
        private readonly DataContext _contex;

        public EventoController(DataContext contex)
        {
            _contex = contex;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        { 
            return _contex.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetByID(int id)
        { 
            return _contex.Eventos.FirstOrDefault(
                    evento => evento.EventoId == id
                );
        }

        [HttpPost]
        public string Post()
        { 
            return  "Exemplo de Post";  
        }

        [HttpPut("{id}")]
        public string Put(int id)
        { 
            return  $"Exemplo de Put com id = {id}";   
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        { 
            return  $"Exemplo de Delete com id = {id}";   
        }
    }
}
