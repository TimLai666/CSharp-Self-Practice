namespace prjFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            MessageBox.Show("Sum of 1 to 10 is " + sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0.0;
            for (double i = 0.5; i <= 5.0; i+=0.5)
            {
                sum += i;
            }
            MessageBox.Show("Sum of 0.5 to 5.0 is " + sum);
        }
    }
}
