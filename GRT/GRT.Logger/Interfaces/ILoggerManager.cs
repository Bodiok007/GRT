using System;

namespace GRT.Logger.Interfaces
{
    public interface ILoggerManager
    {
        #region Error

        void Error(String message);

        void Error(Exception exception);

        void Error(String message, Exception exception);

        #endregion

        #region Debug

        void Debug(String message);

        void Debug(Exception exception);

        void Debug(String message, Exception exception);

        #endregion

        #region Info
        void Info(String message);

        void Info(Exception exception);

        void Info(String message, Exception exception);

        #endregion

        #region Warn

        void Warn(String message);

        void Warn(Exception exception);

        void Warn(String message, Exception exception);

        #endregion

        #region Fatal

        void Fatal(String message);

        void Fatal(Exception exception);

        void Fatal(String message, Exception exception);

        #endregion
    }
}
