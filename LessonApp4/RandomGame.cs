using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LessonApp4
{
    internal class RandomGame
    {
       
       public static void Welcome()
        {
            Console.WriteLine("Welcome to the RandomGame ");
            Console.WriteLine("You Have 3 Attampts to recognize the correct number");
            Console.WriteLine("Let's get Started! ");
            Console.WriteLine("--------------------------------------------\n");
            
        }


        public static void Recognize()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
           
            int attampts = 3;
            int count = 0;
            
            
            Console.WriteLine("Enter the numebr between 1 - 11");
            int gamersNumber = Convert.ToInt32(Console.ReadLine());

            if (gamersNumber >= 1 || gamersNumber <= 10)
            {
                if (gamersNumber <= 0 || gamersNumber >= 11)
                {
                  Console.WriteLine("Please enter the number in  the correct range ");
                }
                

                while (gamersNumber != randomNumber)
                {
                    attampts--;
                    Console.WriteLine($"You Still Have {attampts} attampts");
                    Console.WriteLine("------------------------------------\n");


                   
                    if (gamersNumber < randomNumber )
                    {
                        Console.WriteLine($"Your Entered Number - {gamersNumber} is less than random number");
                       
                        if (attampts == count)
                        {
                            Console.WriteLine("You Lost - game over");
                            break;
                        }
                        
                        if (gamersNumber <= 0 || gamersNumber >= 11)
                        {
                            Console.WriteLine("Please enter the number in  the correct range ");
                        }

                        Console.WriteLine("Please Enter The Next Number  ");
                        gamersNumber = Convert.ToInt32(Console.ReadLine());

                    }
                    else if (gamersNumber > randomNumber)
                    {
                        Console.WriteLine($"Unfortunately Your Number - {gamersNumber} is more than random number");

                        if (attampts == count)
                        {
                            Console.WriteLine("You Lost - game over");
                            break;
                        }

                        if (gamersNumber <= 0 || gamersNumber >= 11)
                        {
                            Console.WriteLine("Please enter the number in  the correct range ");
                        }

                        Console.WriteLine("Please Enter The Next Number  ");
                        gamersNumber = Convert.ToInt32(Console.ReadLine());
                       
                    }
                   
                   
                }; 
                
                if(gamersNumber == randomNumber)
                {
                    attampts--;

                        Console.WriteLine($"Congratulation! You Won - {randomNumber} is correct number");
                        Console.WriteLine("Thanks!");
                        Console.WriteLine("----------------------------------------------\n");
                    
                        if (attampts != count)
                        {
                           Console.WriteLine($"You Have had remain unused {attampts} attampts");

                        }
                        

                        Console.WriteLine("------------------------------------ Game Over\n");
                      
                }

            

            }
           
            Console.ReadKey();

        }

    }
}
