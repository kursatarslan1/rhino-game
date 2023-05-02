using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoGame
{
    class Rhino
    {
        public int x;
        public int y;
        public int[,] matrix;
        public int sizeMatrix;

        public int[,] rhinoShape1 = new int[3, 3]  // iki boyutlu dizileri kullanarak tetromino şekillerini oluşturuyoruz.
        {
                 {0,1,0 },
                 {1,1,1 },
                 {1,0,1 },
        };

        public int[,] rhinoShape2 = new int[3, 3]  // iki boyutlu dizileri kullanarak tetromino şekillerini oluşturuyoruz.
        {
                 {1,1,0 },
                 {0,1,1 },
                 {1,1,0 },
        };
        public int[,] rhinoShape3 = new int[3, 3]  // iki boyutlu dizileri kullanarak tetromino şekillerini oluşturuyoruz.
        {
                 {1,0,1 },
                 {1,1,1 },
                 {0,1,0 },
        };
        public int[,] rhinoShape4 = new int[3, 3]  // iki boyutlu dizileri kullanarak tetromino şekillerini oluşturuyoruz.
        {
                 {0,1,1 },
                 {1,1,0 },
                 {0,1,1 },
        };




        public Rhino(int _x, int _y)
        {
            x = _x;
            y = _y;
            matrix = rhinoShape1;
            sizeMatrix = (int)Math.Sqrt(matrix.Length);
        }

        public void moveDown()
        {
            y++;
        }

        public void moveLeft()
        {
            x--;
        }
        public void moveRight()
        {
            x++;
        }
        public void moveUp()
        {
            y--;
        }
    }
}
