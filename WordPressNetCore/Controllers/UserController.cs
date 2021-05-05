using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordPressNetCore.Models;
using WordPressNetCore.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordPressNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository repository;
        /*public UserController(IServiceProvider provider)
        {
            //repository = provider.GetService(typeof(UserRepository));

        }*/

        public UserController(IUserRepository repository)
        {
            //repository = provider.GetService(typeof(UserRepository));
            this.repository = repository;
        }

        // GET: api/<UserController>
        [HttpGet] //List of Users
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")] // Get a user by id
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost] // Save a user
        public void Post([FromBody] User value)
        {
            //var userRepository = new UserRepository();
            repository.Insert(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")] // Update a user
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")] // Delete a user
        public void Delete(int id)
        {
        }
    }
}
