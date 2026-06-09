namespace VETproject
{
    partial class Client_PetsForm
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            textBox7 = new TextBox();
            label7 = new Label();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tabPage4 = new TabPage();
            button4 = new Button();
            textBox8 = new TextBox();
            label8 = new Label();
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
            tabControl1.Location = new Point(21, 21);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(751, 385);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(252, 227, 249);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(743, 352);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ListAll";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 203, 237);
            button1.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(297, 43);
            button1.Name = "button1";
            button1.Size = new Size(110, 45);
            button1.TabIndex = 1;
            button1.Text = "List all";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(701, 241);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(252, 227, 249);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(743, 352);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(242, 203, 237);
            button2.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(271, 270);
            button2.Name = "button2";
            button2.Size = new Size(152, 42);
            button2.TabIndex = 6;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Snow;
            textBox3.Location = new Point(356, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Snow;
            textBox2.Location = new Point(356, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.Location = new Point(356, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label3.Location = new Point(136, 186);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 2;
            label3.Text = "Breed name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label2.Location = new Point(136, 137);
            label2.Name = "label2";
            label2.Size = new Size(41, 23);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label1.Location = new Point(136, 85);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(252, 227, 249);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(743, 352);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Snow;
            textBox7.Location = new Point(342, 59);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(176, 27);
            textBox7.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label7.Location = new Point(168, 63);
            label7.Name = "label7";
            label7.Size = new Size(26, 23);
            label7.TabIndex = 14;
            label7.Text = "Id";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(242, 203, 237);
            button3.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(287, 267);
            button3.Name = "button3";
            button3.Size = new Size(120, 47);
            button3.TabIndex = 13;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Snow;
            textBox4.Location = new Point(342, 207);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 27);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Snow;
            textBox5.Location = new Point(342, 157);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Snow;
            textBox6.Location = new Point(342, 108);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(176, 27);
            textBox6.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label4.Location = new Point(168, 211);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 9;
            label4.Text = "Breed id";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label5.Location = new Point(168, 161);
            label5.Name = "label5";
            label5.Size = new Size(41, 23);
            label5.TabIndex = 8;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label6.Location = new Point(168, 112);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 7;
            label6.Text = "Name";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(252, 227, 249);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(textBox8);
            tabPage4.Controls.Add(label8);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(743, 352);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Delete";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(242, 203, 237);
            button4.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(308, 207);
            button4.Name = "button4";
            button4.Size = new Size(135, 45);
            button4.TabIndex = 18;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Snow;
            textBox8.Location = new Point(346, 120);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(153, 27);
            textBox8.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Italic);
            label8.Location = new Point(237, 124);
            label8.Name = "label8";
            label8.Size = new Size(26, 23);
            label8.TabIndex = 16;
            label8.Text = "Id";
            // 
            // Client_PetsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 203, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Client_PetsForm";
            Text = "Client_PetsForm";
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
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox7;
        private Label label7;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4;
        private TextBox textBox8;
        private Label label8;
    }
}