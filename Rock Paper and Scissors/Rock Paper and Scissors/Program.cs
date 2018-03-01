using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_and_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Welcome to Rock, Paper, scissors\n");
            //Console.ReadLine();
            Console.WriteLine("Make your choice:\n");
            gameFunc();


        }
        public static void gameFunc()
        {
            do
            {
                Random numberGen = new Random();

                string rock = "ROCK";
                string paper = "PAPER";
                string scissors = "scissors";
                string choice = Console.ReadLine();

                int random = numberGen.Next(1, 4);
                choice = choice.ToUpper();


                switch (random)
                {
                    case 2:
                        if (choice == rock)
                        {
                            Console.WriteLine(choice + " <-you vs. us-> " + rock + ".\n");
                            Console.WriteLine("Look's like it's a tie, try again!");
                        }
                        else if (choice == paper)
                        {
                            Console.WriteLine(choice + " <-you vs. us-> " + rock + ".\n");
                            Console.WriteLine("You win!");
                        }
                        else if (choice == scissors)
                        {
                            Console.WriteLine(choice + " <-you vs. us-> " + rock + ".\n");
                            lose();
                        }
                        else
                        {
                            Console.WriteLine("I can't make any sense of " + choice + "\nDoes not compute.");
                        }
                        break;
                    case 1:
                        if (choice == rock)
                        {
                            Console.WriteLine(choice + " <-you vs. us-> " + paper + ".\n");
                            lose();

                        }
                        else if (choice == paper)
                        {
                            Console.WriteLine(choice + " <-you vs. us-> " + paper + ".\n");
                            Console.WriteLine("That's a tie.");
                        }
                        else if (choice == scissors)
                        {
                            Console.WriteLine(choice + " <-you vs. us-> " + paper + ".\n");
                            Console.WriteLine("Looks like we have ourselves a winner!");

                        }
                        else
                        {
                            Console.WriteLine("I can't make any sense of " + choice + "\nDoes not compute.");
                        }
                        break;
                    default:
                        if (choice == rock)
                        {
                            Console.WriteLine(choice + " <-you vs. us-> " + scissors + ".\n");
                            Console.WriteLine("You may have won this time, but next time victory is mine!");
                        }
                        else if (choice == paper)
                        {
                            Console.WriteLine(choice + " <-you vs. us-> " + scissors + ".\n");
                            lose();
                        }
                        else if (choice == scissors)
                        {
                            Console.WriteLine(choice + " <-you vs. us-> " + scissors + ".\n");
                            Console.WriteLine("Looks like we've tied my boy!");
                        }
                        else
                        {
                            Console.WriteLine("I can't make any sense of " + choice + "\nDoes not compute.");
                        }
                        break;
                }
            } while (Console.ReadLine() == "yes");
        }


        public static void lose()

        {
            do
            {

         
            Random numbGen = new Random();
            int random = numbGen.Next(1, 4);

            switch (random)
            {
                case 1:
                    Console.WriteLine("Sorry, but you lose. Better luck next time!");
                    break;
                case 2:
                    Console.WriteLine("You lost, maybe next time you'll win.");
                    break;
                default:
                    Console.WriteLine("Nice try, hope to see you again.");
                    break;


            }
            } while (Console.ReadLine() == "yes");

        }
    }
}
    



    
