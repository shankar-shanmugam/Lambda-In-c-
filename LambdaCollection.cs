using System.Collections.Generic;
using System;
using System.Linq;

namespace LambdaDemo
{
    internal class LambdaCollection
    {
        public void DemoUsingList()
        {
            // to find the square
            List<int> list = new List<int>() { 1, 2, 3, 4, 3, 223, 244, 64, 58, 224 };
            List<int> even = list.FindAll(x => x % 2 == 0);
            foreach (int x in even)
            {
                Console.WriteLine(x);
            }

            // to square the number
            Console.WriteLine("square--------------------");
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 3, 223, 244, 64, 58, 224 };
            list1 = list1.Select((x) => x * x).ToList(); // select will return IEnumerable
            foreach (int x in list1)
            {
                Console.WriteLine(x);
            }
        }
    }
}
