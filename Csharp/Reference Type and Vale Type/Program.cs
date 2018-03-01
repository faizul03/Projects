using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Type_and_Vale_Type
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);

            Console.WriteLine(number);
            

        }

        public static void Increment(int number)
        {

        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
