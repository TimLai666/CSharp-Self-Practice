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
        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTANCE = 75;
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
                    break;
                case PieceType.White:
                    pieces[point.X, point.Y] = new WhitePiece(point.X, point.Y);
                    break;
                default:
                    return null;
            }
            Piece piece = pieces[point.X, point.Y];
            piece.Location = new Point(point.X * NODE_DISTANCE + OFFSET - Piece.IMAGE_WIDTH/2, point.Y * NODE_DISTANCE + OFFSET - Piece.IMAGE_HEIGHT/2);
            return piece;
        }

        public bool CheckWinner()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (pieces[i, j] == null)
                        continue;
                    if (CheckHorizontal(i, j) || CheckVertical(i, j) || CheckLeftDiagonal(i, j) || CheckRightDiagonal(i, j))
                        return true;
                }
            }
            return false;
        }

        private bool CheckRightDiagonal(int i, int j)
        {
            for (int x = i - 4, y = j + 4; x <= i && y >= j; x++, y--)
            {
                if (x < 0 || y >= 9 || x + 4 >= 9 || y - 4 < 0)
                    continue;
                if (pieces[x, y] != null && pieces[x + 1, y - 1] != null && pieces[x + 2, y - 2] != null && pieces[x + 3, y - 3] != null && pieces[x + 4, y - 4] != null)
                {
                    if (pieces[x, y].Type == pieces[x + 1, y - 1].Type && pieces[x, y].Type == pieces[x + 2, y - 2].Type && pieces[x, y].Type == pieces[x + 3, y - 3].Type && pieces[x, y].Type == pieces[x + 4, y - 4].Type)
                        return true;
                }
            }
            return false;
        }

        private bool CheckLeftDiagonal(int i, int j)
        {
            for (int x = i - 4, y = j - 4; x <= i && y <= j; x++, y++)
            {
                if (x < 0 || y < 0 || x + 4 >= 9 || y + 4 >= 9)
                    continue;
                if (pieces[x, y] != null && pieces[x + 1, y + 1] != null && pieces[x + 2, y + 2] != null && pieces[x + 3, y + 3] != null && pieces[x + 4, y + 4] != null)
                {
                    if (pieces[x, y].Type == pieces[x + 1, y + 1].Type && pieces[x, y].Type == pieces[x + 2, y + 2].Type && pieces[x, y].Type == pieces[x + 3, y + 3].Type && pieces[x, y].Type == pieces[x + 4, y + 4].Type)
                        return true;
                }
            }
            return false;
        }

        private bool CheckVertical(int i, int j)
        {
            for (int y = j - 4; y <= j; y++)
            {
                if (y < 0 || y + 4 >= 9)
                    continue;
                if (pieces[i, y] != null && pieces[i, y + 1] != null && pieces[i, y + 2] != null && pieces[i, y + 3] != null && pieces[i, y + 4] != null)
                {
                    if (pieces[i, y].Type == pieces[i, y + 1].Type && pieces[i, y].Type == pieces[i, y + 2].Type && pieces[i, y].Type == pieces[i, y + 3].Type && pieces[i, y].Type == pieces[i, y + 4].Type)
                        return true;
                }
            }
            return false;
        }

        private bool CheckHorizontal(int i, int j)
        {
            for (int x = i - 4; x <= i; x++)
            {
                if (x < 0 || x + 4 >= 9)
                    continue;
                if (pieces[x, j] != null && pieces[x + 1, j] != null && pieces[x + 2, j] != null && pieces[x + 3, j] != null && pieces[x + 4, j] != null)
                {
                    if (pieces[x, j].Type == pieces[x + 1, j].Type && pieces[x, j].Type == pieces[x + 2, j].Type && pieces[x, j].Type == pieces[x + 3, j].Type && pieces[x, j].Type == pieces[x + 4, j].Type)
                        return true;
                }
            }
            return false;
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
