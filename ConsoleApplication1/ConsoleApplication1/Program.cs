using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 100 + 5;
            var totalPrice = 21.99f;
            var name = 'A';

            var firstName = "Faizul";
            var isWorking = false;




            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(name);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            var text = @"Hi there here is the link to the page 
jacksonhew.com
click on learn mnore";

           
            Console.WriteLine(text);
        }
    
    }
}
