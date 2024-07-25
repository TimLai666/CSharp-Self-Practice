namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Text = "�H�����s";
            lblShow.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price, num, total;
            try
            {
                price = Convert.ToInt32(txtPrice.Text);
                num = Convert.ToInt32(txtNum.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (num <= 0 || price <= 0)
            {
                MessageBox.Show("����M�ƶq���j�� 0");
                return;
            }

            total = price * num;
            double discount = 1.0;
            string discountMsg = "������";

            if (total >= 20000)
            {
                discount = 0.75;
                discountMsg = "���C����";
            } else if (total >= 10000)
            {
                discount = 0.8;
                discountMsg = "���K��";
            } else if (total >= 6000)
            {
                discount = 0.85;
                discountMsg = "���K����";
            } else if (total >= 3000)
            {
                discount = 0.9;
                discountMsg = "���E��";
            }

            lblShow.Text = $"""
            �A�ʶR�F {txtName.Text} {num} ��A�@ {total} ��
            {discountMsg}�A�馩��@ {total * discount} ��
            """;
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
        }
    }
}
