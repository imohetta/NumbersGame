using System;
using System.Linq;
using System.Text;


namespace numbersgame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determine Difficulty Level
            int difficulty= 0;

            Console.Write("Welcome To The Numbers Guessing Game, There Are 3 Levels, Easy, Medium And Hard. Press Enter Key To Continue");
            Console.ReadLine();
            Console.Write("Select Difficulty Easy(1), Medium(2) or Hard(3): ");
            difficulty= int.Parse(Console.ReadLine());





            if (difficulty==1)
            {
                //Generates Random Number. using Random generates numbers up to the number just before the specified upper range number.
                //Please can you explain why in the next video?
                Random rnd = new Random();
                int random = rnd.Next(1,11);
                // Console.Write(random);
                
                //loop determines the number of tries you get.
                for (int i = 6; i > 0; i--)
                {

                int num = 0;
                Console.Write("Guess The Number From 1-10, You have " + i + " Chances: ");
                num = int.Parse(Console.ReadLine());   
                
                //if correct, it breaks loop here.
                if (num==random)
                {
                    Console.WriteLine("Hurray, You Guessed Right");
                    break;
                }

                //when chances are exhausted, it tells you the number.
                else if(i==1)
                {
                       Console.WriteLine("Sorry, The Number Was " + random);
                }
                //prompts if wrong and you get another chance
                else 
                {
                    Console.Write("Wrong, Try Again: ");
                    
                }

                }
            }

            else if(difficulty==2)
            {
                 Random rnd = new Random();
                int random = rnd.Next(1,21);
                

                for (int i = 4; i > 0; i--)
                {

                int num = 0;
                Console.Write("Guess The Number From 1-20, You have " + i + " Chances: ");
                num = int.Parse(Console.ReadLine());   
                
                if (num==random)
                {
                    Console.WriteLine("Hurray, You Guessed Right");
                    break;
                }

                else if(i==1)
                {
                       Console.WriteLine("Sorry, The Number Was " + random);
                }

                else 
                {
                    Console.Write("Wrong, Try Again: ");
                    
                }
                }
            }



            else if (difficulty==3)
            {
                 Random rnd = new Random();
                int random = rnd.Next(1,51);
                

                for (int i = 3; i > 0; i--)
                {

                int num = 0;
                Console.Write("Guess The Number From 1-50, You have " + i + " Chances: ");
                num = int.Parse(Console.ReadLine());   
                
                if (num==random)
                {
                    Console.WriteLine("Hurray, You Guessed Right");
                    break;
                }

                else if(i==1)
                {
                       Console.WriteLine("Sorry, The Number Was " + random);
                }
                else 
                {
                    Console.Write("Wrong, Try Again: ");
                    
                }
                      
                }
            }

            else
            {
                Console.WriteLine("Difficulty Only From Level 1-3");
            }
        }
    }
}
