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
            AppLogic appLogic = new AppLogic();

            Console.WriteLine("Nombre del Jugador: ");
            string name = Console.ReadLine();
            Player player = new Player(name);

            Console.WriteLine("\nInserte la cantidad de fichas: ");
            int size = int.Parse(Console.ReadLine());
            BingoService bs = new BingoService(size);

            Console.WriteLine("\nSeleccione el modo de juego: ");
            Console.WriteLine(" 1  - Carton lleno");
            Console.WriteLine(" 2  - 4 esquinas");
            Console.WriteLine(" 3  - H");
            Console.WriteLine(" 4  - X");
            Console.WriteLine(" 5  - 0");
            Console.WriteLine(" 6  - U");
            Console.WriteLine(" 7  - P");
            Console.WriteLine(" 8  - A");
            Console.WriteLine(" 9  - E");
            Console.WriteLine(" 10 - W");
            Console.WriteLine(" 11 - R");
            int modeId = int.Parse(Console.ReadLine());
            int[,] mode = appLogic.SelectMode(modeId);

            Console.WriteLine("\nNumero de cartones: ");
            int numberOfCardboards = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCardboards; i++)
            {
                player.AddCarboard(bs.DealCardboard());
                System.Threading.Thread.Sleep(20);
            }

            appLogic.PrintPlayerCardboards(player.Cardboards);

            bool win = appLogic.ValidatePlayerGame(player.Cardboards, mode);
            int count = 0;

            while (!win && count < size)
            {
                System.Threading.Thread.Sleep(20);
                Position p = bs.CallPosition();
                appLogic.PrintPosition(p);
                appLogic.ValidatePlayerCardboard(p, player.Cardboards);
                appLogic.PrintPlayerCardboards(player.Cardboards);
                win = appLogic.ValidatePlayerGame(player.Cardboards, mode);
                count++;
            }

            Console.WriteLine("--------------------------------------");

            if (win) Console.WriteLine($"{player.PlayerName} has ganado!!");
            else Console.WriteLine($"{player.PlayerName} has perdido :(");
        }
    }
}
