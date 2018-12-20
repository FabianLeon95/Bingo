using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Service
{
    public class BingoService
    {
        private int max;
        private List<Position> positionsPlayed;
        private string[] bingoLetters = { "B", "I", "N", "G", "O" };

        public BingoService(int max)
        {
            this.max = max / 5;
            positionsPlayed = new List<Position>();
        }

        public PositionCardboard[,] DealCardboard()
        {
            PositionCardboard[,] cardboard = new PositionCardboard[5, 5];
            Random random = new Random();
            List<int> selectedNumbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                selectedNumbers.Clear();
                for (int j = 0; j < 5; j++)
                {
                    string letter = bingoLetters[i];
                    int number = random.Next(i * max, max + (i * max)) +1;
                    while (selectedNumbers.Contains(number))
                    {
                        number = random.Next(i * max, max + (i * max))+1;
                    }
                    selectedNumbers.Add(number);
                    cardboard[i, j] = new PositionCardboard(letter, number);
                }
            }
            return cardboard;
        }

        public Position CallPosition()
        {
            Random random = new Random();
            int letterPos = random.Next(0, 5);
            int number = random.Next(letterPos * max, max + (letterPos * max))+1;
            Position position = new Position(bingoLetters[letterPos], number);
            while (positionsPlayed.Contains(position))
            {
                letterPos = random.Next(0, 5);
                number = random.Next(letterPos * max, max + (letterPos * max))+1;
                position = new Position(bingoLetters[letterPos], number);
            }
            positionsPlayed.Add(position);
            return position;
        }

        public bool ValidateGame(PositionCardboard[,] cardboard, int[,] mode)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (!(cardboard[i, j].Marked) && (mode[i,j]==1))
                    {
                        return false;
                    }
                }
            }
            return true;
        } 
        public bool ValidateCardboard(Position corn, PositionCardboard[,] cardboard)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (corn.Equals(cardboard[i,j]))
                    {
                        cardboard[i, j].Marked = true;
                        return true;
                    }
                }
            }
            return true;
        }
    }
}
