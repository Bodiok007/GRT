using System;
using GRT.Models.Tokens;

namespace GRT.Models.UserProject
{
    public class User
    {
        public User()
        {
            /*UserProjectPermissions = new List<UserProjectPermission>();
            Projects = new List<Project>();
            Tokens = new List<Token>();*/
        }

        public Int32 Id { get; set; }
        public String Login { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Token Token { get; set; }


        /*public ICollection<Token> Tokens { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<UserProjectPermission> UserProjectPermissions { get; set; }*/
    }
}
