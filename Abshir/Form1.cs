using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Abshir
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// Login button
        {
            if (textusername.Text == Properties.Settings.Default.username && textuserpassword.Text == Properties.Settings.Default.password)
            {
                this.Visible = false; // Hide the form if both username and password match
            }
            else if (textusername.Text != Properties.Settings.Default.username && textuserpassword.Text == Properties.Settings.Default.password)
            {
                textusername.Clear();
                textuserpassword.Clear();
                MessageBox.Show("Error: Invalid Username");
            }
            else if (textusername.Text == Properties.Settings.Default.username && textuserpassword.Text != Properties.Settings.Default.password)
            {
                textuserpassword.Clear();
                MessageBox.Show("Error: Invalid Password");
            }
            else
            {
                textusername.Clear();
                textuserpassword.Clear();
                MessageBox.Show("Error: Invalid Username and Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)// exit butt
        {
            DialogResult exityesno = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);

            if (exityesno == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application
            }

        }
    }
}
