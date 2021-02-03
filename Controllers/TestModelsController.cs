using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using dotnet_webapi_exercise_001.Data;
using dotnet_webapi_exercise_001.Models;

namespace dotnet_webapi_exercise_001.Controllers
{
    [ApiController]
    [Route("api/testmodels")]
    public class TestModelsController : ControllerBase
    {
        private readonly MockAppRepo _repo = new MockAppRepo();

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
    }
}
