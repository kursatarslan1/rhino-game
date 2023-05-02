using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoGame
{
    class Mermi
    {
        public int x;
        public int y;
        public int[,] matrix;
        public int sizeMatrix;

        public int[,] mermi = new int[1, 1]
        {
                {2},
        };

        public Mermi(int x_, int y_)
        {
            x = x_;
            y = y_;
            matrix = mermi;
            sizeMatrix = (int)Math.Sqrt(matrix.Length);
        }
    }
}
