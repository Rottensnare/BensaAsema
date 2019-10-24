using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bensa
{
    public partial class Form1 : Form
    {
        static bool kortti = false;
        static bool tyhjennys = true;
        static bool valinta = false;
        static bool määrä = false;
        static bool tankkaus = false;
        static bool kuitti = false;
        static bool eriTiedostot = true;
        static bool sound = false;
        static double litrat = 0;
        string hinta = "";
        static string bensa = "";
        static string filepath = "C:/Temp/Bensis.txt";
        static readonly string filepath101 = "C:/Temp/hinta95.txt";
        static readonly string filepath102 = "C:/Temp/hinta98.txt";
        static readonly string filepath103 = "C:/Temp/hintad.txt";
        static readonly string filepathSound = "C:/temp/SoundClips";
       
        

        LoginForm login = new LoginForm();

        public Form1()
        {
            
            InitializeComponent();
            InitializeValues();
            Blink1();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button13.Enabled = false;
            
        }

        private async void Blink1() //Vilkuta label4 PunaMusta Valittaessa
        {
            while (!kortti)
            {
                await Task.Delay(500);
                label4.ForeColor = label4.ForeColor == Color.Black ? Color.Red : Color.Black;
            }
            label4.ForeColor = Color.Black;
        }
        private async void Blink2() //Vilkuta Bensan nimiä PunaMusta Valittaessa
        {
            while (valinta)
            {
                await Task.Delay(500);
                label1.ForeColor = label1.ForeColor == Color.Black ? Color.Red : Color.Black;
                label2.ForeColor = label2.ForeColor == Color.Black ? Color.Red : Color.Black;
                label3.ForeColor = label3.ForeColor == Color.Black ? Color.Red : Color.Black;
            }
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
        }

        private void Label4_Click(object sender, EventArgs e) //Syötä Kortti Label
        {
            
            
            if (!kortti && !valinta && !määrä)
            {
                tyhjennys = true;
                textBox4.Text = "Syötä tunnusluku";
                button11.Enabled = true;
                if (sound)
                {
                    if (Directory.Exists("C:/temp/SoundClips"))
                    {
                        System.Media.SoundPlayer Beep = new System.Media.SoundPlayer("C:/temp/SoundClips/Beep.wav");
                        Beep.Play();
                    }
                }
            }
            kortti = true;
            
           
        }

        private void Button10_MouseClick(object sender, MouseEventArgs e) //Numerot
        {
            
            TextBoxClear();
            if (kortti)
            {
                Button numero = (Button)sender;
                textBox4.Text += numero.Text;
                if (sound)
                {
                    if (Directory.Exists("C:/temp/SoundClips"))
                    {
                        System.Media.SoundPlayer Beep = new System.Media.SoundPlayer("C:/temp/SoundClips/Beep.wav");
                        Beep.Play();
                    }
                }
            }
        }

        private void TextBoxClear() //Tyhjennä TextBox4
        {
            if (tyhjennys)
            {
                textBox4.Text = "";
                tyhjennys = false;
            }
        }

        private void Button11_Click(object sender, EventArgs e) //OK Näppäin
        {
            string pin = textBox4.Text;
            if (sound)
            {
                if (Directory.Exists("C:/temp/SoundClips"))
                {
                    System.Media.SoundPlayer Beep = new System.Media.SoundPlayer("C:/temp/SoundClips/Beep.wav");
                    Beep.Play();
                }
            }

            try
                {
                    litrat = double.Parse(textBox4.Text);
                }
                catch
                {

                    textBox4.Text = "";
                }
                if (pin.Length > 3 && pin.Length < 9 && !määrä)
                {
                    tyhjennys = true;
                    valinta = true;
                    TextBoxClear();
                    textBox4.Text = "Valitse bensan laatu";
                    kortti = false;
                    button11.Enabled = false;
                    Blink2();

                }
                else if (!määrä && kortti)
                {
                    textBox4.Text = "Väärä tunnusluku";
                    tyhjennys = true;
                }
                else if (määrä && litrat > 4 && litrat < 121)
                {
                    textBox4.Text = "Aloita tankkaus";
                    textBox6.Text = $"{litrat.ToString()} Litraa";
                    textBox5.Text = $"{Laskut.Hinta(litrat, bensa, eriTiedostot)} €";
                    hinta = textBox5.Text;
                    kortti = false;
                    tankkaus = true;

                    button11.Enabled = false;

                }
            
            
        }

        private void Label3_Click(object sender, EventArgs e) //Valittaessa Bensan Laatu
        {
            if (!kortti && valinta)
            {
                if (sound)
                {
                    if (Directory.Exists("C:/temp/SoundClips"))
                    {
                        System.Media.SoundPlayer Beep = new System.Media.SoundPlayer("C:/temp/SoundClips/Beep.wav");
                        Beep.Play();
                    }
                }
                valinta = false;
                tyhjennys = true;
                TextBoxClear();
                Label bensanLaatu = (Label)sender;
                bensa = bensanLaatu.Text;
                textBox4.Text = "Valitse bensan määrä";
                button11.Enabled = true;
                kortti = true;
                määrä = true;
                tyhjennys = true;
            }
            
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonTankkaus_Click(object sender, EventArgs e) //TankkausNappi
        {
            if (tankkaus)
            {
                if (sound)
                {
                    if (Directory.Exists("C:/temp/SoundClips"))
                    {
                        System.Media.SoundPlayer Beep = new System.Media.SoundPlayer("C:/temp/SoundClips/Beep.wav");
                        Beep.Play();
                    }
                }
                tyhjennys = true;
                TextBoxClear();
                Progress(litrat);
                Laskut.Talletus(bensa, litrat, hinta);
                Laskut.MääräLasku(litrat, bensa);
            }
           
            
        }
        public void InitializeValues() //Tekstitiedostosta hinnat formiin
        {
            if (!Laskut.Check95())
            {
                label1.Enabled = false;
            }
            else
            {
                label1.Enabled = true;
            }
            if (!Laskut.Check98())
            {
                label2.Enabled = false;
            }
            else
            {
                label2.Enabled = true;
            }
            if (!Laskut.CheckD())
            {
                label3.Enabled = false;
            }
            else
            {
                label3.Enabled = true;
            }


            if (!eriTiedostot)
            {
                var e95 = File.ReadLines(filepath).ElementAt(0);
                e95 = e95.Remove(0, e95.IndexOf(' ', +1));
                e95 = Math.Round((double)Convert.ToDouble(e95), 3).ToString();
                textBox1.Text = $"{e95} €";

                var e98 = File.ReadLines(filepath).ElementAt(1);
                e98 = e98.Remove(0, e98.IndexOf(' ', +1));
                e98 = Math.Round((double)Convert.ToDouble(e98), 3).ToString();
                textBox2.Text = $"{e98} €";

                var diesel = File.ReadLines(filepath).ElementAt(2);
                diesel = diesel.Remove(0, diesel.IndexOf(' ', +1));
                diesel = Math.Round((double)Convert.ToDouble(diesel), 3).ToString();
                textBox3.Text = $"{diesel} €";
            }
            else
            {
                var e95 = File.ReadLines(filepath101).ElementAt(0);
                textBox1.Text = $"{e95} €";

                var e98 = File.ReadLines(filepath102).ElementAt(0);
                textBox2.Text = $"{e98} €";

                var diesel = File.ReadLines(filepath103).ElementAt(0);
                textBox3.Text = $"{diesel} €";
            }

            if (!sound)
            {
                soundToolStripMenuItem.ForeColor = Color.Red;
            }
            else
            {
                soundToolStripMenuItem.ForeColor = Color.Green;
            }
            if (eriTiedostot)
            {
                tiedostoToolStripMenuItem.ForeColor = Color.Red;
            }
            else
            {
                tiedostoToolStripMenuItem.ForeColor = Color.Green;
            }
            
        }

        private void Button12_Click(object sender, EventArgs e) //Delete nappi
        {
            if (sound)
            {
                if (Directory.Exists("C:/temp/SoundClips"))
                {
                    System.Media.SoundPlayer Beep = new System.Media.SoundPlayer("C:/temp/SoundClips/Beep.wav");
                    Beep.Play();
                }
            }
            textBox4.Text = "";
        }
        private async void Progress(double litrat) //ProgressBar
        {
            tankkaus = false;
            progressBar1.Visible = true;
            progressBar1.Maximum = Convert.ToInt32(litrat);
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            
            while (progressBar1.Value < litrat)
            {
                await Task.Delay(200);
                progressBar1.Value += 1;
            }
            
            if(progressBar1.Value == litrat)
            {
                await Task.Delay(1500);
                label8.Visible = true;
                label8.ForeColor = Color.Orange;
                button13.Enabled = true;
                button13.Visible = true;
                kuitti = true;
            }

        }

        private void Button13_Click(object sender, EventArgs e) // Kuitti/Lopeta/Uusi asiakas
        {
            if (kuitti)
            {
                kortti = false;
                tyhjennys = true;
                valinta = false;
                määrä = false;
                tankkaus = false;
                kuitti = false;
                litrat = 0;
                hinta = "";
                bensa = "";
                if(Directory.Exists("C:/Temp/SoundClips"))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Temp/SoundClips/Printer.wav");
                    if (sound)
                    {
                        player.Play();
                    }
                }
                
                
                this.Hide();
                //this.Dispose();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                
            }
            
        } //"Kuitin tulostus"

        private void Button14_Click(object sender, EventArgs e) // Soita asiakaspalveluun
        {
            if(Directory.Exists("C:/Temp/SoundClips"))
            {
                System.Media.SoundPlayer player3 = new System.Media.SoundPlayer("C:/Temp/SoundClips/Calling.wav");
                if (sound)
                {
                    player3.Play();
                }
            }
            
            
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e) // Avaa AdminForm 
        {
            
            //LoginForm login = new LoginForm();
            
            Form tmp = this.FindForm();
            tmp.Hide();  
            login.ShowDialog();
            tmp.Close();
            tmp.Dispose();
        }

        private void TiedostoToolStripMenuItem_Click(object sender, EventArgs e) // Bensan hinnat otetaan 1 tai 3 tiedostosta
        {
            if (!eriTiedostot)
            {
                eriTiedostot = true;
                tiedostoToolStripMenuItem.ForeColor = Color.Red;
            }
            else
            {
                eriTiedostot = false;
                tiedostoToolStripMenuItem.ForeColor = Color.Green;
            }
            
        }

        private void SoundToolStripMenuItem_Click(object sender, EventArgs e) //Äänet päällä tai Pois
        {
            if (Directory.Exists(filepathSound))
            {
                if (!sound)
                {
                    sound = true;

                    soundToolStripMenuItem.ForeColor = Color.Green;

                }
                else
                {
                    sound = false;
                    soundToolStripMenuItem.ForeColor = Color.Red;
                }
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
