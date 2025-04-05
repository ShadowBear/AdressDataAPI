using AdressDataAPI.Data;
using AdressDataAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdressDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController: ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AddressController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get api/address
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddress()
        {
            return await _context.Addresses.ToListAsync();
        }

        // GET: api/address/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddress(int id)
        {
            var address = await _context.Addresses.FindAsync(id);

            if (address == null)
            {
                return NotFound();
            }

            return address;
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string aktenzeichen)
        {
            if (string.IsNullOrEmpty(aktenzeichen)) return BadRequest("Missing search input");

            var addresses = await _context.Addresses.Where(item => item.Aktenzeichen == aktenzeichen).OrderByDescending(item => item.AktuelleAnschrift).ToListAsync();
            return Ok(addresses);
        }

        // POST: api/address
        [HttpPost]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
            if (address == null) return NoContent();

            if (address.AktuelleAnschrift)
            {
                var prevCurrAddress = await _context.Addresses.FirstOrDefaultAsync(item => (item.Aktenzeichen == address.Aktenzeichen && item.AktuelleAnschrift));
                if (prevCurrAddress != null)
                {
                    prevCurrAddress.AktuelleAnschrift = false;
                    _context.Addresses.Update(prevCurrAddress);
                }
            }

            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAddress), new { id = address.Id }, address);
        }

        //POST: api/address/import
        [HttpPost("import")]
        public async Task<IActionResult> ImportAddresses([FromBody] List<Address> addresses)
        {
            try
            {
                if (addresses == null || !addresses.Any()) return BadRequest("No Addresses provided");

                _context.AddRange(addresses);
                await _context.SaveChangesAsync();

                return Ok("Addresses imported");
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
            
        }

        // PUT: api/address/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddress(int id, Address address)
        {
            if (id != address.Id)
            {
                return BadRequest();
            }

            _context.Entry(address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(id))
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

        // DELETE: api/address/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var address = await _context.Addresses.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }

            _context.Addresses.Remove(address);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //DELETE: api/address/clear
        [HttpPost("clear")]
        public IActionResult ClearTable()
        {
            _context.Addresses.ExecuteDelete();
            return Ok("Address data cleared");
        }


        private bool AddressExists(int id)
        {
            return _context.Addresses.Any(e => e.Id == id);
        }
    }
}
