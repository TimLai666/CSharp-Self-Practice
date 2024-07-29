using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    internal abstract class Piece: PictureBox
    {
        public static readonly int IMAGE_WIDTH = 50;
        public static readonly int IMAGE_HEIGHT = 50;
        public PieceType Type;

        public Piece(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x - (IMAGE_WIDTH / 2), y - (IMAGE_HEIGHT / 2));
            this.Size = new Size(50, 50);
        }
    }
}
