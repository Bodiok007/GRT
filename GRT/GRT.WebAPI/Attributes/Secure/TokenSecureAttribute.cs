using GRT.DAL.Contexts;
using GRT.DAL.Models.Tokens;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.EF.Tokens;
using GRT.Logger.Interfaces;
using GRT.Logger.Loggers;
using GRT.Logger.Managers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GRT.WebAPI.Attributes.Secure
{
    public sealed class TokenSecureAttribute : ActionFilterAttribute
    {
        public TokenSecureAttribute()
        {
            _loggerManager = new Log4netLoggerManager(new Log4netLogger());
            _tokenRepository = new TokenRepository(new GrtContext());
        }

        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            String tokenValue = actionContext.HttpContext.Request.Headers[_authHeader];

            CheckIsTokenEmpty(tokenValue);
            CheckIsTokenExist(tokenValue);

            base.OnActionExecuting(actionContext);
        }

        #region Helper Methods

        private TokenDal GetToken(String tokenValue)
        {
            TokenDal token = null;

            try
            {
                token = _tokenRepository.Get(userToken => userToken.Value == tokenValue).FirstOrDefault();
            }
            catch (Exception ex)
            {
                _loggerManager.Error(_innerCheckTokenError, ex);
            }

            return token;
        }

        private void CheckIsTokenEmpty(String tokenValue)
        {
            if (String.IsNullOrEmpty(tokenValue) || String.IsNullOrWhiteSpace(tokenValue))
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
        }

        private void CheckIsTokenExist(String tokenValue)
        {
            TokenDal token = GetToken(tokenValue);

            if (token == null)
            {
                _loggerManager.Info(_invalidTokenError);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
        }

        #endregion

        #region Fields

        private readonly String _authHeader = "Authorization";
        private readonly String _invalidTokenError = "Invalid token (not found)";
        private readonly String _innerCheckTokenError = "Error when check token";

        private readonly ILoggerManager _loggerManager;
        private readonly BaseCRUDRepository<TokenDal, Int32> _tokenRepository;

        #endregion
    }
}
