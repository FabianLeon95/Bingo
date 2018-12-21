using Bingo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Bingo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void btnGivemeCard_Click(object sender, RoutedEventArgs e)
        {
            BingoService bs = new BingoService(75);
            txtCard.Text = "";
            PositionCardboard[,] cardboard = bs.DealCardboard();

            bool win = bs.ValidateGame(cardboard, Modes.Corner);
            int count = 0;
            while (!win && count < 75)
            {
                System.Threading.Thread.Sleep(50);
                Position p = bs.CallPosition();
                bs.ValidateCardboard(p, cardboard);
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
                }
                win = bs.ValidateGame(cardboard, Modes.Corner);
                count++;
            }
            if (win) txtStatus.Text = "You Win!!!";
            else txtStatus.Text = "Loser";
        }
    }
}