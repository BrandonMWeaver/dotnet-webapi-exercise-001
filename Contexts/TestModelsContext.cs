using Microsoft.EntityFrameworkCore;

using dotnet_webapi_exercise_001.Models;

namespace dotnet_webapi_exercise_001.Contexts
{
    public class TestModelsContext : DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=./Data/db/app_database.db");
        }
    }
}
