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
            txtName.Text = "人中之龍";
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
                MessageBox.Show("單價和數量須大於 0");
                return;
            }

            total = price * num;
            double discount = 1.0;
            string discountMsg = "不打折";

            if (total >= 20000)
            {
                discount = 0.75;
                discountMsg = "打七五折";
            } else if (total >= 10000)
            {
                discount = 0.8;
                discountMsg = "打八折";
            } else if (total >= 6000)
            {
                discount = 0.85;
                discountMsg = "打八五折";
            } else if (total >= 3000)
            {
                discount = 0.9;
                discountMsg = "打九折";
            }

            lblShow.Text = $"""
            你購買了 {txtName.Text} {num} 件，共 {total} 元
            {discountMsg}，折扣後共 {total * discount} 元
            """;
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
        }
    }
}
