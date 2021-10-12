namespace Model.Domain.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HandledException : Exception
    {
        public HandledException(string message) : base(message)
        {
        }
    }
}
