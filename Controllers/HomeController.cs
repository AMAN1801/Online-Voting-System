using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Online_Voting_System.Models;
using Microsoft.EntityFrameworkCore;
using OnlineVotingSystem.Models;

namespace Online_Voting_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/home
        [HttpGet]
        public ActionResult<IEnumerable<Voter>> GetVoters()
        {
            return _context.Voters.ToList();
        }
    

        // GET: api/home/5
        [HttpGet("{id}")]
        public ActionResult<Voter> GetVoter(int id)
        {
            var voter = _context.Voters.Find(id);

            if (voter == null)
            {
                return NotFound();
            }

            return voter;
        }

        // POST: api/home
        [HttpPost]
        public ActionResult<Voter> PostVoter(Voter voter)
        {
            _context.Voters.Add(voter);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetVoter), new { id = voter.Id }, voter);
        }

        // PUT: api/home/5
        [HttpPut("{id}")]
        public IActionResult PutVoter(int id, Voter voter)
        {
            if (id != voter.Id)
            {
                return BadRequest();
            }

            _context.Entry(voter).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/home/5
        [HttpDelete("{id}")]
        public IActionResult DeleteVoter(int id)
        {
            var voter = _context.Voters.Find(id);

            if (voter == null)
            {
                return NotFound();
            }

            _context.Voters.Remove(voter);
            _context.SaveChanges();

            return NoContent();
        }

        
    }
}
