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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VETproject
{
    public partial class Admin_BreedsForm : Form
    {
        public Admin_BreedsForm()
        {
            InitializeComponent();
        }
        BreedController contr = new BreedController();
        VetContext context = new VetContext();
        private void Admin_BreedsForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<Breed> breeds = await contr.GetAllAsync();
            dataGridView1.DataSource = breeds.Select(x=>new {x.Id, x.Name, x.Animal.Type}).ToList();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (context.Animals.Find(int.Parse(textBox2.Text)) == null) { MessageBox.Show("invalid animal id"); return; }
            Breed a = new Breed
            {
                Name = textBox1.Text,
                AnimalId = int.Parse(textBox2.Text)
            };
            await contr.CreateAsync(a);

            MessageBox.Show("breed added");
            textBox1.Clear();
            textBox2.Clear();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (context.Animals.Find(int.Parse(textBox3.Text)) == null) { MessageBox.Show("invalid animal id"); return; }
            Breed a = new Breed
            {
                Id = int.Parse(textBox7.Text),
                Name = textBox4.Text,
                AnimalId = int.Parse(textBox3.Text)
            };
            if (context.Breeds.Find(a.Id) == null) { MessageBox.Show("invalid id"); return; }
            await contr.UpdateAsync(a);

            MessageBox.Show("breed updated");
            textBox7.Clear();
            textBox4.Clear();
            textBox3.Clear();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (context.Breeds.Find(int.Parse(textBox8.Text)) == null) { MessageBox.Show("invalid id"); return; }
            await contr.DeleteAsync(int.Parse(textBox8.Text));

            MessageBox.Show("breed deleted");
            textBox8.Clear();
        }
    }
}
