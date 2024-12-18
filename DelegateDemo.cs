using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaDemo
{
    public delegate void AddDelegate(int a,int b);
    internal class DelegateDemo
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }

    }
}
