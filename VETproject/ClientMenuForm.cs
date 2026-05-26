using DATAproject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VETproject
{
    public partial class ClientMenuForm : Form
    {
        public ClientMenuForm()
        {
            InitializeComponent();
        }
        public ClientMenuForm(Userr user)
        {
            InitializeComponent();
            CurrentUser = user;
        }
        public Userr CurrentUser { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Client_PetsForm f = new Client_PetsForm(CurrentUser);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client_AppointmentsForm f = new Client_AppointmentsForm(CurrentUser);
            f.ShowDialog();
        }

        private void ClientMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
