using CONTROLLERproject;
using DATAproject;
using DATAproject.Entities;
using DATAproject.Enums;

namespace VETproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VetContext context = new VetContext();
        UserController controller = new UserController();
        public Userr CurrentUser { get; set; }
        public Userr FindCurrentUser()
        {
           CurrentUser = context.Users.FirstOrDefault(x => x.Username == textBox1.Text && x.Password == textBox2.Text);
            return CurrentUser;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            var user = await controller.LoginAsync(
           textBox1.Text,
           textBox2.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid username or pass");

                return;
            }

            Hide();

            if (user.Role == UserRole.Admin)
            {
                AdminMenuForm form =
                    new AdminMenuForm();

                form.ShowDialog();
            }
            else if (user.Role == UserRole.Employee)
            {
                EmployeeMenuForm form =
                    new EmployeeMenuForm(FindCurrentUser());

                form.ShowDialog();
            }
            else
            {

                ClientMenuForm form =
                    new ClientMenuForm(FindCurrentUser());

                form.ShowDialog();
            }

            Show();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();

            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
