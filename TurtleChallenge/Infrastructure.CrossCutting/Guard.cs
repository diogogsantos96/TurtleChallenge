namespace Infrastructure.CrossCutting
{
    using System;

    public class Guard
    {
        public static void Against<T>(bool validation, string message) where T : Exception, new()
        {
            if (validation)
                throw new T(message);
        }
    }
}
