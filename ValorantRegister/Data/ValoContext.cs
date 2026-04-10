using Microsoft.EntityFrameworkCore;
using ValorantRegister.Model;

namespace ValorantRegister.Data
{
    public class ValoContext : DbContext
    {
        public ValoContext (DbContextOptions <ValoContext> options) : base (options)
        {

        }

        public DbSet <ValoRegister> Users { get; set; }
    }
}
