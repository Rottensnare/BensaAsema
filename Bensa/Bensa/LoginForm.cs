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
        static bool oikein = false;
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
            oikein = Kryptaus.Tarkistus(tiiviste, userTunnus);

            if (oikein)
            {
                Form tmp = this.FindForm();
                tmp.Close();
                tmp.Dispose();
                AdminForm ad = new AdminForm();
                ad.ShowDialog();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!oikein)
            {
                Form tmp = this.FindForm();
                tmp.Hide();

                Form1 f = new Form1();
                f.ShowDialog();
            }
            
        }
    }
}
