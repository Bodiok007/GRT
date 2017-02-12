using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.UserProject
{
    [Table(name: "Permission")]
    public class PermissionDal
    {
        public PermissionDal()
        {
            UserProjectPermissions = new List<UserProjectPermissionDal>();
        }

        public Int32 Id { get; set; }
        public String Value { get; set; }

        public virtual ICollection<UserProjectPermissionDal> UserProjectPermissions { get; set; }
    }
}
