using GRT.DAL.Models.UserProject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Tokens
{
    [Table(name: "Token")]
    public class TokenDal
    {
        public Int32 Id { get; set; }
        public Int32 UserId { get; set; }
        public String Value { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpiredDate { get; set; }

        public UserDal User { get; set; }
    }
}
