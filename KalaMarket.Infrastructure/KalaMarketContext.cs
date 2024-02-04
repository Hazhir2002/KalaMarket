using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KalaMarket.Infrastructure
{
    public class KalaMarketContext : IdentityDbContext
    {
        public KalaMarketContext(DbContextOptions<KalaMarketContext> options) : base(options)
        {
            
        }
    }
}
