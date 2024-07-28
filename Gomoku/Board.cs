using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    internal class Board
    {
        public static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        public static readonly int NODE_DISTANCE = 75;
        private static readonly Point NO_MATCH_NODE = new Point(-1, -1);
        
        private Piece[,] pieces = new Piece[9, 9];

        public bool CanBePlaced(int x, int y)
        {
            Point closestPoint = FindTheClosestNode(x, y);
            if (closestPoint == NO_MATCH_NODE)
            {
                return false;
            }
            else
            {
                if (pieces[closestPoint.X, closestPoint.Y] != null)
                    return false;
                return true;
            }
        }

        public Piece PlaceAPiece(int x, int y, PieceType type)
        {
            Point point = FindTheClosestNode(x, y);
            if (point == NO_MATCH_NODE)
                return null;
            if (pieces[point.X, point.Y] != null)
                return null;

            switch (type) {
                case PieceType.Black:
                    pieces[point.X, point.Y] = new BlackPiece(point.X, point.Y);
                    return pieces[point.X, point.Y];
                case PieceType.White:
                    pieces[point.X, point.Y] = new WhitePiece(point.X, point.Y);
                    return pieces[point.X, point.Y];
                default:
                    return null;
            }
        }

        private Point FindTheClosestNode(int x, int y)
        {
            x = FindTheClosestNode(x);
            y = FindTheClosestNode(y);
            if (x == -1 || y == -1)
            {
                return NO_MATCH_NODE;
            }
            return new Point(x, y);
        }
        private int FindTheClosestNode(int x)
        {
            x -= OFFSET;
            int quotient = x / NODE_DISTANCE;
            int remainder = x % NODE_DISTANCE;
            if (remainder <= NODE_RADIUS)
            {
                return quotient;
            } else if (remainder >= NODE_DISTANCE - NODE_RADIUS)
            {
                return quotient + 1;
            } else
            {
                return -1;
            }
        }
    }
}
