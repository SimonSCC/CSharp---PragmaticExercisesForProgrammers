using System;

namespace _1._SayingHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.StartProgram();
        }

        public void StartProgram()
        {
            SayingHello();
        }

        private void SayingHello()
        {
            /*
                The “Hello, World” program is the first program you learn
                to write in many languages, but it doesn’t involve any input.
                So create a program that prompts for your name and prints
                a greeting using your name.
                Example Output
                What is your name? Brian
                Hello, Brian, nice to meet you!

                    Constraint
                • Keep the input, string concatenation, and output separate.

                    Challenges
                • Write a new version of the program without using any
                variables.
                • Write a version of the program that displays different
                greetings for different people. This would be a good
                challenge to try after you’ve completed the exercises in
                Chapter 4, Making Decisions, on page 29 and Chapter 7,
                Data Structures, on page 63.
                Chapter 2. Input, Processing, and Output • 12
                More
              */
            Console.WriteLine("Hello what's your name?");
            string name = Console.ReadLine();
            switch (name.ToLower())
            {
                case "simon":
                    Console.WriteLine("What a pretty name Simon!");
                    break;
                case "sofie":
                    Console.WriteLine("Cool name, Sofie");
                    break;
                default:

                    Console.WriteLine("Okay, hello " + char.ToUpper(name[0]) + name.Substring(1));
                    break;
            }

            Console.ReadKey();


        }
    }
}
