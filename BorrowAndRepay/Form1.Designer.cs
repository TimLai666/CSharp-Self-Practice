namespace BorrowAndRepay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxMyName = new TextBox();
            textBoxFriendName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            labelMyName = new Label();
            labelMyMoney = new Label();
            labelFriendMoney = new Label();
            labelFriendName = new Label();
            label9 = new Label();
            label10 = new Label();
            buttonBorrow = new Button();
            buttonRepay = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(466, 33);
            button1.Name = "button1";
            button1.Size = new Size(266, 94);
            button1.TabIndex = 0;
            button1.Text = "確認";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(58, 33);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 1;
            label1.Text = "請輸入你的名字";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(58, 97);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 2;
            label2.Text = "請輸入朋友名字";
            // 
            // textBoxMyName
            // 
            textBoxMyName.Location = new Point(216, 33);
            textBoxMyName.Name = "textBoxMyName";
            textBoxMyName.Size = new Size(189, 27);
            textBoxMyName.TabIndex = 3;
            // 
            // textBoxFriendName
            // 
            textBoxFriendName.Location = new Point(216, 95);
            textBoxFriendName.Name = "textBoxFriendName";
            textBoxFriendName.Size = new Size(189, 27);
            textBoxFriendName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(58, 162);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 5;
            label3.Text = "我的名字：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(58, 211);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 6;
            label4.Text = "我的錢：";
            // 
            // labelMyName
            // 
            labelMyName.AutoSize = true;
            labelMyName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelMyName.Location = new Point(176, 162);
            labelMyName.Name = "labelMyName";
            labelMyName.Size = new Size(72, 25);
            labelMyName.TabIndex = 7;
            labelMyName.Text = "無名氏";
            // 
            // labelMyMoney
            // 
            labelMyMoney.AutoSize = true;
            labelMyMoney.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelMyMoney.Location = new Point(176, 211);
            labelMyMoney.Name = "labelMyMoney";
            labelMyMoney.Size = new Size(24, 25);
            labelMyMoney.TabIndex = 8;
            labelMyMoney.Text = "0";
            // 
            // labelFriendMoney
            // 
            labelFriendMoney.AutoSize = true;
            labelFriendMoney.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelFriendMoney.Location = new Point(593, 211);
            labelFriendMoney.Name = "labelFriendMoney";
            labelFriendMoney.Size = new Size(84, 25);
            labelFriendMoney.TabIndex = 12;
            labelFriendMoney.Text = "200000";
            // 
            // labelFriendName
            // 
            labelFriendName.AutoSize = true;
            labelFriendName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelFriendName.Location = new Point(593, 162);
            labelFriendName.Name = "labelFriendName";
            labelFriendName.Size = new Size(72, 25);
            labelFriendName.TabIndex = 11;
            labelFriendName.Text = "無名氏";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.Location = new Point(466, 211);
            label9.Name = "label9";
            label9.Size = new Size(112, 25);
            label9.TabIndex = 10;
            label9.Text = "朋友的錢：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label10.Location = new Point(466, 162);
            label10.Name = "label10";
            label10.Size = new Size(132, 25);
            label10.TabIndex = 9;
            label10.Text = "朋友的名字：";
            // 
            // buttonBorrow
            // 
            buttonBorrow.Enabled = false;
            buttonBorrow.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonBorrow.Location = new Point(58, 274);
            buttonBorrow.Name = "buttonBorrow";
            buttonBorrow.Size = new Size(674, 62);
            buttonBorrow.TabIndex = 13;
            buttonBorrow.Text = "跟 xxx 借 1000 元";
            buttonBorrow.UseVisualStyleBackColor = true;
            buttonBorrow.Click += buttonBorrow_Click;
            // 
            // buttonRepay
            // 
            buttonRepay.Enabled = false;
            buttonRepay.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonRepay.Location = new Point(58, 354);
            buttonRepay.Name = "buttonRepay";
            buttonRepay.Size = new Size(674, 62);
            buttonRepay.TabIndex = 14;
            buttonRepay.Text = "還給 xxx 1000 元";
            buttonRepay.UseVisualStyleBackColor = true;
            buttonRepay.Click += buttonRepay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRepay);
            Controls.Add(buttonBorrow);
            Controls.Add(labelFriendMoney);
            Controls.Add(labelFriendName);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(labelMyMoney);
            Controls.Add(labelMyName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxFriendName);
            Controls.Add(textBoxMyName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "借還錢程式";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBoxMyName;
        private TextBox textBoxFriendName;
        private Label label3;
        private Label label4;
        private Label labelMyName;
        private Label labelMyMoney;
        private Label labelFriendMoney;
        private Label labelFriendName;
        private Label label9;
        private Label label10;
        private Button buttonBorrow;
        private Button buttonRepay;
    }
}
