using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiControllers.Models;
using Microsoft.AspNetCore.JsonPatch;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiControllers.Controllers
{
    [Route("api/[controller]")]
    public class ReservationController : Controller
    {
        private IRepository repository;

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Reservation> Get() => repository.Reservations;

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Reservation Get(int id) => repository[id];

        // POST api/<controller>
        [HttpPost]
        public Reservation Post([FromBody] Reservation res) =>
            repository.AddReservation(new Reservation
            {
                ClientName = res.ClientName,
                Location = res.Location
            });

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public StatusCodeResult Patch(int id,
            [FromBody]JsonPatchDocument<Reservation> patch)
        {
            Reservation res = Get(id);
            if(res != null)
            {
                patch.ApplyTo(res);
                return Ok();
            }
            return NotFound();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id) => repository.DeleteReservation(id);
    }
}
