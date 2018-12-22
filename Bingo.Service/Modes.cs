using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Service
{
    public class Modes
    {
        public static readonly int[,] Full=
        {
            {1,1,1,1,1},
            {1,1,1,1,1},
            {1,1,1,1,1},
            {1,1,1,1,1},
            {1,1,1,1,1}
        };
        public static readonly int[,] Corner =
{
            {1,0,0,0,1},
            {0,0,0,0,0},
            {0,0,0,0,0},
            {0,0,0,0,0},
            {1,0,0,0,1}
        };

        public static readonly int[,] H =
        {
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,1,1,1,1},
            {1,0,0,0,1},
            {1,0,0,0,1}
        };

        public static readonly int[,] X =
{
            {1,0,0,0,1},
            {0,1,0,1,0},
            {0,0,1,0,0},
            {0,1,0,1,0},
            {1,0,0,0,1}
        };

        public static readonly int[,] O =
{
            {1,1,1,1,1},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,1,1,1,1}
        };

        public static readonly int[,] U =
{
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,1,1,1,1}
        };

        public static readonly int[,] P =
{
            {1,1,1,1,1},
            {1,0,0,0,1},
            {1,1,1,1,1},
            {1,0,0,0,0},
            {1,0,0,0,0}
        };

        public static readonly int[,] A =
{
            {1,1,1,1,1},
            {1,0,0,0,1},
            {1,1,1,1,1},
            {1,0,0,0,1},
            {1,0,0,0,1}
        };

        public static readonly int[,] E =
{
            {1,1,1,1,1},
            {1,0,0,0,0},
            {1,1,1,1,1},
            {1,0,0,0,0},
            {1,1,1,1,1}
        };

        public static readonly int[,] W =
{
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,0,1,0,1},
            {1,1,0,1,1},
            {1,0,0,0,1}
        };

        public static readonly int[,] R =
{
            {1,1,1,1,1},
            {1,0,0,0,1},
            {1,1,1,1,1},
            {1,0,0,1,0},
            {1,0,0,0,1}
        };
    }
}
