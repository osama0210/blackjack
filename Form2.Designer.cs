namespace blackjack
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxDealer = new ListBox();
            listBoxPlayer1 = new ListBox();
            dealBtn = new Button();
            listBoxPlayer2 = new ListBox();
            listBoxPlayer3 = new ListBox();
            listBoxPlayer4 = new ListBox();
            SuspendLayout();
            // 
            // listBoxDealer
            // 
            listBoxDealer.FormattingEnabled = true;
            listBoxDealer.Location = new Point(546, 419);
            listBoxDealer.Name = "listBoxDealer";
            listBoxDealer.Size = new Size(322, 164);
            listBoxDealer.TabIndex = 0;
            listBoxDealer.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBoxPlayer1
            // 
            listBoxPlayer1.FormattingEnabled = true;
            listBoxPlayer1.Location = new Point(72, 108);
            listBoxPlayer1.Name = "listBoxPlayer1";
            listBoxPlayer1.Size = new Size(262, 164);
            listBoxPlayer1.TabIndex = 1;
            listBoxPlayer1.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // dealBtn
            // 
            dealBtn.Location = new Point(1089, 753);
            dealBtn.Name = "dealBtn";
            dealBtn.Size = new Size(227, 84);
            dealBtn.TabIndex = 2;
            dealBtn.Text = "Deal Cards";
            dealBtn.UseVisualStyleBackColor = true;
            dealBtn.Click += button1_Click;
            // 
            // listBoxPlayer2
            // 
            listBoxPlayer2.FormattingEnabled = true;
            listBoxPlayer2.Location = new Point(416, 108);
            listBoxPlayer2.Name = "listBoxPlayer2";
            listBoxPlayer2.Size = new Size(262, 164);
            listBoxPlayer2.TabIndex = 3;
            // 
            // listBoxPlayer3
            // 
            listBoxPlayer3.FormattingEnabled = true;
            listBoxPlayer3.Location = new Point(731, 108);
            listBoxPlayer3.Name = "listBoxPlayer3";
            listBoxPlayer3.Size = new Size(262, 164);
            listBoxPlayer3.TabIndex = 4;
            // 
            // listBoxPlayer4
            // 
            listBoxPlayer4.FormattingEnabled = true;
            listBoxPlayer4.Location = new Point(1031, 108);
            listBoxPlayer4.Name = "listBoxPlayer4";
            listBoxPlayer4.Size = new Size(262, 164);
            listBoxPlayer4.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 875);
            Controls.Add(listBoxPlayer4);
            Controls.Add(listBoxPlayer3);
            Controls.Add(listBoxPlayer2);
            Controls.Add(dealBtn);
            Controls.Add(listBoxPlayer1);
            Controls.Add(listBoxDealer);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxDealer;
        private ListBox listBoxPlayer1;
        private Button dealBtn;
        private ListBox listBoxPlayer2;
        private ListBox listBoxPlayer3;
        private ListBox listBoxPlayer4;
    }
}