using System;

namespace CG_4_3__raffle_
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create a program that asks the user to enter up to 30 names.If the user hits enter 
             * without entering a name, assume they are done and stop asking them.  Then you will 
             * randomly choose a name from the array and write it to the console as the winner.We haven't 
             * learned how to randomize yet, so you'll need to stretch your Googling skills.Then you will write 
             * the list of other names that did not win.*/

            Console.WriteLine("Raffle");

            //ask number of names after gathering names




           
            Console.Write($"Enter up to 30 names:  ");
            string nameOne = Console.ReadLine();

            //declare array
            string[] names = new string[30];

            
        


           //loop 
           //random
           //break out of loop with enter
           //how to keep null coming up with random
           //change 30 to smaller number for testing

            for (int i = 0; i < 30; i++)
            {
                names[i] = 
                Console.ReadLine();
            }


            foreach (var item in names)
            {
                Console.Write(item);
                

                
            }

            /*foreach (var item in collection)
            {

            }*/

            

            //gather up to 30 (can be less than 30) names from user. they will hit enter without name if done
            //randomly choose a name from array and print as winner
            //print list of loser names






            //Console.WriteLine($"The Raffle Winner is: {winner});
            //Console.ReadLine($"Raffle losers: ");
            Console.ReadLine();

        }
    }
}
