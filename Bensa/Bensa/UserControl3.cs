using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bensa
{
    
    public partial class UserControl3 : UserControl
    {
        static readonly string filepath1 = "C:/Temp/BensisOstoHinnat.txt";
        static readonly string filepath2 = "C:/Temp/Bensis.txt";
        //static private string e95Osto = File.ReadLines(filepath1).ElementAt(0);
        //static private string e98Osto = File.ReadLines(filepath1).ElementAt(1);
        //static private string dieselOsto = File.ReadLines(filepath1).ElementAt(2);
        public UserControl3()
        {
            InitializeComponent(); 
            
            InitializeValues();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            //
            //
            //
            //
        }


        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            string e95Osto = textBox1.Text;
            e95Osto = e95Osto.Substring(0, e95Osto.IndexOf(' ', +1));
            numericUpDown1.Value = Convert.ToDecimal(trackBar1.Value);
            double trackbar1Value = 1 + Convert.ToDouble(trackBar1.Value) / 100;
            double e95Myynti = Convert.ToDouble(e95Osto) * trackbar1Value;
            e95Myynti = Math.Round((double)e95Myynti, 3);
            textBox6.Text = $"{e95Myynti.ToString()} €";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void InitializeValues()
        {

            string e95Osto = File.ReadLines(filepath1).ElementAt(0);
            string e98Osto = File.ReadLines(filepath1).ElementAt(1);
            string dieselOsto = File.ReadLines(filepath1).ElementAt(2);
            e95Osto = e95Osto.Remove(0, e95Osto.IndexOf(' ', + 1));
            e98Osto = e98Osto.Remove(0, e98Osto.IndexOf(' ', + 1));
            dieselOsto = dieselOsto.Remove(0, dieselOsto.IndexOf(' ', + 1));

            textBox1.Text = $"{ e95Osto} €";
            textBox2.Text = $"{e98Osto} €";
            textBox3.Text = $"{dieselOsto} €";

            numericUpDown1.Value = trackBar1.Value;
            numericUpDown2.Value = trackBar2.Value;
            numericUpDown3.Value = trackBar3.Value;
            double trackbar1Value = 1 + Convert.ToDouble(trackBar1.Value) / 100;
            double trackbar2Value = 1 + Convert.ToDouble(trackBar2.Value) / 100;
            double trackbar3Value = 1 + Convert.ToDouble(trackBar3.Value) / 100;

            double e95Myynti = Convert.ToDouble(e95Osto) * trackbar1Value;
            textBox6.Text = $"{e95Myynti.ToString()} €";
            double e98Myynti = Convert.ToDouble(e98Osto) * trackbar2Value;
            textBox5.Text = $"{e98Myynti.ToString()} €";
            double dieselMyynti = Convert.ToDouble(dieselOsto) * trackbar3Value;
            textBox4.Text = $"{dieselMyynti.ToString()} €";

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            

            trackBar1.Value = Convert.ToInt32(numericUpDown1.Value);
            string e95Osto = textBox1.Text;
            e95Osto = e95Osto.Substring(0, e95Osto.IndexOf(' ', +1));
            double trackbar1Value = 1 + Convert.ToDouble(trackBar1.Value) / 100;
            double e95Myynti = Convert.ToDouble(e95Osto) * trackbar1Value;
            e95Myynti = Math.Round((double)e95Myynti, 3);
            textBox6.Text = $"{e95Myynti.ToString()} €";
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = Convert.ToInt32(numericUpDown2.Value);
            string e98Osto = textBox2.Text;
            e98Osto = e98Osto.Substring(0, e98Osto.IndexOf(' ', +1));
            double trackbar2Value = 1 + Convert.ToDouble(trackBar2.Value) / 100;
            double e98Myynti = Convert.ToDouble(e98Osto) * trackbar2Value;
            e98Myynti = Math.Round((double)e98Myynti, 3);
            textBox5.Text = $"{e98Myynti.ToString()} €";
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar2.Value;
            string e98Osto = textBox2.Text;
            e98Osto = e98Osto.Substring(0, e98Osto.IndexOf(' ', +1));
            double trackbar2Value = 1 + Convert.ToDouble(trackBar2.Value) / 100;
            double e98Myynti = Convert.ToDouble(e98Osto) * trackbar2Value;
            e98Myynti = Math.Round((double)e98Myynti, 3);
            textBox5.Text = $"{e98Myynti.ToString()} €";
        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            trackBar3.Value = Convert.ToInt32(numericUpDown3.Value);
            string dieselOsto = textBox3.Text;
            dieselOsto = dieselOsto.Substring(0, dieselOsto.IndexOf(' ', +1));
            double trackbar3Value = 1 + Convert.ToDouble(trackBar3.Value) / 100;
            double dieselMyynti = Convert.ToDouble(dieselOsto) * trackbar3Value;
            dieselMyynti = Math.Round((double)dieselMyynti, 3);
            textBox4.Text = $"{dieselMyynti.ToString()} €";
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            numericUpDown3.Value = trackBar3.Value;
            string dieselOsto = textBox3.Text;
            dieselOsto = dieselOsto.Substring(0, dieselOsto.IndexOf(' ', +1));
            double trackbar3Value = 1 + Convert.ToDouble(trackBar3.Value) / 100;
            double dieselMyynti = Convert.ToDouble(dieselOsto) * trackbar3Value;
            dieselMyynti = Math.Round((double)dieselMyynti, 3);
            textBox4.Text = $"{dieselMyynti.ToString()} €";
        }

        private void Päivitys(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(filepath2);
            sw.WriteLine("E95: " + textBox6.Text.Substring(0, textBox6.Text.Length-2));
            sw.WriteLine("E98: " + textBox5.Text.Substring(0, textBox5.Text.Length - 2));
            sw.WriteLine("Die: " + textBox4.Text.Substring(0, textBox4.Text.Length - 2));
            sw.Close();
            Form1 f = new Form1();
            f.InitializeValues();
            f.ShowDialog();
        }
    }
}
