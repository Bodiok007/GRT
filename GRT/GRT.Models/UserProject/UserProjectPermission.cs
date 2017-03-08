using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.Models.UserProject
{
    public class UserProjectPermission
    {
        public Int32 UserId { get; set; }
        public Int32 ProjetId { get; set; }
        public Int32 PermissionId { get; set; }

        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
        //public virtual Permission Permission { get; set; }
    }
}
