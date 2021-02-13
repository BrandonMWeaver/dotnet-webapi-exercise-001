using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using dotnet_webapi_exercise_001.Data;
using dotnet_webapi_exercise_001.Dtos;
using dotnet_webapi_exercise_001.Models;

namespace dotnet_webapi_exercise_001.Controllers
{
    [ApiController]
    [Route("api/testmodels")]
    public class TestModelsController : ControllerBase
    {
        private readonly IAppRepo _repo;
        private readonly IMapper _mapper;

        public TestModelsController(IAppRepo repo, IMapper mapper)
        {
            this._repo = repo;
            this._mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TestModelReadDto>> GetAllTestModels()
        {
            IEnumerable<TestModel> testModels = this._repo.GetAllTestModels();

            return Ok(this._mapper.Map<IEnumerable<TestModelReadDto>>(testModels));
        }

        [HttpGet("{id}")]
        public ActionResult<TestModelReadDto> GetTestModelById(int id)
        {
            TestModel testModel = this._repo.GetTestModelById(id);

            if (testModel != null)
                return Ok(this._mapper.Map<TestModelReadDto>(testModel));
            return NotFound();
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
            return NoContent();
        }
    }
}
