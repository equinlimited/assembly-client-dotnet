using System;

namespace AssemblyClient
{
    public class RequestThrottledException : Exception
    {
        public int Count { get; private set; }

        public int Period { get; private set; }

        public int Limit { get; private set; }

        public RequestThrottledException(string message, int count, int period, int limit)
            : base(message)
        {
            Count = count;
            Period = period;
            Limit = limit;
        }
    }
}
