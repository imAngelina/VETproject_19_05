using CONTROLLERproject;
using DATAproject;
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
    public partial class Employee_SeeAppointments : Form
    {
        public Employee_SeeAppointments(Userr cu)
        {
            InitializeComponent();
            CurrentUser = cu;
        }
        public Userr CurrentUser { get; set; }
        VetContext context = new VetContext();
        AppointmentController controller = new AppointmentController();
        private async void button1_Click(object sender, EventArgs e)
        {
           
            List<Appointment> s = await controller.GetAllAsync();
            s = s.Where(x => x.EmployeeId == CurrentUser.Id).ToList();
            dataGridView1.DataSource = s.Select(x => new {
                x.Id,
                x.DateTime,
                Pet = x.Pet.Name, 
                Service = x.Service.Name, 
                x.Reason
            }).ToList();
        }
    }
}
