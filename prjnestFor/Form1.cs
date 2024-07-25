namespace prjnestFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    str += $"{i}*{j}={i*j}\t";
                }
                str += "\n";
            }
            richTextBox1.Text = str;
        }
    }
}
