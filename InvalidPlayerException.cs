using System;
using System.Runtime.Serialization;

namespace LambdaDemo
{
    internal class InvalidPlayerException : Exception
    {
        public InvalidPlayerException(string message) : base(message)
        {

        }
    }
}