using CONTROLLERproject;
using DATAproject;
using DATAproject.Entities;
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

namespace VETproject
{
    public partial class Admin_AnimalsForm : Form
    {
        public Admin_AnimalsForm()
        {
            InitializeComponent();
        }
        AnimalController contr = new AnimalController();
        private async void button1_Click(object sender, EventArgs e)
        {
            List<Animal> animals = await contr.GetAllAsync();
            dataGridView1.DataSource = animals.Select(x=>new{x.Id,x.Type}).ToList();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Animal a = new Animal
            {
                Type = textBox1.Text
            };
            await contr.CreateAsync(a);

            MessageBox.Show("animal added");
            textBox1.Clear();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Animal a = new Animal
            {
                Id = int.Parse(textBox7.Text),
                Type = textBox6.Text
            };
            if (contr.GetById(a.Id) == null) { MessageBox.Show("invalid id"); return; }
            await contr.UpdateAsync(a);

            MessageBox.Show("animal updated");
            textBox7.Clear();
            textBox6.Clear();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (contr.GetById(int.Parse(textBox8.Text)) == null) { MessageBox.Show("invalid id"); return; }
            await contr.DeleteAsync(int.Parse(textBox8.Text));

            MessageBox.Show("animal deleted");
            textBox8.Clear();
        }
    }
}
