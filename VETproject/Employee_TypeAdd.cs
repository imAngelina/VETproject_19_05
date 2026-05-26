using DATAproject;
using DATAproject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VETproject
{
    public partial class Employee_TypeAdd : Form
    {
        public Employee_TypeAdd(Userr cu)
        {
            InitializeComponent();
            CurruntUser = cu;
        }
        public Userr CurruntUser { get; set; }
        VetContext context = new VetContext();
        private async void button1_Click(object sender, EventArgs e)
        {
            string typeName = textBox1.Text;
             
            var type = await context.EmployeeTypes.FirstOrDefaultAsync(x => x.Name == typeName);

             
            if (type == null)
            {
                type = new EmployeeType()
                {
                    Name = typeName
                };

                await context.EmployeeTypes.AddAsync(type); 
                await context.SaveChangesAsync();
            }

             
            var employee = await context.Users.FindAsync(CurruntUser.Id);


            employee.EmployeeTypeId = type.Id;

            await context.SaveChangesAsync();


            MessageBox.Show("Type saved!");
            textBox1.Clear();
        }
    }
}
