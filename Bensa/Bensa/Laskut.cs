using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Bensa
{
    public class Laskut
    {
        static readonly string filepath = "C:/temp/Bensis.txt";
        static readonly string filepath2 = "C:/temp/BensisKuitit.txt";       
        static readonly string filepath3 = "C:/temp/BensisOstoHinnat.txt";
        static public string Hinta(double määrä, string laatu)
        {
                      
            double hinta;
            double total;
            string hintaString;
            switch (laatu)
            {
                case "E95":
                    hintaString = File.ReadLines(filepath).ElementAt(0);
                    hintaString = hintaString.Remove(0, hintaString.IndexOf(' ', +1));
                    hinta = double.Parse(hintaString);
                    total = hinta * määrä;
                    return total.ToString() ;
                case "E98":
                    hintaString = File.ReadLines(filepath).ElementAt(1);
                    hintaString = hintaString.Remove(0, hintaString.IndexOf(' ', +1));
                    hinta = double.Parse(hintaString);
                    total = hinta * määrä;
                    return total.ToString();
                case "Diesel":
                    hintaString = File.ReadLines(filepath).ElementAt(2);
                    hintaString = hintaString.Remove(0, hintaString.IndexOf(' ', +1));
                    hinta = double.Parse(hintaString);
                    total = hinta * määrä;
                    return total.ToString();
                default:
                    return null;
                    
            }
            
        }
        static public void Talletus(string laatu, double määrä, string hinta)
        {

            StreamWriter sw = new StreamWriter(filepath2,true);
            sw.WriteLine("Aika: " + DateTime.Now);
            sw.WriteLine($"Laatu: {laatu}");
            sw.WriteLine($"Ostettu määrä: {määrä} Litraa");
            sw.WriteLine($"Ostoksen hinta: {hinta}");
            sw.WriteLine("----------------------------");
            sw.Close();

        }
        static public void OstoHinnasto()
        {
            StreamWriter sw = new StreamWriter(filepath3);
            Random rnd = new Random();
            double e95 = rnd.NextDouble() * 2;
            double e98 = rnd.NextDouble() * 2;
            double diesel = rnd.NextDouble() * 2;
            while (e95 > 1.200 || e95<0.900)
            {
                e95 = rnd.NextDouble() * 2;
            }
            e95 = Math.Round((double)e95 , 3);
            while (e98 > 1.300 || e98 < 1.000)
            {
                e98 = rnd.NextDouble() * 2;
            }
            e98 = Math.Round((double)e98 , 3);
            while (diesel > 1.050 || diesel < 0.750)
            {
                diesel = rnd.NextDouble() * 2;
            }
            diesel = Math.Round((double)diesel, 3);

            sw.WriteLine("E95: " + e95);
            sw.WriteLine("E98: " + e98);
            sw.WriteLine("Diesel: " + diesel);
            sw.Close();
            
            
            



        }
    }
}
