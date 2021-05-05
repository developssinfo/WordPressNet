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

        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return repository.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return repository.GetById(id);
        }

        // GET api/<UserController>/5
        [HttpGet("getUsersByName/{name}")]
        public List<User> GetUsersByName(string name)
        {
            return repository.GetUsersByName(name);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            repository.Insert(value);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public User Put([FromBody] User value)
        {
            return repository.Update(value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return repository.Delete(id);
        }
    }
}
