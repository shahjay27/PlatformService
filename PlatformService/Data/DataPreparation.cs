using PlatformService.Models;

namespace PlatformService.Data
{
    public static class DataPreparation
    {
        public static void Populate(WebApplication webApplication)
        {
            using (var services = webApplication.Services.CreateScope())
            {
                SeedData(services.ServiceProvider.GetService<AppDBContext>());
            }
        }

        static void SeedData(AppDBContext dbContext)
        {
            if(!dbContext.Platforms.Any())
            {
                Console.WriteLine("--- Loading inital data");
                dbContext.Platforms.AddRange(
                    new Platform() { Name="SQL", Cost="Free", Publisher="Microsoft"},
                    new Platform() { Name=".NET", Cost="Free", Publisher="Microsoft"}
                );
                dbContext.SaveChanges();    

                Console.WriteLine("--- Inital Platform data loaded");
            }
            else
            {
                Console.WriteLine("--- Platforms already have initial test data loaded");
            }
        }
    }
}
