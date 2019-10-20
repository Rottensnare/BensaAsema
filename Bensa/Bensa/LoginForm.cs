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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Kryptaus kr = new Kryptaus();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userTunnus = textBox1.Text;
            string userSalasana = textBox2.Text;
            string tiiviste = Kryptaus.Salaus(userSalasana);
            bool oikein = Kryptaus.Tarkistus(tiiviste, userTunnus);
            if (oikein)
            {
                Close();
                AdminForm ad = new AdminForm();
                ad.ShowDialog();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }
    }
}
