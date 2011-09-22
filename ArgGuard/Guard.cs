using System;
using System.Diagnostics;

namespace ArgGuard
{
    public static class Guard
    {
        [DebuggerStepThrough]
        public static T NotNull<T>(T paramValue, string paramName)
        {
            if (paramValue == null)
            {
                throw new ArgumentNullException(paramName);
            }
            return paramValue;
        }

        [DebuggerStepThrough]
        public static string NotNullOrEmpty(string paramValue, string paramName)
        {
            if (paramValue == null)
            {
                throw new ArgumentNullException(paramName);
            }
            if (paramValue.Length == 0)
            {
                throw new ArgumentException("String must not be empty.", paramName);
            }
            return paramValue;
        }
    }
}