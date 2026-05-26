namespace VETproject
{
    partial class Admin_AnimalsForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage3 = new TabPage();
            textBox7 = new TextBox();
            label9 = new Label();
            button3 = new Button();
            textBox6 = new TextBox();
            label8 = new Label();
            tabPage4 = new TabPage();
            textBox8 = new TextBox();
            button4 = new Button();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Cambria", 10.2F);
            tabControl1.Location = new Point(29, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(742, 402);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.OldLace;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(734, 369);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ListAll";
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(297, 40);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "List all";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Ivory;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 249);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.OldLace;
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(734, 369);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add";
            // 
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(270, 228);
            button2.Name = "button2";
            button2.Size = new Size(124, 47);
            button2.TabIndex = 8;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Ivory;
            textBox1.Location = new Point(352, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label1.Location = new Point(162, 138);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.OldLace;
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(734, 369);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Ivory;
            textBox7.Location = new Point(352, 114);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(173, 27);
            textBox7.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label9.Location = new Point(203, 114);
            label9.Name = "label9";
            label9.Size = new Size(26, 23);
            label9.TabIndex = 18;
            label9.Text = "Id";
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(285, 281);
            button3.Name = "button3";
            button3.Size = new Size(137, 46);
            button3.TabIndex = 17;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Ivory;
            textBox6.Location = new Point(352, 191);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(173, 27);
            textBox6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label8.Location = new Point(193, 195);
            label8.Name = "label8";
            label8.Size = new Size(50, 23);
            label8.TabIndex = 9;
            label8.Text = "Type";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.OldLace;
            tabPage4.Controls.Add(textBox8);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(label10);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(734, 369);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Delete";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Ivory;
            textBox8.Location = new Point(321, 114);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(147, 27);
            textBox8.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.Ivory;
            button4.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(264, 200);
            button4.Name = "button4";
            button4.Size = new Size(137, 42);
            button4.TabIndex = 1;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label10.Location = new Point(228, 118);
            label10.Name = "label10";
            label10.Size = new Size(26, 23);
            label10.TabIndex = 0;
            label10.Text = "Id";
            // 
            // Admin_AnimalsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Admin_AnimalsForm";
            Text = "Admin_AnimalsForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private TabPage tabPage3;
        private TextBox textBox7;
        private Label label9;
        private Button button3;
        private TextBox textBox6;
        private Label label8;
        private TabPage tabPage4;
        private TextBox textBox8;
        private Button button4;
        private Label label10;
    }
}