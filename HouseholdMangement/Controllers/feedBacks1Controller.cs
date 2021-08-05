using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HouseholdMangement.Data;
using HouseholdMangement.Models;

namespace HouseholdMangement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class feedBacks1Controller : ControllerBase
    {
        private readonly HouseholdMangementContext _context;

        public feedBacks1Controller(HouseholdMangementContext context)
        {
            _context = context;
        }

        // GET: api/feedBacks1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<feedBack>>> GetfeedBack()
        {
            return await _context.feedBack.ToListAsync();
        }

        // GET: api/feedBacks1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<feedBack>> GetfeedBack(int id)
        {
            var feedBack = await _context.feedBack.FindAsync(id);

            if (feedBack == null)
            {
                return NotFound();
            }

            return feedBack;
        }

        // PUT: api/feedBacks1/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutfeedBack(int id, feedBack feedBack)
        {
            if (id != feedBack.Id)
            {
                return BadRequest();
            }

            _context.Entry(feedBack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!feedBackExists(id))
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

        // POST: api/feedBacks1
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<feedBack>> PostfeedBack(feedBack feedBack)
        {
            _context.feedBack.Add(feedBack);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetfeedBack", new { id = feedBack.Id }, feedBack);
        }

        // DELETE: api/feedBacks1/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<feedBack>> DeletefeedBack(int id)
        {
            var feedBack = await _context.feedBack.FindAsync(id);
            if (feedBack == null)
            {
                return NotFound();
            }

            _context.feedBack.Remove(feedBack);
            await _context.SaveChangesAsync();

            return feedBack;
        }

        private bool feedBackExists(int id)
        {
            return _context.feedBack.Any(e => e.Id == id);
        }
    }
}
