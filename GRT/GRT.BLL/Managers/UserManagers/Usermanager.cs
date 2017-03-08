using System;
using GRT.Models.UserProject;
using GRT.Logger.Interfaces;
using AutoMapper;
using GRT.DAL.Models.UserProject;
using GRT.DAL.Repositories.Interfaces.UserProject;
using GRT.DAL.Repositories.Base;
using System.Linq;
using GRT.DAL.Exceptions;

namespace GRT.BLL.Managers.UserManagers
{
    public sealed class UserManager : BaseManager<User>, IUserManager
    {
        public UserManager(ILogger logger, 
                           IMapper mapper,
                           BaseCRURepository<UserDal, Int32> userRepository) 
            : base(logger, mapper)
        {
            _userRepository = userRepository;
        }

        public User Register(User user)
        {
            if (!IsUserValid(user))
            {
                throw new InvalidUserFieldsException();
            }

            _userRepository.Add(_mapper.Map<UserDal>(user));
            _userRepository.SaveChanges();

            User registeredUser = GetUserByLogin(user.Login);

            return registeredUser;
        }

        #region Helper Methods

        private User GetUserByLogin(String login)
        {
            UserDal user = _userRepository.Get(usr => usr.Login == login).FirstOrDefault();

            return _mapper.Map<User>(user);
        }

        private Boolean IsUserValid(User user)
        {
            Boolean isUserValid = false;

            if (user == null)
            {
                return isUserValid;
            }

            if (String.IsNullOrWhiteSpace(user.Login) || String.Empty.Equals(user.Login))
            {
                return isUserValid;
            }

            if (String.IsNullOrWhiteSpace(user.Password) || String.Empty.Equals(user.Password))
            {
                return isUserValid;
            }

            if (String.IsNullOrWhiteSpace(user.Email) || String.Empty.Equals(user.Email))
            {
                return isUserValid;
            }

            isUserValid = true;

            return isUserValid;
        }

        #endregion

        private readonly BaseCRURepository<UserDal, Int32> _userRepository;
    }
}
