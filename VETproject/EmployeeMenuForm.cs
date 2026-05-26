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
    public partial class EmployeeMenuForm : Form
    {
        public EmployeeMenuForm(Userr cu)
        {
            InitializeComponent();
            CurrentU = cu;
        }
        public Userr CurrentU { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Employee_TypeAdd form = new Employee_TypeAdd(CurrentU);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_SeeAppointments from = new Employee_SeeAppointments(CurrentU);
            from.ShowDialog();
        }
    }
}
