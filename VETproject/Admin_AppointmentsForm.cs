using CONTROLLERproject;
using DATAproject.Entities;
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
    public partial class Admin_AppointmentsForm : Form
    {
        public Admin_AppointmentsForm()
        {
            InitializeComponent();
        }
        AppointmentController contr = new AppointmentController();
        private async void button1_Click(object sender, EventArgs e)
        {
            List<Appointment> s = await contr.GetAllAsync();
            dataGridView1.DataSource = s.Select(x => new { x.Id, x.DateTime, x.Reason, x.Pet.Name, x.Pet.Owner.FullName }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
