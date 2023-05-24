using Microsoft.EntityFrameworkCore;
using Online_Voting_System.Models;

namespace OnlineVotingSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Voter> Voters { get; set; }
    }
}