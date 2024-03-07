using Microsoft.EntityFrameworkCore;
using PlatformService.Models;
using System.Security.Cryptography.Xml;

namespace PlatformService.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> contextOptions) : base(contextOptions) 
        {
            
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
