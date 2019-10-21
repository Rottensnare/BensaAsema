using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bensa
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
            userControl21.BringToFront();
            userControl31.Hide();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl21.BringToFront();
            
        }

        private void UserControl31_Load(object sender, EventArgs e)
        {

        }
    }
}
