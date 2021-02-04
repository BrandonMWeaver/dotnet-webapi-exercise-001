using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using dotnet_webapi_exercise_001.Contexts;
using dotnet_webapi_exercise_001.Models;

namespace dotnet_webapi_exercise_001.Controllers
{
    [ApiController]
    [Route("api/testmodels")]
    public class TestModelsController : ControllerBase
    {
        private readonly TestModelsContext _testModelsContext = new TestModelsContext();

        [HttpGet]
        public ActionResult<IEnumerable<TestModel>> GetAllTestModels()
        {
            return Ok(this._testModelsContext.TestModels);
        }

        [HttpGet("{id}")]
        public ActionResult<TestModel> GetTestModelById(int id)
        {
            return Ok(this._testModelsContext.TestModels.Where(tm => tm.Id == id));
        }
    }
}
