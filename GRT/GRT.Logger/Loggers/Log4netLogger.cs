using GRT.Logger.Interfaces;
using log4net;
using log4net.Config;
using log4net.Repository;
using System;
using System.IO;

namespace GRT.Logger.Loggers
{
    public class Log4netLogger : ILogger
    {
        #region Constructor

        public Log4netLogger()
        {
            // All configuration details depends from your config file!!!
            // Need to copy config file with folder to result directory!

            ILoggerRepository loggerRepository = GetLoggerRepository();

            var configFile = GetConfigFile(GetConfigPath());

            XmlConfigurator.Configure(loggerRepository, configFile);

            _logger = LogManager.GetLogger(_repositoryName, _loggerName);
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

        #region HelperMethods

        private String GetConfigPath()
        {
            String configPath = Path.Combine(
                AppContext.BaseDirectory 
                    + Path.DirectorySeparatorChar
                    + _configFileDir
                    + Path.DirectorySeparatorChar,
                _configFileName);

            return configPath;
        }

        private FileInfo GetConfigFile(String path)
        {
            var configFile = new FileInfo(path);

            return configFile;
        }

        private ILoggerRepository GetLoggerRepository()
        {
            ILoggerRepository loggerRepository = null;

            try
            {
                loggerRepository = LogManager.CreateRepository(_repositoryName);
            }
            catch (Exception ex)
            {
                loggerRepository = LogManager.GetRepository(_repositoryName);
            }

            return loggerRepository;
        }

        #endregion

        #region Fields

        private readonly ILog _logger;
        private readonly String _repositoryName = "Log4netRepository";
        private readonly String _configFileDir = "LoggerConfigurations";
        private readonly String _configFileName = "Log4net.config";
        private readonly String _loggerName = "RollingFileAppender";

        #endregion
    }
}
