using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using GRT.DAL.Models.UserProject;
using GRT.Models.UserProject;
using GRT.Logger.Interfaces;
using System.Web.Http;
using System;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using GRT.BLL.Managers.UserManagers;
using System.Net;
using System.Net.Http;
using GRT.BLL.Exceptions;
//using System.Net.Http;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GRT.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AccountController : ApiController
    {
        public AccountController(IMapper mapper, 
                                 ILogger logger,
                                 IUserManager userManager)
        {
            _mapper = mapper;
            _logger = logger;
            _userManager = userManager;
        }

        [HttpPost]
        [ActionName("register")]
        public User Regiter([FromBody]User user)
        {
            User registeredUser = null;

            try
            {
                registeredUser = _userManager.Register(user);
            }
            catch (InvalidUserFieldsException ex)
            {
                _logger.Error(ex);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest));
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }

            return registeredUser;
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

        #region Fields

        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        private readonly IUserManager _userManager;

        #endregion
    }
}
