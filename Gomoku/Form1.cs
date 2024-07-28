namespace Gomoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Piece blackPiece = new BlackPiece(100, 100);
            Piece whitePiece = new WhitePiece(200, 200);
            this.Controls.Add(blackPiece);
            this.Controls.Add(whitePiece);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
