using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> emplist = Data.GetEmployees();
            List<Department> dept = Data.GetDepartments();

            //1) question - i want to order the employee by departmentID

            var results = emplist.OrderBy(x => x.DepartmentId).ToList(); // syntax for Linq method 

            var results1 = from emp in emplist
                           orderby emp.DepartmentId // by default it is ascending 
                           select emp;

            var results2 = from emp in emplist
                           orderby emp.DepartmentId descending // to align as descending 
                           select emp;


            //foreach (var result in results2)
            //{
            //    Console.WriteLine($"ID:{result.Id,-5} FirstName:{result.FirstName,-10} LastName:{result.LastName,-10} AnnualSalary:{result.AnnualSalary,-10} DepartmentID:{result.DepartmentId,-10}");
            //}

            // 2) question - with department name also included with desending order of departmentID of first two only

            var results3 = emplist.Join(dept,  // using method syntax
                emp => emp.DepartmentId,
                de => de.Id,
                (emp, dep) => new  // anonymous object used to return new object with custom fields 
                {
                    emp.Id,
                    emp.FirstName,
                    emp.LastName,
                    DepartmentName = dep.LongName
                });

            var results4 = from emp in emplist // using query syntax
                           join dep in dept
                           on emp.Id equals dep.Id
                           select new
                           {
                               emp.Id,
                               emp.FirstName,
                               emp.LastName,
                               DepartmentName= dep.LongName

                           };

            foreach (var result in results4)
            {
                Console.WriteLine($"ID:{result.Id,-5} FirstName:{result.FirstName,-10} LastName:{result.LastName,-10} DepartmentName:{result.DepartmentName,-10}");
            }


        }


        public static int Multi(int a, int b)
        {
            return a * b;
        }
        static void Prac()
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

            //StudentCustom.SortStudentsByName(new List<StudentCustom> {

            //    new StudentCustom {   Id = 13,Name="shankar" } ,
            //    new StudentCustom {   Id = 2,Name="abi" } ,
            //    new StudentCustom {   Id = 14,Name="yuvan" } ,

            //});

            List<Person> list = new List<Person>() {
                new Person(){ssn=11234,name="shankar",age=14,Address="123 gandhi street" },
                new Person(){ssn=56634,name="Ram",age=32,Address="bangalore 14 cross" },
                new Person(){ssn=12782,name="santhosh",age=52,Address="hyderbad" },
                new Person(){ssn=99564,name="sree",age=62,Address="delhi" },

            };

            // top 2 records less than age 60
            foreach (var item in list.Where(x => x.age < 60).Take(2))
            {
                Console.WriteLine(item.name + " " + item.ssn + " " + item.age + " " + item.Address);
            }
            Console.WriteLine("------------------");

            // age between 13 and 18
            Console.WriteLine("age between 13 and 18");
            foreach (var item in list.Where(x => x.age >= 13 && x.age <= 18))
            {
                Console.WriteLine(item.name + " " + item.ssn + " " + item.age + " " + item.Address);
            }

            Console.WriteLine("----------average--------");

            var a = list.Average(x => x.age);
            Console.WriteLine("average is " + a);

            Console.WriteLine("------------------");

            var check = list.Any(p => p.name.Equals("shankar"));
            if (check) Console.WriteLine("prsent");
            else Console.WriteLine("not present");

            Console.ReadKey();
        }

        public static void ExceptionChecking()
        {

            // new ExceptionDemo().DivExceptionBy0();
            //  new ExceptionDemo().ArrOutOfBound();

            Console.WriteLine("Enter the age ");
            int age = int.Parse(Console.ReadLine());
            try
            {
                new Player().CheckEligible(age);
            }
            catch (InvalidPlayerException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
