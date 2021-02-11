using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using dotnet_webapi_exercise_001.Data;
using dotnet_webapi_exercise_001.Models;

namespace dotnet_webapi_exercise_001.Controllers
{
    [ApiController]
    [Route("api/testmodels")]
    public class TestModelsController : ControllerBase
    {
        private readonly IAppRepo _repo;

        public TestModelsController(IAppRepo repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TestModel>> GetAllTestModels()
        {
            return Ok(this._repo.GetAllTestModels());
        }

        [HttpGet("{id}")]
        public ActionResult<TestModel> GetTestModelById(int id)
        {
            return Ok(this._repo.GetTestModelById(id));
        }

        [HttpPost]
        public ActionResult CreateTestModel(TestModel testModel)
        {
            this._repo.CreateTestModel(testModel);
            return RedirectToAction("GetAllTestModels");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTestModel(int id)
        {
            this._repo.DeleteTestModel(id);
            return RedirectToAction("GetAllTestModels");
        }
    }
}
