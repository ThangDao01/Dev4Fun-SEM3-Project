#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dev4Fun_Sem3_eProject.Data;
using Dev4Fun_Sem3_eProject.Models;

namespace Dev4Fun_Sem3_eProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppliedJobsController : ControllerBase
    {
        private readonly Dev4Fun_Sem3_eProjectContext _context;

        public AppliedJobsController(Dev4Fun_Sem3_eProjectContext context)
        {
            _context = context;
        }

        // GET: api/AppliedJobs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppliedJob>>> GetAppliedJob()
        {
            return await _context.AppliedJob.ToListAsync();
        }

        // GET: api/AppliedJobs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppliedJob>> GetAppliedJob(int id)
        {
            var appliedJob = await _context.AppliedJob.FindAsync(id);

            if (appliedJob == null)
            {
                return NotFound();
            }

            return appliedJob;
        }

        // PUT: api/AppliedJobs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppliedJob(int id, AppliedJob appliedJob)
        {
            if (id != appliedJob.id)
            {
                return BadRequest();
            }

            _context.Entry(appliedJob).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppliedJobExists(id))
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

        // POST: api/AppliedJobs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppliedJob>> PostAppliedJob(AppliedJob appliedJob)
        {
            _context.AppliedJob.Add(appliedJob);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppliedJob", new { id = appliedJob.id }, appliedJob);
        }

        // DELETE: api/AppliedJobs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppliedJob(int id)
        {
            var appliedJob = await _context.AppliedJob.FindAsync(id);
            if (appliedJob == null)
            {
                return NotFound();
            }

            _context.AppliedJob.Remove(appliedJob);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppliedJobExists(int id)
        {
            return _context.AppliedJob.Any(e => e.id == id);
        }
    }
}
