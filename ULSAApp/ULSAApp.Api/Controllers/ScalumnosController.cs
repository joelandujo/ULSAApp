using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ULSAApp.Api.Data.Entities;

namespace ULSAApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScalumnosController : ControllerBase
    {
        private readonly SCAUlsaContext _context;

        public ScalumnosController(SCAUlsaContext context)
        {
            _context = context;
        }

        // GET: api/Scalumnos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Scalumno>>> GetScalumnos()
        {
            return await _context.Scalumnos.ToListAsync();
        }

        // GET: api/Scalumnos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Scalumno>> GetScalumno(int id)
        {
            var scalumno = await _context.Scalumnos.FindAsync(id);

            if (scalumno == null)
            {
                return NotFound();
            }

            return scalumno;
        }

        // PUT: api/Scalumnos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScalumno(int id, Scalumno scalumno)
        {
            if (id != scalumno.G0nummat)
            {
                return BadRequest();
            }

            _context.Entry(scalumno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScalumnoExists(id))
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

        // POST: api/Scalumnos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Scalumno>> PostScalumno(Scalumno scalumno)
        {
            _context.Scalumnos.Add(scalumno);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ScalumnoExists(scalumno.G0nummat))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetScalumno", new { id = scalumno.G0nummat }, scalumno);
        }

        // DELETE: api/Scalumnos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScalumno(int id)
        {
            var scalumno = await _context.Scalumnos.FindAsync(id);
            if (scalumno == null)
            {
                return NotFound();
            }

            _context.Scalumnos.Remove(scalumno);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScalumnoExists(int id)
        {
            return _context.Scalumnos.Any(e => e.G0nummat == id);
        }
    }
}
