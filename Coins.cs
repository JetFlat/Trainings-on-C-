// Create a function which will count the minimum number of coins, which saller should give as a change. He can give only 25, 10, 5 and 1 (nominal of coins).
// For example: Change is 24 - He will give 2 x 10 + 4 x 1 coins, totaly = 6.

using System;
using System.Reflection.Metadata.Ecma335;

namespace Coins
{
    class Prgoram
    {
        public static int NumCoins (int change)
        {
            int i = 0; // i will count a number of coins to be given.
            while (change != 0)
            {
                if (change >= 25) 
                {
                    change = change - 25;
                    i++; 
                }

                else if (change >= 10) 
                {
                    change = change - 10;
                    i++;
                }
                else if (change >= 5) 
                {
                    change = change - 5;
                    i++;
                }
                else
                {
                    change = change - 1;
                    i++;
                };
                
                
            }
            return i;
            

            
        }static void Main()
        {
            
            int i = Convert.ToInt16(Console.ReadLine());// for user to put his own value to be considered as a change.
            while (i < 0)
            {
                Console.WriteLine("Change can`t be negative");
                i = Convert.ToInt16(Console.ReadLine());               

            }
            int test = NumCoins(i);
            Console.WriteLine(test);
        
        }

    } 
}

    
