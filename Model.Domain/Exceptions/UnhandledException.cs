namespace Model.Domain.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UnhandledException : Exception
    {
        public UnhandledException(string message) : base(message)
        {
        }
    }
}
