using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "hello";

            int maxLives = 7;
            int CurrentLives = maxLives;

            bool win=false;

            List<char>guessedLetters = new List<char>();

            while(CurrentLives>0 && !win)
            {
                foreach(char c in word)
                {
                    if (guessedLetters.Contains(c))
                    {
                        Console.WriteLine(c);

                    }
                    else
                    {
                        Console.WriteLine("_");
                    }
                }
                Console.WriteLine("\n please guess a letter ");
                Console.WriteLine(CurrentLives + "/" + maxLives + "lives remaining");
                char guess=Convert.ToChar(Console.ReadLine());

                if(word.Contains(guess) && !guessedLetters.Contains((char)guess))
                {
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("incorrect");
                    CurrentLives--;
                }
                guessedLetters.Add(guess);

                bool wordComplete = true;

                foreach(char c in word) { 
                if (!guessedLetters.Contains(c))
                    {
                        wordComplete = false;
                    }
                }
                win = wordComplete;
            }
            if (win)
            {
                Console.WriteLine("tebrk");

            }
            else
            {
                Console.WriteLine("sorry");
            }
        }
    }
}
