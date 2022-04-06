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
    public class CurrentAccountsController : ControllerBase
    {
        private readonly Dev4Fun_Sem3_eProjectContext _context;

        public CurrentAccountsController(Dev4Fun_Sem3_eProjectContext context)
        {
            _context = context;
        }

        // GET: api/CurrentAccounts
        [HttpGet]
        public async Task<ActionResult<Accounts>> GetCurrentAccount()
        {
            
            var currentAccount = new CurrentAccount();
            currentAccount = _context.CurrentAccount.FromSqlRaw(@"select * from CurrentAccount").First();
            var account = new Accounts();
            account = _context.Accounts.FromSqlRaw(@"select * from Accounts where email={0}", currentAccount.Email).First();           
            return account;
        }

        // GET: api/CurrentAccounts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpGet("/api/logout")]
        public async Task<ActionResult<Accounts>> Logout()
        {
            _context.Database.ExecuteSqlRaw("Truncate table [CurrentAccount]");
            await _context.SaveChangesAsync();
            return Ok("done");
        }

        // GET: api/CurrentAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurrentAccount>> GetCurrentAccount(int id)
        {
            var currentAccount = await _context.CurrentAccount.FindAsync(id);

            if (currentAccount == null)
            {
                return NotFound();
            }

            return currentAccount;
        }

        // PUT: api/CurrentAccounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurrentAccount(int id, CurrentAccount currentAccount)
        {
            if (id != currentAccount.Id)
            {
                return BadRequest();
            }

            _context.Entry(currentAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurrentAccountExists(id))
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

        // POST: api/CurrentAccounts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CurrentAccount>> PostCurrentAccount(CurrentAccount currentAccount)
        {
            _context.Database.ExecuteSqlRaw("Truncate table [CurrentAccount]");
            await _context.SaveChangesAsync();
            _context.CurrentAccount.Add(currentAccount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurrentAccount", new { id = currentAccount.Id }, currentAccount);
        }


        // DELETE: api/CurrentAccounts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurrentAccount(int id)
        {
            var currentAccount = await _context.CurrentAccount.FindAsync(id);
            if (currentAccount == null)
            {
                return NotFound();
            }

            _context.CurrentAccount.Remove(currentAccount);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CurrentAccountExists(int id)
        {
            return _context.CurrentAccount.Any(e => e.Id == id);
        }
    }
}
