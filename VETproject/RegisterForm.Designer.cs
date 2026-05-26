namespace VETproject
{
    partial class RegisterForm
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FloralWhite;
            button1.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            button1.Location = new Point(232, 294);
            button1.Name = "button1";
            button1.Size = new Size(124, 40);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FloralWhite;
            button2.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            button2.Location = new Point(420, 294);
            button2.Name = "button2";
            button2.Size = new Size(128, 40);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label1.Location = new Point(166, 37);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FloralWhite;
            label2.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label2.Location = new Point(166, 92);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FloralWhite;
            label3.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label3.Location = new Point(166, 148);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 4;
            label3.Text = "Password again";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FloralWhite;
            label4.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label4.Location = new Point(166, 201);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 5;
            label4.Text = "Full name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FloralWhite;
            label5.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label5.Location = new Point(166, 253);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 6;
            label5.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(364, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 28);
            comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(364, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(364, 92);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(240, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(364, 144);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(240, 27);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(364, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(240, 27);
            textBox4.TabIndex = 11;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.paws;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}