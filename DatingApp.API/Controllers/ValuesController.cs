using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    // http: localhost:5000/api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }


        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            // throw new Exception("Test Exception");
            // Initial code
            // return new string[] { "value1", "value2" };

            // Synchronous
            // var values = _context.Values.ToList();

            // Asynchronous
            var values = await _context.Values.ToListAsync();

            return Ok(values);
        }

        // GET api/values/S
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            // Initial code
            // return "value";

            // Synchronous
            // var value = _context.Values.FirstOrDefault(x => x.Id == id);

            // Asynchronous
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/S
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/S
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}