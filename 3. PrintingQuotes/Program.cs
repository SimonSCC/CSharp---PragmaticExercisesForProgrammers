using System;

namespace _3._PrintingQuotes
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
            PrintingQuotes();
        }

        private void PrintingQuotes()
        {
            /*
             Quotation marks are often used to denote the start and end
            of a string. But sometimes we need to print out the quotation
            marks themselves by using escape characters.
            Create a program that prompts for a quote and an author.
            Display the quotation and author as shown in the example
            output.
            Example Output
            What is the quote? These aren't the droids you're looking for.
            Who said it? Obi-Wan Kenobi
            Obi-Wan Kenobi says, "These aren't the droids
            you're looking for."
            Constraints
            • Use a single output statement to produce this output,
            using appropriate string-escaping techniques for quotes.
            • If your language supports string interpolation or string
            substitution, don’t use it for this exercise. Use string
            concatenation instead.
            Challenge
            • In Chapter 7, Data Structures, on page 63, you’ll practice
            working with lists of data. Modify this program so that
            instead of prompting for quotes from the user, you create
            a structure that holds quotes and their associated
            attributions and then display all of the quotes using the
            format in the example. An array of maps would be a
            good choice.
             */
            Console.Write("Please enter a quote : ");
            string quote = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter a Author : ");
            string Author = Console.ReadLine();
            Console.WriteLine();

            string QuotedString = "\"" + quote + "\"";

            Console.WriteLine(Author + " Says: " + QuotedString);
            Console.ReadKey();


        }
    }
}
