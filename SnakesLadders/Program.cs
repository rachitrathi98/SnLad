using System;

namespace SnakesLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0 ;
            Random random = new Random();
            int diceNum = random.Next(1, 7);
            int option = random.Next(1, 4);
            if (option == 1)// No Play
            {
                position = 0;
            }
            else if (option == 2)// Ladder
            {
                position += diceNum;
            }
            else //Snake
            {   
                    position -= diceNum;
                
            }
        }
    }
}