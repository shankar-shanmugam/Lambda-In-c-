using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaDemo
{
    internal class Player
    {
        public string Name { get; set; }
        public int age { get; set; }

        public void CheckEligible(int age)
        {
          
            if (age >= 18)
            {
                Console.WriteLine("player is eligible");
            }
            else
            {
                throw new InvalidPlayerException("player age should be more that 18");
            }

        }

    }
}
