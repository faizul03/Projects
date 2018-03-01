using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow World");
            Console.ReadKey();

            Console.WriteLine("Enter Your name");
            string enterdata =Console.ReadLine();
            Console.WriteLine("you have entered " + enterdata);
            Console.ReadLine();

            if (enterdata.Length > 10) ;
            {
                Console.WriteLine("name should not be greaterr than 10");
            }



        }
       
    }
}
