namespace prjSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] id, names;
        int[] price;


        private void Form1_Load(object sender, EventArgs e)
        {
            id = new string[] { "E01", "E02", "E03", "E04" };
            names = new string[] { "Laptop", "Mouse", "Keyboard", "Monitor" };
            price = new int[] { 500, 10, 20, 100 };
            string str = "";
            for (int i = 0; i < id.Length; i++)
            {
                str += $"{id[i]}\t{names[i]}\t{price[i]}\n";
            }
            richTextBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            int index = -1;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i].ToLower() == search.ToLower())
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                MessageBox.Show($"ID: {id[index]}\nName: {names[index]}\nPrice: {price[index]}");
            }
        }
    }
}
