using System;

namespace SnakesLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            int diceCount = 0;
            int diceNum;
            int option;
            Random random = new Random();
            while (position <= 100)
            {
                diceNum = random.Next(1, 7);
                diceCount++;
                option = random.Next(1, 4);
                if (option == 1)// No Play
                {
                    position += 0;
                }
                if (option == 2)// Ladder
                {
                    if (position + diceNum <= 100)
                    {
                        position += diceNum;
                    }
                    else
                    {
                        position += 0;
                    }
                }
                else //Snake
                {
                    if (position - diceNum > 0)
                    {
                        position -= diceNum;
                    }
                    else
                    {
                        position = 0;
                    }

                }
                Console.WriteLine("The final position is " + position);
            }
            Console.WriteLine("Dice was thrown " + diceCount + " times");
        }

    }
}

            
        }
    }


