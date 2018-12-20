using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Service
{
    public class Position
    {
        private string letter;
        private int number;

        public Position(string letter, int number)
        {
            this.letter = letter;
            this.number = number;
        }

        public override bool Equals(object obj)
        {
            var position = obj as Position;
            return position != null &&
                   letter == position.letter &&
                   number == position.number;
        }

        public override string ToString()
        {
            return $"({letter}-{number})";
        }
    }
}
