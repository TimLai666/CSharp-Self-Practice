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
            int i = 1;
            while (i <= 10)
            {
                sum += i;
                i++;
            }
            MessageBox.Show("Sum of 1 to 10 is " + sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0.0;
            double i = 0.5;
            do
            {
                sum += i;
                i += 0.5;
            } while (i <= 5.0);
            MessageBox.Show("Sum of 0.5 to 5.0 is " + sum);
        }
    }
}
