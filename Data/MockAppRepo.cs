using System.Collections.Generic;
using System.Linq;

using dotnet_webapi_exercise_001.Models;

namespace dotnet_webapi_exercise_001.Data
{
    public class MockAppRepo : IAppRepo
    {
        private readonly List<TestModel> testModels = new List<TestModel>
        {
            new TestModel { Id = 0, Value = "AAA" },
            new TestModel { Id = 1, Value = "BBB" },
            new TestModel { Id = 2, Value = "CCC" }
        };

        public IEnumerable<TestModel> GetAllTestModels()
        {
            return this.testModels;
        }

        public TestModel GetTestModelById(int id)
        {
            return this.testModels.Where(tm => tm.Id == id).First();
        }
    }
}
