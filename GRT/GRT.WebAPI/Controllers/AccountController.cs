using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using GRT.DAL.Models.UserProject;
using GRT.Models.UserProject;
using GRT.Logger.Interfaces;
using System.Web.Http;
using System;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GRT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ApiController
    {
        public AccountController(IMapper mapper, ILogger logger)
        {
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            UserDal ud = new UserDal() { Password = "Password" };
            var mappedUser = _mapper.Map<User>(ud);
            _logger.Info(mappedUser.ToString());

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value323" + id.ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private readonly IMapper _mapper;
        private readonly ILogger _logger;
    }
}
