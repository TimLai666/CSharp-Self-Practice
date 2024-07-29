using System.Drawing;

namespace Gomoku
{
    public partial class Form1 : Form
    {
        private PieceType nextPieceType = PieceType.Black;
        private Board board = new Board();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreatePiece(int x, int y)
        {
            Piece newPiece = board.PlaceAPiece(x, y, nextPieceType);
            if (newPiece == null)
                return;
            this.Controls.Add(newPiece);
            nextPieceType = 1 - nextPieceType;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            CreatePiece(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (board.CanBePlaced(e.X, e.Y))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
        }
    }
}
