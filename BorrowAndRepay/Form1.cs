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

        private void button1_Click(object sender, EventArgs e)
        {
            me = new Person(textBoxMyName.Text, 0);
            friend = new Person(textBoxFriendName.Text, 2000);
            labelMyName.Text = me.name;
            labelMyMoney.Text = me.money.ToString();
            labelFriendName.Text = friend.name;
            labelFriendMoney.Text = friend.money.ToString();
            buttonBorrow.Text = $"∏Ú {friend.name} ≠… 1000 §∏";
            buttonRepay.Text = $"¡Ÿ {friend.name} 1000 §∏";
            buttonBorrow.Enabled = true;
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            if (friend.money - 1000 == 0)
            {
                buttonBorrow.Enabled = false;
            }
            me.Borrow(friend, 1000);
            labelMyMoney.Text = me.money.ToString();
            labelFriendMoney.Text = friend.money.ToString();
            buttonRepay.Enabled = true;
        }

        private void buttonRepay_Click(object sender, EventArgs e)
        {
            me.Repay(friend, 1000);
            labelMyMoney.Text = me.money.ToString();
            labelFriendMoney.Text = friend.money.ToString();
            if (me.money == 0)
            {
                buttonRepay.Enabled = false;
            }
            if (friend.money != 0)
            {
                buttonBorrow.Enabled = true;
            }
        }
    }
}
