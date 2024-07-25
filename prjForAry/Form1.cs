namespace prjForAry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] score = { 45, 67, 98, 65 };
            string str = "";
            for (int i = 0; i < score.Length; i++)
            {
                str += $"{score[i]}\n";
            }
            richTextBox1.Text = str;


            str = "";
            foreach (int i in score)
            {
                str += $"{i}\n";
            }
            richTextBox2.Text = str;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
