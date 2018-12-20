using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bingo.Service;

namespace Bingo.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BingoService bs = new BingoService(75);
            PositionCardboard[,] cardboard = bs.DealCardboard();
            PrintCardboard(cardboard);
            Console.WriteLine("--------------------------------------");
            bool win = bs.ValidateGame(cardboard, Modes.Corner);
            int count = 0;
            while (!win && count < 75)
            {
                System.Threading.Thread.Sleep(800);
                Position p = bs.CallPosition();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(p);
                Console.ResetColor();
                Console.WriteLine("--------------------------------------");
                bs.ValidateCardboard(p, cardboard);
                PrintCardboard(cardboard);
                win = bs.ValidateGame(cardboard, Modes.Corner);
                count++;
            }
            Console.WriteLine("--------------------------------------");

            if (win) Console.WriteLine("You Win!!!");
            else Console.WriteLine("Loser");
        }

        static void PrintCardboard(PositionCardboard[,] cardboard)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (cardboard[j, i].Marked)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(cardboard[j, i]);
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.Write(cardboard[j, i]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
