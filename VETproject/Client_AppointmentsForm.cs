using CONTROLLERproject;
using DATAproject;
using DATAproject.Entities;
using DATAproject.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VETproject
{
    public partial class Client_AppointmentsForm : Form
    {
        public Client_AppointmentsForm(Userr cu)
        {
            InitializeComponent();
            CurrentUser = cu;
        }
        public Userr CurrentUser { get; set; }
        AppointmentController contr = new AppointmentController();
        VetContext context = new VetContext();
        private async void button1_Click(object sender, EventArgs e)
        {
            int ownerId = CurrentUser.Id;

            var appointments = await contr.GetClientAppointmentsAsync(ownerId);

            dataGridView1.DataSource = appointments.Select(x => new { x.Id, Date = x.DateTime, Pet = x.Pet.Name, Employee = x.Employee.Username, Service = x.Service.Name, x.Reason }).ToList();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;


            TimeSpan parsedTime = TimeSpan.Parse(textBox4.Text);


            DateTime fullDate = selectedDate + parsedTime;

            if (fullDate < DateTime.Now)
            {
                MessageBox.Show(
                    "Cannot book in the past!");

                return;
            }


            var pet = await context.Pets
                .FirstOrDefaultAsync(x =>
                    x.Id == int.Parse(textBox1.Text) &&
                    x.OwnerId == CurrentUser.Id);

            if (pet == null)
            {
                MessageBox.Show(
                    "Pet does not exist!");

                return;
            }


            var employee = await context.Users
                .FirstOrDefaultAsync(x =>
                    x.Id == int.Parse(textBox2.Text)
                    && x.Role == UserRole.Employee);

            if (employee == null)
            {
                MessageBox.Show(
                    "Employee does not exist!");

                return;
            }


            var service = await context.Services
                .FirstOrDefaultAsync(x =>
                    x.Id == int.Parse(textBox3.Text));

            if (service == null)
            {
                MessageBox.Show(
                    "Service does not exist!");

                return;
            }



            Appointment appointment =
                new Appointment()
                {
                    DateTime = fullDate,

                    Reason = textBox5.Text,

                    PetId = pet.Id,

                    EmployeeId = employee.Id,

                    ServiceId = service.Id
                };



            bool success = await contr.CreateAppointmentAsync(appointment);



            if (!success)
            {
                MessageBox.Show(
                    "This hour is already taken!");

                return;
            }


            MessageBox.Show(
                "Appointment added successfully!");




            textBox1.Clear();

            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

            textBox5.Clear();



        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (context.Appointments.Find(int.Parse(textBox6.Text)) == null) { MessageBox.Show("invalid id"); return; }
            await contr.DeleteAsync(int.Parse(textBox6.Text));

            MessageBox.Show("appointment deleted");
            textBox6.Clear();
        }
    }
}
