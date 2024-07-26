namespace prjGetMax01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int GetMax(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        int GetMax(int[] ary)
        {
            int max = ary[0];
            foreach (int i in ary)
            {
                max = i > max ? i : max;
            }
            return max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 7, y = 4;
            richTextBox1.Text = $"{x} 和 {y} 中最大的是 {GetMax(x, y)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] ary = { 7, 4 };
            richTextBox1.Text = $"陣列中最大的是 {GetMax(ary)}";
        }
    }
}
