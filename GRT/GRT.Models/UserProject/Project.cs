using System;
using System.Collections.Generic;

namespace GRT.Models.UserProject
{
    public class Project
    {
        public Project()
        {
            UserProjectPermissions = new List<UserProjectPermission>();
            //Menus = new List<Menu>();
        }

        public Int32 Id { get; set; }
        public Int32 OwnerId { get; set; }
        public String Name { get; set; }

        public virtual User Owner { get; set; }
        /*public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Level> Levels { get; set; }*/
        public virtual ICollection<UserProjectPermission> UserProjectPermissions { get; set; }
    }
}
