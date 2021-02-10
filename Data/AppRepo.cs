using System.Collections.Generic;
using System.Linq;

using dotnet_webapi_exercise_001.Models;

namespace dotnet_webapi_exercise_001.Data
{
    public class AppRepo : IAppRepo
    {
        private readonly AppContext _context;

        public AppRepo(AppContext context)
        {
            this._context = context;
        }

        public IEnumerable<TestModel> GetAllTestModels()
        {
            return this._context.TestModels;
        }

        public TestModel GetTestModelById(int id)
        {
            return this._context.TestModels.Where(tm => tm.Id == id).First();
        }

        public void CreateTestModel(TestModel testModel)
        {
            this._context.TestModels.Add(testModel);
            this._context.SaveChanges();
        }
    }
}
