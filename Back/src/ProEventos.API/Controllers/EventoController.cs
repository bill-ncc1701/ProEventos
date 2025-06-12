using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.API.Models;
using Microsoft.AspNetCore.Mvc;


namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento(){
                    EventoId = 1,
                    Tema = ".NET 5 e Angular",
                    Local = "Belo Horizonte",
                    Lote = "Lote 1",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString()
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Spring Boot",
                    Local = "Curitiba",
                    Lote = "Lote 3",
                    QtdPessoas = 150,
                    DataEvento = DateTime.Now.AddDays(10).ToString()
                }

            };


        public EventoController()
        {

        }


        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);

        }      

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }


        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post!";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}!";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }



        
        
    }
}
