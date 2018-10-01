using Microsoft.EntityFrameworkCore;

namespace codingclub.Models
{

    public class MemberContext : DbContext
    {
        public MemberContext (DbContextOptions<MemberContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Member { get; set; }
    }
}