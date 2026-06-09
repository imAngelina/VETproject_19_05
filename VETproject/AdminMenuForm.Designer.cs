namespace VETproject
{
    partial class AdminMenuForm
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.AntiqueWhite;
            button6.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(579, 350);
            button6.Name = "button6";
            button6.Size = new Size(126, 43);
            button6.TabIndex = 11;
            button6.Text = "Log out";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AntiqueWhite;
            button5.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(76, 350);
            button5.Name = "button5";
            button5.Size = new Size(133, 43);
            button5.TabIndex = 10;
            button5.Text = "Appointments";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.AntiqueWhite;
            button4.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(624, 204);
            button4.Name = "button4";
            button4.Size = new Size(109, 47);
            button4.TabIndex = 9;
            button4.Text = "Services";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.AntiqueWhite;
            button3.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(32, 204);
            button3.Name = "button3";
            button3.Size = new Size(108, 47);
            button3.TabIndex = 8;
            button3.Text = "Breeds";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AntiqueWhite;
            button2.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(579, 56);
            button2.Name = "button2";
            button2.Size = new Size(109, 46);
            button2.TabIndex = 7;
            button2.Text = "Animals";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(76, 56);
            button1.Name = "button1";
            button1.Size = new Size(108, 46);
            button1.TabIndex = 6;
            button1.Text = "Users";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Life;
            ClientSize = new Size(820, 448);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdminMenuForm";
            Text = "AdminMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}