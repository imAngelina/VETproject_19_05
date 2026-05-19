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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_UsersForm auf = new Admin_UsersForm();
            auf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_AnimalsForm f = new Admin_AnimalsForm();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_BreedsForm f = new Admin_BreedsForm();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_ServicesForm f = new Admin_ServicesForm();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_AppointmentsForm f = new Admin_AppointmentsForm();
            f.ShowDialog();
        }
    }
}
