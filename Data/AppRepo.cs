using System;
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

        public bool SaveChanges()
        {
            return this._context.SaveChanges() >= 0;
        }

        public IEnumerable<TestModel> GetAllTestModels()
        {
            return this._context.TestModels;
        }

        public TestModel GetTestModelById(int id)
        {
            return this._context.TestModels.FirstOrDefault(tm => tm.Id == id);
        }

        public void CreateTestModel(TestModel testModel)
        {
            if (testModel == null)
                throw new ArgumentNullException(nameof(testModel));

            this._context.TestModels.Add(testModel);
        }

        public void DeleteTestModel(int id)
        {
            TestModel testModel = this._context.TestModels.FirstOrDefault(tm => tm.Id == id);

            this._context.TestModels.Remove(testModel);
        }
    }
}
