using CONTROLLERproject;
using DATAproject;
using DATAproject.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATAproject.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace VETproject
{
    public partial class Admin_UsersForm : Form
    {
        public Admin_UsersForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(UserRole));
            comboBox2.DataSource = Enum.GetValues(typeof(UserRole));
        }
        UserController userController = new UserController();
        VetContext context = new VetContext();
        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await userController.GetAllAsync();
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            var user = new Userr
            {

                Username = textBox1.Text,
                Password = textBox2.Text,
                FullName = textBox3.Text,
                Role = (UserRole)comboBox1.SelectedItem
            };
            if (context.Users.Any(x => x.Username == user.Username))
            {
                MessageBox.Show("username exists");
                return;
            }

            await userController.CreateAsync(user);

            MessageBox.Show("User registered");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Admin_UsersForm_Load(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {

            var user = new Userr
            {
                Id = int.Parse(textBox7.Text),
                Username = textBox6.Text,
                Password = textBox5.Text,
                FullName = textBox4.Text,
                Role = (UserRole)comboBox2.SelectedItem
            };
            if (context.Users.Find(user.Id) == null) { MessageBox.Show("invalid id"); return; }
            await userController.UpdateAsync(user);

            MessageBox.Show("User updated");
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (context.Users.Find(int.Parse(textBox8.Text)) == null) { MessageBox.Show("invalid id"); return; }
            await userController.DeleteAsync(int.Parse(textBox8.Text));

            MessageBox.Show("User deleted");
            textBox8.Clear();
        }
    }
}
