using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Service
{
    public class Player
    {
        public string PlayerName { get; }
        public List<PositionCardboard[,]> Cardboards { get; }

        public Player(string playerName)
        {
            PlayerName = playerName;
            Cardboards = new List<PositionCardboard[,]>();
        }

        public void AddCarboard(PositionCardboard[,] cardboard)
        {
            Cardboards.Add(cardboard);
        }
    }
}
