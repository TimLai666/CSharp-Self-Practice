namespace prjFunSample01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void PrintAdd(int x, int y)
        {
            int sum = x + y;
            label1.Text = $"{x}+{y}={sum}";
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        string GetLot(int count)
        {
            string str = "";
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                str += $"²Ä{i+1}²Õ¸¹½X¡G";
                for (int j = 1; j <= 4; j++)
                {
                    str += $"{rnd.NextInt64(0, 10)}\t";
                }
                str += "\n";
            }
            return str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintAdd(10, 30);
            label2.Text = $"7+8={Add(7, 8)}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            richTextBox1.Text = GetLot(n);
        }
    }
}
