using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookManagementAPI.Data;
using BookManagementAPI.Models.Dtos.PublisherDto;
using AutoMapper;

namespace BookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PublishersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Publishers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetPublisherDto>>> GetPublisher()
        {
            var publishers = await _context.Publisher.ToListAsync();
            var records = _mapper.Map<List<GetPublisherDto>>(publishers);
            return Ok(records);
        }

        // GET: api/Publishers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PublisherDto>> GetPublisher(int id)
        {
            var publisher = await _context.Publisher.FindAsync(id);

            if (publisher == null)
            {
                return NotFound();
            }

            var publisherDto = _mapper.Map<GetPublisherDto>(publisher);

            return Ok(publisherDto);
        }

        // PUT: api/Publishers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublisher(int id, UpdatePublisherDto updatePublisherDto)
        {
            if (id != updatePublisherDto.Id)
            {
                return BadRequest();
            }

            var publisher = await _context.Publisher.FindAsync(id);
            if(publisher == null)
            {
                return NotFound();
            }

            _mapper.Map(updatePublisherDto, publisher);

            try
            {
                _context.Update(publisher);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublisherExists(id))
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

        // POST: api/Publishers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GetPublisherDto>> PostPublisher(CreatePublisherDto createPublisherDto)
        {
            var publisher = _mapper.Map<Publisher>(createPublisherDto);
            await _context.Publisher.AddAsync(publisher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPublisher", new { id = publisher.Id }, publisher);
        }

        // DELETE: api/Publishers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublisher(int id)
        {
            var publisher = await _context.Publisher.FindAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }

            _context.Publisher.Remove(publisher);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PublisherExists(int id)
        {
            return _context.Publisher.Any(e => e.Id == id);
        }
    }
}
