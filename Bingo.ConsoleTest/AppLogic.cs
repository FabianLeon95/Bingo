using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bingo.Service;

namespace Bingo.ConsoleTest
{
    class AppLogic
    {
        public void PrintCardboard(PositionCardboard[,] cardboard)
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
            Console.WriteLine("--------------------------------------");
        }

        public void PrintPlayerCardboards(List<PositionCardboard[,]> cardboards)
        {
            foreach (PositionCardboard[,] cardboard in cardboards)
            {
                PrintCardboard(cardboard);
            }
        }

        public void ValidatePlayerCardboard(Position corn, List<PositionCardboard[,]> cardboards)
        {
            for (int i = 0; i < cardboards.Count; i++)
            {
                BingoService.ValidateCardboard(corn, cardboards[i]);
                System.Threading.Thread.Sleep(20);
            }
        }

        public bool ValidatePlayerGame(List<PositionCardboard[,]> cardboards, int[,] mode)
        {
            foreach (PositionCardboard[,] cardboard in cardboards)
            {
                if (BingoService.ValidateGame(cardboard, mode))
                {
                    return true;
                }
                System.Threading.Thread.Sleep(20);
            }
            return false;
        }

        public int[,] SelectMode(int modeId)
        {
            switch (modeId)
            {
                case 1:
                    return Modes.Full;
                case 2:
                    return Modes.Corner;
                case 3:
                    return Modes.H;
                case 4:
                    return Modes.X;
                case 5:
                    return Modes.O;
                case 6:
                    return Modes.U;
                case 7:
                    return Modes.P;
                case 8:
                    return Modes.A;
                case 9:
                    return Modes.E;
                case 10:
                    return Modes.W;
                case 11:
                    return Modes.R;
                default:
                    return Modes.Full;
            }
        }
    }
}
