using CONTROLLERproject;
using DATAproject;
using DATAproject.Entities;
using DATAproject.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VETproject
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(UserRole));
        }
        UserController userController = new UserController();
        VetContext context = new VetContext();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("enter all the info!");
                return;
            }
            var user = new Userr
            {
                Username = textBox1.Text,
                Password = textBox2.Text,
                FullName = textBox4.Text,
                Role = (UserRole)comboBox1.SelectedItem
            };
            if (context.Users.Any(x => x.Username == user.Username))
            {
                MessageBox.Show("username exists");
                return;
            }

            await userController.CreateAsync(user);

            MessageBox.Show("User registered");

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
