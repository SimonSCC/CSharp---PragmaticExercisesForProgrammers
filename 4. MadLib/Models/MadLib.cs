using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._MadLib.Models
{
    public class MadLib
    {
        Random rand;
        public List<string> Nouns { get; set; }
        public List<string> Verbs { get; set; }
        public List<string> Adjectives { get; set; }
        public List<string> Adverbs { get; set; }


        private int NounRandIndex
        {
            get
            {
                rand = new Random();
                return rand.Next(0, Nouns.Count - 1);
            }
        }

        private int VerbRandIndex
        {
            get
            {
                rand = new Random();
                return rand.Next(0, Verbs.Count - 1);
            }
        }

        private int AdjectiveRandIndex
        {
            get
            {
                rand = new Random();
                return rand.Next(0, Adjectives.Count - 1);
            }
        }

        private int AdverbsRandIndex
        {
            get
            {
                rand = new Random();
                return rand.Next(0, Adjectives.Count - 1);
            }
        }

        public MadLib()
        {
            Nouns = new List<string>();
            Verbs = new List<string>();
            Adjectives = new List<string>();
            Adverbs = new List<string>();
        }

        public void ConstructStory()
        {
            string story = $"Once upon a time, there was a {Nouns[NounRandIndex]} he had to {Verbs[VerbRandIndex]} to a {Nouns[NounRandIndex]} called {Nouns[NounRandIndex]}."
               + $" He {Adverbs[AdverbsRandIndex]} drew a {Adjectives[AdjectiveRandIndex]} {Nouns[NounRandIndex]}";
            Console.WriteLine(story);
        }

        public void InitiateGame()
        {
            Console.WriteLine("Please enter a bunch of nouns seperated by a comma. When you're done press enter");
            Console.WriteLine("Example: dog, cat, man, Simon, copenhagen, France");
            string nounsInput = Console.ReadLine();
            foreach (string noun in nounsInput.Split(','))
            {
                Nouns.Add(noun.Trim());
            }
            Console.WriteLine("Please enter a bunch of verbs seperated by a comma. When you're done press enter");
            Console.WriteLine("Example: walk, sit, stand, run, shoot, swim");
            string verbsInput = Console.ReadLine();
            foreach (string verb in verbsInput.Split(','))
            {
                Verbs.Add(verb.Trim());
            }
            Console.WriteLine("Please enter a bunch of Adjectives seperated by a comma. When you're done press enter");
            Console.WriteLine("Example: blue, green, good, bad, beautiful, splendid");
            string adjectiveInput = Console.ReadLine();
            foreach (string adjective in adjectiveInput.Split(','))
            {
                Adjectives.Add(adjective.Trim());
            }
            Console.WriteLine("Please enter a bunch of Adverbs seperated by a comma. When you're done press enter");
            Console.WriteLine("Example: quickly, slowly, furiously, strongly");
            string adverbInput = Console.ReadLine();
            foreach (string adverb in adverbInput.Split(','))
            {
                Adverbs.Add(adverb.Trim());
            }

            Console.WriteLine("The story is now ready, press enter to read it!");
            Console.ReadKey();
            ConstructStory();

        }

    }
}
