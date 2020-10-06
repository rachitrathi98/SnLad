using System;

namespace SnakesLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            int positionPlayer1 = 0;
            int positionPlayer2 = 0;
            int diceCount = 0;
            int diceNum1;
            int option1;
            int diceNum2;
            int option2;
            Random random = new Random();
            while (positionPlayer1 <= 100 || positionPlayer2 <= 100)
            {
                diceCount++;
                diceNum1 = random.Next(1, 7);
                option1 = random.Next(1, 4);
                diceNum2 = random.Next(1, 7);
                option2 = random.Next(1, 4);
                if (option1 == 1)// No Play
                {
                    positionPlayer1 += 0;
                }
                if (option1 == 2)// Ladder
                {
                    if (positionPlayer1 + diceNum1 <= 100)
                    {
                        positionPlayer1 += diceNum1;
                    }
                    else
                    {
                        positionPlayer1 += 0;
                    }
                }
                else //Snake
                {
                    if (positionPlayer1 - diceNum1 > 0)
                    {
                        positionPlayer1 -= diceNum1;
                    }
                    else
                    {
                        positionPlayer1 = 0;
                    }

                }
                Console.WriteLine("The final position of Player 1 is " + positionPlayer1);

                if (option2 == 1)// No Play
                {
                    positionPlayer2 += 0;
                }
                if (option2 == 2)// Ladder
                {
                    if (positionPlayer2 + diceNum2 <= 100)
                    {
                        positionPlayer2 += diceNum2;
                    }
                    else
                    {
                        positionPlayer2 += 0;
                    }
                }
                else //Snake
                {
                    if (positionPlayer2 - diceNum2 > 0)
                    {
                        positionPlayer2 -= diceNum2;
                    }
                    else
                    {
                        positionPlayer2 = 0;
                    }

                }
                Console.WriteLine("The final position of Player 2 is " + positionPlayer2);
            }

            Console.WriteLine("Dice was thrown " + diceCount + " times");
        }

    }
}




