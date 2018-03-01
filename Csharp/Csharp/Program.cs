using Csharp.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = new Season.Summmer;


            switch (season)
            {
                case Season.Autumn:
                  case Season.Spring:
                    Console.WriteLine("I ove summer");
                    break;

                case Season.Spring:
                    Console.WriteLine("Nice day to go outside");
                    break;

                default:
                    Console.WriteLine("I don't understand that season");
                    break;

            }
        }
    }
}


                   

            









    





       
 








