using GRT.DAL.Models.Levels;
using GRT.DAL.Models.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.UserProject
{
    [Table(name: "Project")]
    public class ProjectDal
    {
        public ProjectDal()
        {
            UserProjectPermissions = new List<UserProjectPermissionDal>();
            Menus = new List<MenuDal>();
        }

        public Int32 Id { get; set; }
        public Int32 OwnerId { get; set; }
        public String Name { get; set; }

        public virtual UserDal Owner { get; set; }
        public virtual ICollection<MenuDal> Menus { get; set; }
        public virtual ICollection<LevelDal> Levels { get; set; }
        public virtual ICollection<UserProjectPermissionDal> UserProjectPermissions { get; set; }
    }
}
