using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eliza
{
    class Program
    {
        static void Main(string[] args)
        {
            //displays instructions
            Console.WriteLine("Hello, I am Eliza, please tell me how you feel.");

            //gets the user's input
            string input = Console.ReadLine();
            //makes the input lower case, to make the logic in BootlegEliza easier
            string lowerInput = input.ToLower();

            //calls the BootlegEliza method, prints it's response
            string eliResponse = BootlegEliza(input);
            Console.WriteLine(eliResponse);


            Console.ReadLine();
        }

        static string BootlegEliza(string lowerInput)
        {
            //initializes the string for eliza's response
            string eliza;
            //makes an array of the lowerInput
            string[] words = lowerInput.Split();

            //logic for determining Eliza's response
            if (words.Contains("my"))
            {
                int n = Array.IndexOf(words, "my");              
                string subject = words[n + 1];
                eliza = String.Format("Tell me more about your {0}", subject);
                return eliza;
            }
            else if (words.Contains("love")||words.Contains("hate"))
            {
                eliza = "You have strong feelings about that!";
                return eliza;
            }
            else
            {
                eliza = "Please go on...";
                return eliza;
            }
        }
    }
}
