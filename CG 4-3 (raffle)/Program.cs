using System;

namespace CG_4_3__raffle_
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Raffle");
            Console.WriteLine("Enter up to 30 names, hit enter key after each.  ");
            

            //declare array
            string[] userNames = new string[30];
            int number = 0;
            //declare number as an int so it can be used to represent numbers of names in array



            for (int i = 0; i < 30; i++)
                //30 names or less, use 0 through 29
            {
                //clarify for user what number the name they are entering is. since number starts at 0 must add one so user's first entry is #1
                Console.Write("Name {0}: ", i + 1);

                string raffleInfo = Console.ReadLine();
                userNames[i] = raffleInfo;
                //connect array to user input names and corresponding numbers for inputs.


                //add *break* to break out of loop if user enters blank entry
                //use if statement and if null or white space because they are finished making entries 
                if (string.IsNullOrWhiteSpace(raffleInfo)) break;
                number = i;
                //this variable was declared as an integer above, needed to be assigned the value of the number of each name

            }


            //to randomize user input names to get winner name
            var rnd = new Random();
            var winnerName = rnd.Next(number);
            Console.WriteLine($"The raffle winner is: { userNames[winnerName]}!");
            //print winner name from randomized choice from inside array

            Console.WriteLine("Sorry, you lose: ");

            //create another loop to print losers names from corresponding numbers and exclude printing winner name

            for (int L = 0; L <= number; L++)
                //i had to use less than or equal to number, less than number was cutting off the last value, adding = seems to have fixed the issue
            {
                if (L == winnerName)
                    continue;
                //if statement using *continue* to skip over winner name and continue printing the rest of the names to console
                Console.WriteLine(userNames[L]);
            }

            
            Console.ReadLine();

        }
    }
}
