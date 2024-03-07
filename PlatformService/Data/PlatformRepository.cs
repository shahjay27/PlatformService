using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepository : IPlatformRepository
    {
        readonly AppDBContext _context;

        public PlatformRepository(AppDBContext context)
        {
            _context = context;
        }

        public void CreatePlatform(Platform platform)
        {
            if(platform == null)
                throw new ArgumentNullException(nameof(platform));

            _context.Platforms.Add(platform);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(platform => platform.Id == id);
        }

        public bool Savechanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
