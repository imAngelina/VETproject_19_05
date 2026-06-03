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
    public partial class Admin_ServicesForm : Form
    {
        public Admin_ServicesForm()
        {
            InitializeComponent();
        }
        ServiceController contr = new ServiceController();
        private void Admin_ServicesForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<Service> s = await contr.GetAllAsync();
            dataGridView1.DataSource = s.Select(x => new { x.Id, x.Name, x.Price }).ToList();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Service a = new Service
            {
                Name = textBox1.Text,
                Price = decimal.Parse(textBox2.Text)
            };
            await contr.CreateAsync(a);

            MessageBox.Show("service added");
            textBox1.Clear();
            textBox2.Clear();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Service a = new Service
            {
                Id = int.Parse(textBox7.Text),
                Name = textBox4.Text,
                Price = decimal.Parse(textBox3.Text)
            };
            if (await contr.GetById(a.Id) == null) { MessageBox.Show("invalid id"); return; }
            await contr.UpdateAsync(a);

            MessageBox.Show("service updated");
            textBox7.Clear();
            textBox4.Clear();
            textBox3.Clear();
        }

        private async void button4_Click(object sender, EventArgs e)
        {

            if (await contr.GetById(int.Parse(textBox8.Text)) == null) { MessageBox.Show("invalid id"); return; }
            await contr.DeleteAsync(int.Parse(textBox8.Text));

            MessageBox.Show("service deleted");
            textBox8.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
