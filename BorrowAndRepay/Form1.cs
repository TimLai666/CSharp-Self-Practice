namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        Person me;
        Person friend;

        void UpdateUI()
        {
            labelMyName.Text = me.name;
            labelMyMoney.Text = me.money.ToString();
            labelFriendName.Text = friend.name;
            labelFriendMoney.Text = friend.money.ToString();
            buttonBorrow.Text = $"∏Ú {friend.name} ≠… 1000 §∏";
            buttonRepay.Text = $"¡Ÿ {friend.name} 1000 §∏";
            if (friend.money == 0)
            {
                buttonBorrow.Enabled = false;
            } else
            {
                buttonBorrow.Enabled = true;
            }

            if (me.money == 0)
            {
                buttonRepay.Enabled = false;
            } else
            {
                buttonRepay.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            me = new Person(textBoxMyName.Text, 0);
            friend = new Person(textBoxFriendName.Text, 2000);
            UpdateUI();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            me.Borrow(friend, 1000);
            UpdateUI();
        }

        private void buttonRepay_Click(object sender, EventArgs e)
        {
            me.Repay(friend, 1000);
            UpdateUI();
        }
    }
}
