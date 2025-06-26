using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrytException : ApplicationException
    {
        public IntegrytException(string message) : base(message)
        {
        }
    }
}
