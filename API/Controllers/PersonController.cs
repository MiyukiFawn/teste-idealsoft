using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API;
using API.Model;
using API.DTOs;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase {
        private readonly ApiDbContext _context;

        public PersonController(ApiDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPerson() {
            if (_context.Person == null) {
                return NotFound();
            }
            return await _context.Person.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson(Guid id) {
            if (_context.Person == null) {
                return NotFound();
            }
            var person = await _context.Person.FindAsync(id);

            if (person == null) {
                return NotFound();
            }

            return person;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson(Guid id, UpdatePersonDto person) {
            Person? oldPerson = await _context.Person.FirstAsync(x => x.Id == id);
            if (oldPerson == null)
                return NotFound();


            if (person.Name != null)
                oldPerson.Name = person.Name;
            if (person.Surname != null)
                oldPerson.Surname = person.Surname;
            if (person.Phone != null)
                oldPerson.Phone = person.Phone;

            _context.Entry(oldPerson).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (Exception) {
                throw;
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson(CreatePersonDto person) {
            if (_context.Person == null) {
                return Problem("Entity set 'ApiDbContext.Person'  is null.");
            }

            Person createdPerson = new() { Name = person.Name, Phone = person.Phone, Surname = person.Surname };
            _context.Person.Add(createdPerson);
            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException) {
                throw;
            }

            return CreatedAtAction("GetPerson", new { id = createdPerson.Id }, person);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(Guid id) {
            if (_context.Person == null) {
                return NotFound();
            }
            var person = await _context.Person.FindAsync(id);
            if (person == null) {
                return NotFound();
            }

            _context.Person.Remove(person);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
