using GRT.Models.UserProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.BLL.Managers.UserManagers
{
    public interface IUserManager
    {
        User Register(User user);
    }
}
