using hotelAPI.Data;
using hotelAPI.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly HotelContext hotelContext;
        public ReservaController(HotelContext hotelContext)
        {
            this.hotelContext = hotelContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Reserva>>> Get() {
            var result = await hotelContext.Reservas.Include(x => x.Quarto).AsNoTracking().ToListAsync();
            return Ok(result);
        }

        [HttpGet("{reservaId}")]
        public async Task<ActionResult<Reserva>> Get(int reservaId) {
            var result = await hotelContext.Reservas.Include(x => x.Quarto)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ReservaId == reservaId);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] Reserva reserva)
        {
            var result = await hotelContext.AddAsync(reserva);
            hotelContext.SaveChanges();


            return Ok(result.Entity.ReservaId);
        }

    }
}
 