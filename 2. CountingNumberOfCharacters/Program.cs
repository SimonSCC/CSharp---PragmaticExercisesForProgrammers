using System;

namespace _2._CountingNumberOfCharacters
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
            CountingNumberOfCharacters();
        }

        private void CountingNumberOfCharacters()
        {
            /*  Create a program that prompts for an input string and displays
                output that shows the input string and the number of
                characters the string contains.
                Example Output
                What is the input string? Homer
                Homer has 5 characters.
                Constraints
                • Be sure the output contains the original string.
                • Use a single output statement to construct the output.
                • Use a built-in function of the programming language to
                determine the length of the string.
                Challenges
                • If the user enters nothing, state that the user must enter
                something into the program.
                • Implement this program using a graphical user interface
                and update the character counter every time a key is
                pressed. If your language doesn’t have a particularly
                friendly GUI library, try doing this exercise with HTML
                and JavaScript instead.
             */

            //Console.WriteLine("Enter input");
            int lastLength = 0;
            string input = String.Empty;/* = Console.ReadLine();*/
            bool countSpacebar = true;
            //Console.WriteLine(input + " has " + input.Length + " characters");

            while (true)
            {


                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (input.Length != 0)
                    {
                        input = input.Remove(input.Length - 1);
                    }
                }
                else
                {
                    //ASCII values to determine that the pressed key represents a representable character
                    if (key.KeyChar >= 33 && key.KeyChar <= 126 || key.Key == ConsoleKey.Spacebar)
                    {
                        input += key.KeyChar;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        if (countSpacebar)
                        {
                            countSpacebar = false;
                        }
                        else
                        {
                            countSpacebar = true;
                        }
                        Console.SetCursorPosition(lastLength, 0);
                    }
                }
                if (input.Length != lastLength)
                {
                    lastLength = input.Length;
                    Console.Clear();
                    Console.WriteLine(input + "\n");

                    if (countSpacebar)
                    {
                        Console.WriteLine("Your input has " + lastLength + " characters");
                    }
                    else
                    {
                        int LengthWithNoSpacebar = input.Trim(' ').Length;
                        Console.WriteLine("Your input has " + LengthWithNoSpacebar + " characters");
                    }
                    Console.WriteLine();
                }

                //if (countSpacebar)
                //{
                //    Console.WriteLine("[x] count spacebar presses");
                //    Console.WriteLine("[0] don't count spacebar presses");
                //}
                //else
                //{
                //    Console.SetCursorPosition(0, 4);

                //    Console.WriteLine("[0] count spacebar presses");
                //    Console.WriteLine("[x] don't count spacebar presses");
                //}
                //Console.WriteLine("\n" + "To toggle press ENTER");

                Console.SetCursorPosition(lastLength, 0);

            }
        }
    }
}
