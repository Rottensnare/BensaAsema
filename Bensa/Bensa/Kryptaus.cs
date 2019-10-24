using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.IO;

namespace Bensa
{
    class Kryptaus
    {
        static string filepath = "C:/Temp/Salasanat.txt";
        static private string tunnusAdmin = "";
        static private string salasanaAdmin = "";
        public Kryptaus() // Initialize admin
        {

            MD5CryptoServiceProvider cspAdmin = new MD5CryptoServiceProvider();
            StreamWriter sw = new StreamWriter(filepath);
            tunnusAdmin = "Juupelis";
            salasanaAdmin = "Kissa";
            byte[] data = Encoding.ASCII.GetBytes(salasanaAdmin);
            data = cspAdmin.ComputeHash(data);

            string md5TiivisteAdmin = "";
            for (int i = 0; i < data.Length; i++)
            {
                md5TiivisteAdmin += data[i].ToString("x2").ToLower();
            }
            sw.WriteLine(tunnusAdmin);
            sw.WriteLine(md5TiivisteAdmin);
            sw.Close();
        }
        static public string Salaus(string salasana) // Salasana md5Tiivisteeksi
        {


            string salasanaUser;//,tunnusUser;
            //tunnusUser = tunnus;
            salasanaUser = salasana;
            MD5CryptoServiceProvider csp = new MD5CryptoServiceProvider();
            byte[] data = Encoding.ASCII.GetBytes(salasanaUser);
            data = csp.ComputeHash(data);

            string md5TiivisteUser = "";
            for(int i = 0; i < data.Length; i++)
            {
                md5TiivisteUser += data[i].ToString("x2").ToLower();
            }
            //Tarkistus(md5TiivisteUser, tunnusUser);
            return md5TiivisteUser;

        }
        static public bool Tarkistus(string md5Tiiviste, string tunnus) // Salasanan ja Tunnuksen Oikein tarkistus
        {
            string adminTiiviste = File.ReadLines(filepath).ElementAt(1);
            string adminKäyttis = File.ReadLines(filepath).ElementAt(0);
            if (md5Tiiviste == adminTiiviste && tunnus == adminKäyttis)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
    }
}
