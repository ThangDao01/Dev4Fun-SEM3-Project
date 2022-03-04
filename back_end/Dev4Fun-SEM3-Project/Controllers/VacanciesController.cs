#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dev4Fun_SEM3_Project.Data;
using Dev4Fun_SEM3_Project.Models;

namespace Dev4Fun_SEM3_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacanciesController : ControllerBase
    {
        private readonly Dev4Fun_SEM3_ProjectContext _context;

        public VacanciesController(Dev4Fun_SEM3_ProjectContext context)
        {
            _context = context;
        }

        // GET: api/Vacancies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vacancies>>> GetVacancies()
        {
            return await _context.Vacancies.ToListAsync();
        }

        // GET: api/Vacancies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vacancies>> GetVacancies(string id)
        {
            var vacancies = await _context.Vacancies.FindAsync(id);

            if (vacancies == null)
            {
                return NotFound();
            }

            return vacancies;
        }

        // PUT: api/Vacancies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVacancies(string id, Vacancies vacancies)
        {
            if (id != vacancies.Id)
            {
                return BadRequest();
            }

            _context.Entry(vacancies).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VacanciesExists(id))
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

        // POST: api/Vacancies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vacancies>> PostVacancies(Vacancies vacancies)
        {
            _context.Vacancies.Add(vacancies);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VacanciesExists(vacancies.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetVacancies", new { id = vacancies.Id }, vacancies);
        }

        // DELETE: api/Vacancies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVacancies(string id)
        {
            var vacancies = await _context.Vacancies.FindAsync(id);
            if (vacancies == null)
            {
                return NotFound();
            }

            _context.Vacancies.Remove(vacancies);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VacanciesExists(string id)
        {
            return _context.Vacancies.Any(e => e.Id == id);
        }
    }
}
