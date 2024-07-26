namespace prjAry2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] stu = { "A001", "A002", "A003", "A004" };
            string[] sub = { "Math", "Science", "History" };
            int[,] scores = {
                { 90, 80, 70 },
                { 85, 75, 65 },
                { 95, 85, 75 },
                { 80, 70, 60 }
            };
            int[] sum = { 0, 0, 0, 0 };

            string msg = "學號\t";
            foreach (string s in sub)
            {
                msg += s + "\t";
            }
            msg += "總分";

            for (int i=0; i <= stu.GetUpperBound(0); i++ )
            {
                msg += "\n" + stu[i] + "\t";
                for (int j=0; j <= sub.GetUpperBound(0); j++)
                {
                    msg += scores[i, j] + "\t";
                    sum[i] += scores[i, j];
                }
                msg += sum[i];
            }

            richTextBox1.Text = msg;
                
        }
    }
}
