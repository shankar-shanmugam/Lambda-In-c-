using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaDemo
{
    internal class ExceptionDemo
    {
        public void DivExceptionBy0()
        {
            int num1 = 3;
            int num2 = 0;

            try
            {
                Console.WriteLine(num1 / num2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("execution finishes");
        }

        public void ArrOutOfBound()
        {
            int[] a= { 1, 2, 3 };

            try
            {
                Console.WriteLine(a[4]);
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("finished------");
        }


    }
}
