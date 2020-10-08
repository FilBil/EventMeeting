using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventMeeting.Data;
using EventMeeting.Models;

namespace EventMeeting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentModelsController : ControllerBase
    {
        private readonly RentBraContext _context;

        public RentModelsController(RentBraContext context)
        {
            _context = context;
        }

        // GET: api/RentModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RentModel>>> GetRentBra()
        {
            return await _context.RentBra.ToListAsync();
        }

        // GET: api/RentModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RentModel>> GetRentModel(int id)
        {
            var rentModel = await _context.RentBra.FindAsync(id);

            if (rentModel == null)
            {
                return NotFound();
            }

            return rentModel;
        }

        // PUT: api/RentModels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRentModel(int id, RentModel rentModel)
        {
            if (id != rentModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(rentModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RentModels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RentModel>> PostRentModel(RentModel rentModel)
        {
            _context.RentBra.Add(rentModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRentModel", new { id = rentModel.Id }, rentModel);
        }

        // DELETE: api/RentModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RentModel>> DeleteRentModel(int id)
        {
            var rentModel = await _context.RentBra.FindAsync(id);
            if (rentModel == null)
            {
                return NotFound();
            }

            _context.RentBra.Remove(rentModel);
            await _context.SaveChangesAsync();

            return rentModel;
        }

        private bool RentModelExists(int id)
        {
            return _context.RentBra.Any(e => e.Id == id);
        }
    }
}
