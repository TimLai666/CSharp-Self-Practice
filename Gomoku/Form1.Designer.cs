﻿namespace Gomoku
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
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.board;
            ClientSize = new Size(765, 736);
            MaximumSize = new Size(783, 783);
            Name = "Form1";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "五子棋";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
        }

        #endregion
    }
}
