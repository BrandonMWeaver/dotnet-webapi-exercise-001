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

        [HttpGet("{id}", Name = "GetTestModelById")]
        public ActionResult<TestModelReadDto> GetTestModelById(int id)
        {
            TestModel testModel = this._repo.GetTestModelById(id);

            if (testModel != null)
                return Ok(this._mapper.Map<TestModelReadDto>(testModel));
            return NotFound();
        }

        [HttpPost]
        public ActionResult<TestModelReadDto> CreateTestModel(TestModelCreateDto testModelCreateDto)
        {
            TestModel testModel = this._mapper.Map<TestModel>(testModelCreateDto);

            this._repo.CreateTestModel(testModel);
            this._repo.SaveChanges();
            
            TestModelReadDto testModelReadDto = this._mapper.Map<TestModelReadDto>(testModel);

            return CreatedAtRoute(nameof(GetTestModelById), new { Id = testModelReadDto.Id }, testModelReadDto);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTestModel(int id)
        {
            this._repo.DeleteTestModel(id);
            return NoContent();
        }
    }
}
