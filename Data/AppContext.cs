using Microsoft.EntityFrameworkCore;

using dotnet_webapi_exercise_001.Models;

namespace dotnet_webapi_exercise_001.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> opt) : base(opt)
        {
            
        }

        public DbSet<TestModel> TestModels { get; set; }
    }
}
