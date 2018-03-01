using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Hello World");
            // Console.ReadLine();

            var firstName = "Faizul";
            Console.WriteLine(firstName);
            // Console.ReadLine();


            int avg = 12 / 6;
            Console.WriteLine(avg);
            // Console.ReadLine();

            if (6 * 2 == 3)
            { 
                Console.WriteLine("your correct");
                Console.ReadLine();



            }

            else
            {
                Console.WriteLine("you anser is wrong");
                // Console.ReadLine();
            }
            // foreach loops
            //An array of integers
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            foreach (int n in array)
            {
                Console.WriteLine(n.ToString());
                Console.WriteLine();

            }
            //An array of Strings 
            string[] array1 = { "hello", "world" };

            foreach (string s in array1)
            {
                System.Console.WriteLine(s);
                //Console.ReadLine();
            }

            //for loops 

            // An array of integers
            int[] array2 = { 0, 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < 7; i++)
            //Or
            //for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i].ToString());
                // Console.ReadLine();
            }

            //An array of strings 
            string[] array3 = { "hello", "world" };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(array3[i]);
                // Console.ReadKey();
            }

            //Do while loops 

            int[] array4 = { 0, 1, 2, 3, 4, 5, 6, 7 };

            int x = 0;

            do
            {
                Console.WriteLine(array4[x].ToString());
                //Console.ReadLine();
                x++;
            } while (x < 8);

            //An Array of Strings 

            string[] array5 = { "Apple", "Orange", "Mango", "Pinnapple" };
            int y = 0;

            do
            {
                Console.WriteLine(array5[y]);

                Console.ReadLine();
                y++;
            } while (y < 4);

            //do some math 
            //Data type
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadKey();

            x = 6 * 2;
            Console.WriteLine(x);
            Console.ReadKey();

            y = 1000 + 1;
            Console.WriteLine(y);
            Console.ReadKey();

            x = 100;
            y = x / 50;
            Console.WriteLine(y);
            Console.ReadKey();


            /*
             * Data type
             * Read and write in concole
             */

            Console.WriteLine("What is your first name?");
            Console.Write("Enter you name: ");
            string myFirstName= Console.ReadLine();


            if (myFirstName == "Faizul")

            {
                Console.WriteLine("Your name is correct");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("you name is inncorrect");
                Console.ReadLine();
            }

            string myLastName;
            Console.Write("Enter your last name: ");
            myLastName=Console.ReadLine();

            if (myLastName =="")
            {
                Console.WriteLine("you last name is correct");
            }

            else
            {
                Console.WriteLine("your last name is inncorrect");
            }

            Console.WriteLine("Hello " + myFirstName +" " + myLastName);
            Console.ReadLine();


            // Additional data type 

            var FirstName = "Faizul";
            var lastName = "Islam";
            var day = "Wednesday";

            Console.WriteLine("Good morning " + FirstName + " " +lastName + " Today is " + day);
            Console.ReadLine();


            float nuumber = 1.2f;

            decimal number =
           

            

     
        }            

            }
        }


