using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    internal abstract class Piece: PictureBox
    {
        private static readonly int IMAGE_WIDTH = 50;
        private static readonly int IMAGE_HEIGHT = 50;

        public Piece(int x, int y)
        {
            this.BackColor = Color.Transparent;
            Point p = new Point(x - (IMAGE_WIDTH / 2), y - (IMAGE_HEIGHT / 2));
            this.Location = p;
            this.Size = new Size(50, 50);
        }
    }
}
