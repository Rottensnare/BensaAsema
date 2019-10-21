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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Coloration();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
           // button1.ForeColor = Color.FromArgb(255, 255, 150, 0);
        }

        private void Form2_MouseLeave(object sender, EventArgs e)
        {
            //button1.ForeColor = Color.FromArgb(255, 100, 100, 100);
        }
        private async void Coloration()
        {
            int r = 0;
            int g = 0;
            int b = 0;
            string color = "red";
            bool suuntaYlos = true;
            while (true)
            {
                await Task.Delay(3);
                BackColor = Color.FromArgb(255, r, g, b);
                switch (color)
                {
                    #region Red
                    case "red":
                        
                        if(r < Color.DarkOrange.R)
                        {
                            r++;
                        }else if (r > Color.DarkOrange.R)
                        {
                            r--;
                        }

                        if (g < Color.DarkOrange.G)
                        {
                            g++;
                        }
                        else if (g > Color.DarkOrange.G)
                        {
                            g--;
                        }
                        if (b < Color.DarkOrange.B)
                        {
                            b++;
                        }
                        else if (b > Color.DarkOrange.B)
                        {
                            b--;
                        }
                                          
                        if (r == Color.DarkOrange.R && g == Color.DarkOrange.G && b == Color.DarkOrange.B)
                        {
                            color = "DarkOrange";
                        }
                        break;
                    #endregion
                    #region DarkOrange
                    case "DarkOrange":
                        if (r < Color.Orange.R)
                        {
                            r++;
                        }
                        else if (r > Color.Orange.R)
                        {
                            r--;
                        }

                        if (g < Color.Orange.G)
                        {
                            g++;
                        }
                        else if (g > Color.Orange.G)
                        {
                            g--;
                        }
                        if (b < Color.Orange.B)
                        {
                            b++;
                        }
                        else if (b > Color.Orange.B)
                        {
                            b--;
                        }

                        if (r == Color.Orange.R && g == Color.Orange.G && b == Color.Orange.B)
                        {
                            color = "Yellow";
                        }
                        break; 
                    #endregion
                    #region Yellow
                    case "Yellow":
                        if (r < Color.Yellow.R)
                        {
                            r++;
                        }
                        else if (r > Color.Yellow.R)
                        {
                            r--;
                        }

                        if (g < Color.Yellow.G)
                        {
                            g++;
                        }
                        else if (g > Color.Yellow.G)
                        {
                            g--;
                        }
                        if (b < Color.Yellow.B)
                        {
                            b++;
                        }
                        else if (b > Color.Yellow.B)
                        {
                            b--;
                        }

                        if (r == Color.Yellow.R && g == Color.Yellow.G && b == Color.Yellow.B)
                        {
                            color = "YellowGreen";
                        }
                        break; 
                    #endregion
                    #region YellowGreen
                    case "YellowGreen":
                        if (r < Color.YellowGreen.R)
                        {
                            r++;
                        }
                        else if (r > Color.YellowGreen.R)
                        {
                            r--;
                        }

                        if (g < Color.YellowGreen.G)
                        {
                            g++;
                        }
                        else if (g > Color.YellowGreen.G)
                        {
                            g--;
                        }
                        if (b < Color.YellowGreen.B)
                        {
                            b++;
                        }
                        else if (b > Color.YellowGreen.B)
                        {
                            b--;
                        }

                        if (r == Color.YellowGreen.R && g == Color.YellowGreen.G && b == Color.YellowGreen.B)
                        {
                            color = "Green";
                        }
                        break; 
                    #endregion
                    #region Green
                    case "Green":
                        if (r < Color.Green.R)
                        {
                            r++;
                        }
                        else if (r > Color.Green.R)
                        {
                            r--;
                        }

                        if (g < Color.Green.G)
                        {
                            g++;
                        }
                        else if (g > Color.Green.G)
                        {
                            g--;
                        }
                        if (b < Color.Green.B)
                        {
                            b++;
                        }
                        else if (b > Color.Green.B)
                        {
                            b--;
                        }

                        if (r == Color.Green.R && g == Color.Green.G && b == Color.Green.B)
                        {
                            color = "Aquamarine";
                        }
                        break; 
                    #endregion
                    #region Aquamarine
                    case "Aquamarine":
                        if (r < Color.Aquamarine.R)
                        {
                            r++;
                        }
                        else if (r > Color.Aquamarine.R)
                        {
                            r--;
                        }

                        if (g < Color.Aquamarine.G)
                        {
                            g++;
                        }
                        else if (g > Color.Aquamarine.G)
                        {
                            g--;
                        }
                        if (b < Color.Aquamarine.B)
                        {
                            b++;
                        }
                        else if (b > Color.Aquamarine.B)
                        {
                            b--;
                        }

                        if (r == Color.Aquamarine.R && g == Color.Aquamarine.G && b == Color.Aquamarine.B)
                        {
                            color = "Blue";
                        }
                        break;
                    #endregion
                    case "Blue":
                        if (r < Color.Orange.R)
                        {
                            r++;
                        }
                        else if (r > Color.Orange.R)
                        {
                            r--;
                        }

                        if (g < Color.Orange.G)
                        {
                            g++;
                        }
                        else if (g > Color.Orange.G)
                        {
                            g--;
                        }
                        if (b < Color.Orange.B)
                        {
                            b++;
                        }
                        else if (b > Color.Orange.B)
                        {
                            b--;
                        }

                        if (r == Color.Orange.R && g == Color.Orange.G && b == Color.Orange.B)
                        {
                            color = "Yellow";
                        }
                        break;
                }
                //if (suuntaYlos)
                //{

                //    r++;
                //    if (r >= 255)
                //    {
                //        suuntaYlos = false;
                //    }
                //}
                //if (!suuntaYlos)
                //{
                //    r--;
                //    if (r <= 0)
                //    {
                //        suuntaYlos = true;
                //    }
                //}

            }
            
        }
    }
}
