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
        private async void Coloration()
        {
            int r = 0;
            int g = 0;
            int b = 0;
            int speed = 3;
            string color = "Red";
            //bool suuntaYlos = true;
            while (true)
            {
                await Task.Delay(speed);
                BackColor = Color.FromArgb(255, r, g, b);
                switch (color)
                {
                    #region Red
                    case "Red":

                        if (r < Color.DarkOrange.R)
                        {
                            r++;
                        }
                        else if (r > Color.DarkOrange.R)
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
                    #region Blue
                    case "Blue":
                        if (r < Color.Blue.R)
                        {
                            r++;
                        }
                        else if (r > Color.Blue.R)
                        {
                            r--;
                        }

                        if (g < Color.Blue.G)
                        {
                            g++;
                        }
                        else if (g > Color.Blue.G)
                        {
                            g--;
                        }
                        if (b < Color.Blue.B)
                        {
                            b++;
                        }
                        else if (b > Color.Blue.B)
                        {
                            b--;
                        }

                        if (r == Color.Blue.R && g == Color.Blue.G && b == Color.Blue.B)
                        {
                            color = "BlueViolet";
                        }
                        break;
                    #endregion
                    #region BlueViolet
                    case "BlueViolet":
                        if (r < Color.BlueViolet.R)
                        {
                            r++;
                        }
                        else if (r > Color.BlueViolet.R)
                        {
                            r--;
                        }

                        if (g < Color.BlueViolet.G)
                        {
                            g++;
                        }
                        else if (g > Color.BlueViolet.G)
                        {
                            g--;
                        }
                        if (b < Color.BlueViolet.B)
                        {
                            b++;
                        }
                        else if (b > Color.BlueViolet.B)
                        {
                            b--;
                        }

                        if (r == Color.BlueViolet.R && g == Color.BlueViolet.G && b == Color.BlueViolet.B)
                        {
                            color = "Violet";
                        }
                        break;
                    #endregion
                    #region Violet
                    case "Violet":
                        if (r < Color.Violet.R)
                        {
                            r++;
                        }
                        else if (r > Color.Violet.R)
                        {
                            r--;
                        }

                        if (g < Color.Violet.G)
                        {
                            g++;
                        }
                        else if (g > Color.Violet.G)
                        {
                            g--;
                        }
                        if (b < Color.Violet.B)
                        {
                            b++;
                        }
                        else if (b > Color.Violet.B)
                        {
                            b--;
                        }

                        if (r == Color.Violet.R && g == Color.Violet.G && b == Color.Violet.B)
                        {
                            color = "Mauves";
                        }
                        break;
                    #endregion
                    #region Mauves
                    case "Mauves":
                        if (r < Color.MediumVioletRed.R)
                        {
                            r++;
                        }
                        else if (r > Color.MediumVioletRed.R)
                        {
                            r--;
                        }

                        if (g < Color.MediumVioletRed.G)
                        {
                            g++;
                        }
                        else if (g > Color.MediumVioletRed.G)
                        {
                            g--;
                        }
                        if (b < Color.MediumVioletRed.B)
                        {
                            b++;
                        }
                        else if (b > Color.MediumVioletRed.B)
                        {
                            b--;
                        }

                        if (r == Color.MediumVioletRed.R && g == Color.MediumVioletRed.G && b == Color.MediumVioletRed.B)
                        {
                            color = "Pink";
                        }
                        break;
                    #endregion
                    #region Pink
                    case "Pink":
                        if (r < Color.Pink.R)
                        {
                            r++;
                        }
                        else if (r > Color.Pink.R)
                        {
                            r--;
                        }

                        if (g < Color.Pink.G)
                        {
                            g++;
                        }
                        else if (g > Color.Pink.G)
                        {
                            g--;
                        }
                        if (b < Color.Pink.B)
                        {
                            b++;
                        }
                        else if (b > Color.Pink.B)
                        {
                            b--;
                        }

                        if (r == Color.Pink.R && g == Color.Pink.G && b == Color.Pink.B)
                        {
                            color = "Redish";
                        }
                        break;
                    #endregion
                    #region Reddish
                    case "Redish":
                        if (r < Color.Red.R)
                        {
                            r++;
                        }
                        else if (r > Color.Red.R)
                        {
                            r--;
                        }

                        if (g < Color.Red.G)
                        {
                            g++;
                        }
                        else if (g > Color.Red.G)
                        {
                            g--;
                        }
                        if (b < Color.Red.B)
                        {
                            b++;
                        }
                        else if (b > Color.Red.B)
                        {
                            b--;
                        }

                        if (r == Color.Red.R && g == Color.Red.G && b == Color.Red.B)
                        {
                            color = "Red";
                        }
                        break;
                        #endregion
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
