using GRT.DAL.Models.Tokens;
using GRT.DAL.Repositories.Base;
using System;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.Tokens
{
    public class TokenRepository
        : BaseCRUDRepository<TokenDal, Int32>
    {
        public TokenRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
