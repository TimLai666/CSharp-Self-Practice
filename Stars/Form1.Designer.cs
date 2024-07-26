namespace Stars
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
            label1 = new Label();
            button1 = new Button();
            rowChooser = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)rowChooser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 66);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 0;
            label1.Text = "列數";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 181);
            button1.Name = "button1";
            button1.Size = new Size(297, 156);
            button1.TabIndex = 1;
            button1.Text = "按我";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rowChooser
            // 
            rowChooser.Location = new Point(78, 108);
            rowChooser.Name = "rowChooser";
            rowChooser.Size = new Size(150, 27);
            rowChooser.TabIndex = 2;
            rowChooser.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 364);
            Controls.Add(rowChooser);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)rowChooser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private NumericUpDown rowChooser;
    }
}
