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
                WrongLogin();
                
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
        private async void WrongLogin() 
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            loginButton.Enabled = false;
            textBox1.Text = "Invalid Login";
            await Task.Delay(4000);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            loginButton.Enabled = true;
        }
    }
}
