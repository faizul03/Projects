using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_test
{
    class Program
    {
        static void Main(string[] args)
        {

            //            Console.WriteLine("Please enter a number");
            //            var input = Console.ReadLine();
            //           var number = Convert.ToInt32(input);

            //            if (number >=1 && number <= 10)
            //            {
            //                Console.WriteLine("Vaild");
            //                Console.ReadKey();


            //            }
            //            else
            //            {
            //                Console.WriteLine("Invaild");
            //                Console.ReadKey();
            //            }

            //            Console.WriteLine("Enter a Number");
            //            var number1 = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("Enter another number");
            //            var number2 = Convert.ToInt32(Console.ReadLine());

            //            var max = (number1 > number2) ? number1 : number2;
            //            Console.WriteLine("Max is " + max);


            //            Console.WriteLine("Image width");

            //            var Width = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("Imaage Height");

            //            var Height = Convert.ToInt32(Console.ReadLine());

            //            var orientation = Width > Height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            //            Console.WriteLine("Image Orientation is" + orientation);

            //            Console.WriteLine("Enter your speed limit");
            //            var speedLimit = Convert.ToInt32(Console.ReadLine());


            //            Console.WriteLine("Enter the speed limit of your car");
            //            var carSpeed = Convert.ToInt32(Console.ReadLine());

            //            if (carSpeed < speedLimit)
            //                Console.WriteLine("OK");
            //            else
            //            {
            //                const int kmPerDemeritPoint = 5;
            //                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
            //                if (demeritPoints > 12)
            //                    Console.WriteLine("License Suspended");
            //                else
            //                    Console.WriteLine("Demerit points: " + demeritPoints);


            //// For Loop 
            //                for (int i = 0; i < 10; i++)
            //                {
            //                    if (i%2 == 0)
            //                    {
            //                        Console.WriteLine(i);
            //                    }
            //                }
            //                for (int i = 10; i >= 3; i--)
            //                {
            //                    if (i % 2 == 0)
            //                    {
            //                        Console.WriteLine(i); ;

            //                    }

            //                    var name = "sam smith";

            //                    foreach (var names in name)
            //                    {
            //                        Console.WriteLine(names);
            //                    }
            //                    var numbers = new int[] { 1, 2, 3,4 };
            //                    foreach (var myNumber in numbers)
            //                    {
            //                        Console.WriteLine(myNumber);
            //                    }

            //                    // While loops.
            //                    var a = 0;
            //                    while (a <= 10)
            //                    {
            //                        if (a % 2 == 0)
            //                        {
            //                            Console.WriteLine(a);
            //                            Console.ReadLine();

            //                            a++;




            //                        }
            //while (true)
            //{
            //    Console.Write("Type in your name: ");
            //    var inppt =Console.ReadLine();
            //    if (!String.IsNullOrWhiteSpace(inppt))
            //    {
            //        Console.WriteLine("@Echo: " + inppt);
            //        continue;
            //    }
            //    break;


            //                var random = new Random();

            //                for (int c = 0; c < 10; c++)
            //                {
            //                    Console.WriteLine((char)('a' + random.Next(0,26)));
            //                }
            //            Console.WriteLine();

            ////Console.WriteLine((int)'a');
            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)  
                {
                    Console.WriteLine(i);

                }
                var sum = 0;
                while (true)
                {
                    Console.WriteLine("Enter a number between 1 to 10(or 'ok' to exit)");
                    var input = Console.ReadLine();
                    if (input.ToLower() == "ok")
                        break;
                    sum += Convert.ToInt32(input);
                    {
                        Console.WriteLine("Sum of all number is: " +sum);
                        Console.WriteLine("@echo." +input);
                    }
                }
                {

                }
            }

                            
                           
                            {
                

                            }

                        }

                    }
                }
                    
               