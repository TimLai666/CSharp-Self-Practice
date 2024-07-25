namespace Wow
{
    public partial class Form1 : Form
    {
        int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            num++;
            label1.Text = "¤wÂIÀ» " + num + " ¦¸";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
