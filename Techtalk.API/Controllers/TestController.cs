using Microsoft.AspNetCore.Mvc;
using TechTalk.Framework.Helper;
using TechTalk.Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Techtalk.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IStudentRepository _Student;
        public TestController(IStudentRepository Student)
        {
            _Student = Student;
        }
        /// <summary>
        /// To Get All Location Details
        /// </summary>
        /// <returns>All Application Settings Details</returns>
        [HttpGet]
       // [ActionName(SATActionName.ApplicationSettings.GetLogosAsync)]
        public async Task<IActionResult> GetStudentAsync()
        {
            // return Ok(await _Student.GetLogosAsync());
            return Ok();
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
