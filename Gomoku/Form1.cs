namespace Gomoku
{
    public partial class Form1 : Form
    {
        private bool isBlack = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void createPiece(int x, int y)
        {
            Piece newPiece = isBlack ? new BlackPiece(x, y) : new WhitePiece(x, y);
            this.Controls.Add(newPiece);
            isBlack = !isBlack;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            createPiece(e.X, e.Y);
        }
    }
}
