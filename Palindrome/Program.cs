using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //displays instructions and gets user's input
            Console.WriteLine("Please enter a word to check if it is a palindrome.");
            string input = Console.ReadLine();

            //deals with capitalization
            input = input.ToLower();
            //deals with spaces
            input = input.Trim(' ');
            //deals with punctuation
            string s = new string(input.Where(c => !char.IsPunctuation(c)).ToArray());

            if (IsPalindrome(s))
            {
                Console.WriteLine(input + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(input + " is not a palindrome.");
            }

            Console.ReadLine();
        }

        static bool IsPalindrome(string s)
        {
            //initialization of stack and queue
            Stack<char> palStack = new Stack<char>();
            Queue<char> palQueue = new Queue<char>();
            
            //pushes and enques the chars
            for (int i = 0; i < s.Length; i++)
            {
                palStack.Push(s[i]);
                palQueue.Enqueue(s[i]);
            }
            
                //runs through the s array, popping the chars off
                for (int i = 0; i < s.Length; i++)
                {
                   char st = palStack.Pop();
                   char qu = palQueue.Dequeue();
                    
                //if the chars arent the same, its not a palidrome
                    if (st != qu)
                    {
                       
                        return false;
                    }
                   
                }
            return true;
        }
    }
}
