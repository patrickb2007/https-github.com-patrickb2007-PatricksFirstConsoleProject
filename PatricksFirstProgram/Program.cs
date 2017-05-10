using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatricksFirstProgram
{
    class Program
    {


        public const int WAIT_TIME = 5000;

        static void Main(string[] args)
        {
            Console.WriteLine("Patrick's First Program");
            Console.WriteLine("\nWhat is your name?");
            string line = Console.ReadLine();

            while (line.ToLower() != "exit")
            {

                switch (line.ToLower())
                {
                    case "patrick":
                        Patrick();
                        break;
                    case "will":
                        Will();
                        break;
                    default:
                        Console.WriteLine("It's nice to meet you " + line);
                        Thread.Sleep(5000);

                        if (line.ToLower().Contains("butt"))
                        {
                            Console.WriteLine("That's a really stinky name!");
                        } 

                        if (line.ToLower().Contains("katelyn"))
                        {
                            Console.WriteLine("You stink!  But I love you!");
                        }
                        Console.WriteLine("Now go away...");
                        Thread.Sleep(WAIT_TIME);

                        break;
                }
                /*
                if (line.ToLower() == "patrick")
                {
                    Patrick();
                } else if (line.ToLower() == "will")
                {
                    Will();
                } else
                {
                    Console.WriteLine("It's nice to meet you " + line);
                    Thread.Sleep(5000);
                    Console.WriteLine("Now go away...");
                  
                }
                */
                Console.Clear();
                Console.WriteLine("\nWhat is your name?");
                line = Console.ReadLine();
            }

            Console.WriteLine("So long suckas!");
         

           
            Console.ReadKey();

        }

        static void Patrick()
        {
            Console.WriteLine("Hello Patrick!  So good to see you today!");
            Console.WriteLine("I hear you are 9!");
            Console.WriteLine("I'll talk to you later!");
            Thread.Sleep(WAIT_TIME);
        }

        static void Will()
        {
            Console.WriteLine("Hello Will!  You're looking silly today!");
            Console.WriteLine("I hear you are 5!");
            Console.WriteLine("You should take a bath stinky!");
            Thread.Sleep(WAIT_TIME);


        }

    }


}
