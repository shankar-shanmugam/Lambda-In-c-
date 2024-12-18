using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaDemo
{
    internal class Program
    {
        public static int Multi(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            // 1) First way

            // DelegateDemo obj= new DelegateDemo(); // the class which is having required delegate method
            //AddDelegate d=new AddDelegate(obj.Add);// creating instance of delegate and add method address to d
            // d.Invoke(1,2); // inbuilt method used to invoke the method add() 

            // 2 way
            //AddDelegate d = new DelegateDemo().Add;
            //d(3, 5);

            // 3) way-(anonymous method)
            //AddDelegate d = delegate (int i, int j)
            //{
            //    Console.WriteLine( i+j);
            //};
            //d(3,4);


            // 4) way- lambda expression
            //AddDelegate d = (i, j) => Console.WriteLine(i+j);
            //d(17, 100);

            // 5) way- using inbuild delegates
            //Func<int,int,int> c = Multi;
            //Console.WriteLine(c(2,2));

            //  new LambdaCollection().DemoUsingList();

            StudentCustom.SortStudentsByName(new List<StudentCustom> {

                new StudentCustom {   Id = 13,Name="shankar" } ,
                new StudentCustom {   Id = 2,Name="abi" } ,
                new StudentCustom {   Id = 14,Name="yuvan" } ,
            
            });

        }


    }
}
