using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abshir
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void add_UControls( UserControl userControl ) 
        {

            userControl.Dock = DockStyle.Fill;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add( userControl );
            userControl.BringToFront();

        }
        private void Btn_click( object sender, EventArgs e)
        {
            foreach(var pnl in mainpanel.Controls.OfType<Panel>())
            {
                pnl.BackColor = SystemColors.Window;
            }
            Button btn = (Button)sender;
            switch( btn.Name )
            {
                case "DonorsButt":
                    add_UControls(new UC_Donores());
                    break;
                case "CasesButt":
                    add_UControls(new UC_Cases());
                    break;
                case "Monthlybutt":
                    add_UControls(new UC__MonthlyAssistances());
                    break;
                    default: break;

            }
        }
        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DonorsButt.Click += Btn_click;
            CasesButt.Click += Btn_click;
            Monthlybutt.Click += Btn_click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult exityesno = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);

            if (exityesno == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DonorsButt_Click(object sender, EventArgs e)
        {

        }
    }
}
