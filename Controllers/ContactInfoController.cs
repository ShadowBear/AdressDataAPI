using AdressDataAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AddressList.Shared.Models;

namespace AdressDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInfoController: ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContactInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: api/contactinfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactInfo>>> GetContactInfo()
        {
            return await _context.Contacts.ToListAsync();
        }
        //GET: api/contactinfo/1
        [HttpGet("{id}")]
        public async Task <ActionResult<ContactInfo>> GetContactInfo(int id)
        {
            var contactInfo = await _context.Contacts.FindAsync(id);
            return contactInfo == null ? NotFound() : contactInfo;            
        }

        [HttpGet("byfileid")]
        public async Task<ActionResult<ContactInfo>> GetContactInfosByFileId([FromQuery] int fileId)
        {
            var contactInfos = await _context.Contacts.Where(item => item.FileID == fileId).ToListAsync();
            return Ok(contactInfos);
        }

        [HttpPost]
        public async Task <ActionResult<ContactInfo>> PostContactInfo(ContactInfo contactInfo)
        {
            _context.Contacts.Add(contactInfo);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetContactInfo), new { id = contactInfo.Id }, contactInfo);
        }

        //POST: api/contactinfo/import
        [HttpPost("import")]
        public async Task<IActionResult> ImportContactInfos([FromBody] List<ContactInfo> contactInfos)
        {
            try
            {
                if (contactInfos == null || !contactInfos.Any()) return BadRequest("No ContactInfos provided");

                _context.AddRange(contactInfos);
                await _context.SaveChangesAsync();

                return Ok("ContactInfos imported");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }

        }

        // PUT: api/contactinfo/1
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactInfo(int id, ContactInfo contactInfo)
        {
            if (id != contactInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(contactInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactInfoExists(id))
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

        // DELETE: api/contactinfo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactInfo(int id)
        {
            var contactInfo = await _context.Contacts.FindAsync(id);
            if (contactInfo == null)
            {
                return NotFound();
            }

            _context.Contacts.Remove(contactInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactInfoExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }
    }
}
