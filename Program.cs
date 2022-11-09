using System;
using System.Reflection.Metadata.Ecma335;

namespace Coins
{
    class Prgoram
    {
        public static int NumCoins (int change)
        {
            int i = 0;
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
            
            int i = Convert.ToInt16(Console.ReadLine());
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

    