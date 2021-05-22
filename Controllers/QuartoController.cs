using hotelAPI.Data;
using hotelAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace hotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuartoController : ControllerBase
    {
        private readonly HotelContext hotelContext;
        public QuartoController(HotelContext hotelContext)
        {
            this.hotelContext = hotelContext;
        }

        [HttpGet("disponiveis")]
        public async Task<ActionResult<List<Quarto>>> Get() {
            var result = await hotelContext.Quartos.AsNoTracking().ToListAsync();
            return Ok(result);
        }

    }
}
