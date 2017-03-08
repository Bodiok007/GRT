using GRT.Models.UserProject;
using System;

namespace GRT.Models.Tokens
{
    public class Token
    {
        public Int32 Id { get; set; }
        public Int32 UserId { get; set; }
        public String Value { get; set; }
        public DateTime DateCreation { get; set; }

        public User User { get; set; }
    }
}
