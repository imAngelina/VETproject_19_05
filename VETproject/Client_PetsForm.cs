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
    public partial class Client_PetsForm : Form
    {
        public Client_PetsForm()
        {
            InitializeComponent();
        }
        public Client_PetsForm(Userr user)
        {
            InitializeComponent();
            UserCurrent = user;
        }
        public Userr UserCurrent { get; set; }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        PetController contr = new PetController();
        VetContext context = new VetContext();
        private async void button1_Click(object sender, EventArgs e)
        {
            List<Pet> s = await contr.GetAllAsync();
            s = s.Where(x => x.OwnerId == UserCurrent.Id).ToList();
            dataGridView1.DataSource = s.Select(x => new { x.Id, x.Name, x.Age, x.Breed.Animal.Type }).ToList();
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            if (context.Breeds.Find(int.Parse(textBox3.Text)) == null) { MessageBox.Show("invalid breed id"); return; }
            Pet a = new Pet
            {
                Name = textBox1.Text,
                Age = int.Parse(textBox2.Text),
                BreedId = int.Parse(textBox3.Text),
                OwnerId = UserCurrent.Id
            };
            await contr.CreateAsync(a);

            MessageBox.Show("pet added");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private async void button3_Click(object sender, EventArgs e)
        {

            if (context.Breeds.Find(int.Parse(textBox4.Text)) == null) { MessageBox.Show("invalid breed id"); return; }
            Pet a = new Pet
            {
                Id = int.Parse(textBox7.Text),
                Name = textBox6.Text,
                Age = int.Parse(textBox5.Text),
                BreedId = int.Parse(textBox4.Text),
                OwnerId = UserCurrent.Id
            };
            if (context.Pets.Find(a.Id) == null) { MessageBox.Show("invalid id"); return; }
            await contr.UpdateAsync(a);

            MessageBox.Show("pet updated");
            textBox7.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox4.Clear();
        }

        private async void button4_Click(object sender, EventArgs e)
        {

            if (context.Pets.Find(int.Parse(textBox8.Text)) == null) { MessageBox.Show("invalid id"); return; }
            await contr.DeleteAsync(int.Parse(textBox8.Text));

            MessageBox.Show("pet deleted");
            textBox8.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
