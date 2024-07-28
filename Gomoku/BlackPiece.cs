﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    internal class BlackPiece: Piece
    {
        public BlackPiece(int x, int y): base(x, y)
        {
            this.Image = Resources.black;
        }
    }
}
