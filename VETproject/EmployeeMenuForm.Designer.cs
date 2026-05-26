namespace VETproject
{
    partial class EmployeeMenuForm
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 244, 252);
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(12, 376);
            button1.Name = "button1";
            button1.Size = new Size(226, 65);
            button1.TabIndex = 0;
            button1.Text = "Edit my type";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(235, 244, 252);
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(498, 376);
            button2.Name = "button2";
            button2.Size = new Size(223, 65);
            button2.TabIndex = 1;
            button2.Text = "See  my appointments";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EmployeeMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 244, 252);
            BackgroundImage = Properties.Resources.Beagle_dog_with_stethoscope_as_veterinarian___Premium_Photo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(733, 453);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EmployeeMenuForm";
            Text = "EmployeeMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}