namespace prjAry01
{
    public partial class Form1 : Form
    {
        string[] aryId, aryName;
        int[] aryPrice;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            textBox1.Text = aryId[index];
            textBox2.Text = aryName[index];
            textBox3.Text = aryPrice[index].ToString();
            label4.Text = $"{index + 1}/{aryId.Length}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aryId = new string[] { "P01", "P02", "P03", "P04", "P05" };
            aryName = new string[] { "人中之龍", "火影忍者", "多啦A夢", "影子籃球員", "七龍珠" };
            aryPrice = new int[] { 1780, 1600, 670, 900, 1680 };
            ShowInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= aryId.Length)
            {
                index = 0;
            }
            ShowInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0) {
                index = aryId.Length - 1;
            }
            ShowInfo();
        }
    }
}
