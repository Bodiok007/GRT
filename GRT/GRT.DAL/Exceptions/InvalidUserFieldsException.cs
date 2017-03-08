using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.BLL.Exceptions
{
    public class InvalidUserFieldsException : Exception
    {
        public InvalidUserFieldsException(String message = _defaultMessage)
            : base(message)
        {

        }

        private const String _defaultMessage = "Invalid user fields!";
    }
}
