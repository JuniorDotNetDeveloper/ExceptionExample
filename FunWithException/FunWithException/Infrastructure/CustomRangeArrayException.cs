using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithException.Infrastructure
{
    internal sealed class CustomRangeArrayException : Exception
    {
        public CustomRangeArrayException() : base() {}

        public CustomRangeArrayException(string message) : base(message) {}

        public override string ToString()
        {
            return Message;
        }
    }
}
