using System;

using GRT.Logger.Interfaces;

namespace GRT.Logger.Managers
{
    public class Log4netLoggerManager : ILoggerManager
    {
        #region Constructor

        public Log4netLoggerManager(ILogger logger)
        {
            _logger = logger;
        }

        #endregion

        #region Debug

        public void Debug(String message)
        {
            _logger.Debug(message);
        }

        public void Debug(Exception exception)
        {
            _logger.Debug(exception);
        }

        public void Debug(String message, Exception exception)
        {
            _logger.Debug(message, exception);
        }

        #endregion

        #region Error

        public void Error(String message)
        {
            _logger.Error(message);
        }

        public void Error(Exception exception)
        {
            _logger.Error(exception);
        }

        public void Error(String message, Exception exception)
        {
            _logger.Error(message, exception);
        }

        #endregion

        #region Fatal

        public void Fatal(String message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(Exception exception)
        {
            _logger.Fatal(exception);
        }

        public void Fatal(String message, Exception exception)
        {
            _logger.Fatal(message, exception);
        }

        #endregion

        #region Info

        public void Info(String message)
        {
            _logger.Info(message);
        }

        public void Info(Exception exception)
        {
            _logger.Info(exception);
        }

        public void Info(String message, Exception exception)
        {
            _logger.Info(message, exception);
        }

        #endregion

        #region Warn

        public void Warn(String message)
        {
            _logger.Warn(message);
        }

        public void Warn(Exception exception)
        {
            _logger.Warn(exception);
        }

        public void Warn(String message, Exception exception)
        {
            _logger.Warn(message, exception);
        }

        #endregion

        #region Fields

        private readonly ILogger _logger;

        #endregion
    }
}
