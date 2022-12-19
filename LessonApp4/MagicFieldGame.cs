using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApp4
{
    internal class MagicFieldGame
    {
        private static object guessedChar;

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the MagicFieldGame ");
           
            Console.WriteLine("Let's get Started! ");
            Console.WriteLine("-----------------------\n\n");

            Console.WriteLine("----------------- ----- Please Enter Your Favorite Fruit name : \t");

        }

        public static void GuessWord()
        {
            Console.WriteLine("I thought of a word, which  you have to guess \n");
            string fruitName = Console.ReadLine();

            char [] sweetFruit = fruitName.ToCharArray();
            
            for (int index = 0; index < sweetFruit.Length; index++)
            {
                
                if (sweetFruit[index].ToString() == enterLetter())
                {
                    Console.WriteLine($"Congratulation, Your symbol letter matches my thought of the letter {sweetFruit[index]} \n");

                }
                else 
                {
                    Console.WriteLine("Please Enter The One English lowercase letter : \n");

                }
                
            }
            string guessedWord = new string(sweetFruit);
            if (fruitName == guessedWord)
            {
                Console.WriteLine("Congratulation, You Won and guessed the word {0}", fruitName);

            }
            else
            {
                Console.WriteLine("You Lost - game over");
                Console.WriteLine(sweetFruit.Length);
                Console.WriteLine(enterLetter().Length);
            }

        }

        static string enterLetter()
        {
            
            Console.WriteLine("Please Enter The One English letter : \n");
            string guessedLetter = Console.ReadLine();

            char[] gussedChar = guessedLetter.ToCharArray();
            
            if (gussedChar.Length == 1)
            {
                return guessedLetter;
                
            }
            else
            {
                return compareWord(guessedLetter); 
            }
        }

        static string compareWord(string guessedWord)
        {
            return guessedWord;
        }
       



    }
}
