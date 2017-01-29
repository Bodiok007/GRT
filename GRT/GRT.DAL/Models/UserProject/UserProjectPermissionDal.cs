using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.UserProject
{
    [Table(name: "UserProjectPermission")]
    public class UserProjectPermissionDal
    {
        public Int32 UserId { get; set; }
        public Int32 ProjetId { get; set; }
        public Int32 PermissionlId { get; set; }

        public virtual UserDal User { get; set; }
        public virtual ProjectDal Project { get; set; }
        public virtual PermissionDal Permission { get; set; }
    }
}
