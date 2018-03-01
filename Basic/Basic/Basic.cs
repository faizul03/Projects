using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
           //Console.WriteLine("this is a test");
          //Console.Read();

            Console.WriteLine("size of int: {0}", sizeof(int));
            Console.ReadLine();

            int number;

            Console.WriteLine("Please enter a number between 0 and 10:");
            number = int.Parse(Console.ReadLine());

            if (number > 10)
                Console.WriteLine("Hey! The number should be 10 or less!");
            else
                if (number < 0)
                Console.WriteLine("Hey! The number should be 0 or more!");
            else
                Console.WriteLine("Good job!");

            Console.ReadLine();

            //Reference Type
            
            object obj;
            obj = 100; // this is boxing

          


        }
    }
}