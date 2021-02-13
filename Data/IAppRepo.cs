using System.Collections.Generic;

using dotnet_webapi_exercise_001.Models;

namespace dotnet_webapi_exercise_001.Data
{
    public interface IAppRepo
    {
        bool SaveChanges();

        IEnumerable<TestModel> GetAllTestModels();
        TestModel GetTestModelById(int id);
        void CreateTestModel(TestModel testModel);
        void DeleteTestModel(int id);
    }
}
