namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowNum = (int)rowChooser.Value;
            string str = "";
            for (int i = 1; i <= rowNum; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    str += "*";
                }
                str += "\n";
            }
            MessageBox.Show(str);
        }
    }
}
