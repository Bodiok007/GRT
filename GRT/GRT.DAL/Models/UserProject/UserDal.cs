using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.UserProject
{
    [Table(name: "User")]
    public class UserDal
    {
        public UserDal()
        {
            UserProjectPermissions = new List<UserProjectPermissionDal>();
            Projects = new List<ProjectDal>();
        }

        public Int32 Id { get; set; }
        public String Login { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

        public virtual ICollection<ProjectDal> Projects { get; set; }
        public virtual ICollection<UserProjectPermissionDal> UserProjectPermissions { get; set; }
    }
}
