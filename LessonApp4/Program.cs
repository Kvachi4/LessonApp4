using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApp4
{


    internal class Program
    {
        static void MyArray()
        {
            int[] numbers = new int[10] {10,20,30,40,50,60,70,80,90,100 };
            int[] newNumbers = new int[11];

            for (int index = 0; index < numbers.Length; index++)
            {
                newNumbers[index] = numbers[index];
            }
            foreach (var item in newNumbers)
            { 
                Console.Write(item + "\t");
                Console.WriteLine( $" ---------------------------------\t {item} ");  
            }

        }

        static void Main(string[] args)
        {
            //first homework
            //MyArray();


            //this is RandomGame
            #region   - RandomGame
            //RandomGame.Welcome();
            //RandomGame.Recognize();
            #endregion


            //this is MagicFieldGame
            #region - MagicFieldGame
            MagicFieldGame.WelcomeMessage();
            MagicFieldGame.GuessWord();
            
            #endregion



            Console.ReadLine();
        }
    }
}
