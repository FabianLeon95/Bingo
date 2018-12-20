using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Service
{
    public class PositionCardboard : Position
    {
        public bool Marked { get; set; }

        public PositionCardboard(string letter, int number) : base(letter, number)
        {
            this.Marked = false;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
