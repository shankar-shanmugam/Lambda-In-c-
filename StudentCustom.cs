using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaDemo
{
    internal class StudentCustom
    {
        public string Name { get; set; }
        public int Id { get; set; }


        public static void SortStudentsByName(List<StudentCustom> list)
        {

          var s=  list.OrderBy((x) => x.Name);
            foreach(var x in s)
            {
                Console.WriteLine(x.Name+" "+x.Id);
            }

        }

    }
}
