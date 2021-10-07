using CmlLib.Core;
using CmlLibCoreSample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCraftV4
{
    public partial class Cracked_window : Form
    {
        public Cracked_window()
        {
            InitializeComponent();
            var path = new MinecraftPath();
            string user = System.Environment.GetEnvironmentVariable("USERPROFILE");
            Console.WriteLine(user);
            string MainPath = @"%user%\AppData\Roaming\.minecraft\versions".Replace("%user%", user);
            //Console.WriteLine(Directory.GetDirectories(MainPath)[0]);

            string[] dirs = Directory.GetDirectories(MainPath);

            foreach (string i in dirs)
            {
                string version = i.Replace(@"\AppData\Roaming\.minecraft\versions\", "").Replace(user, "");
                if (version == "1.16.5" || i == "1.15" || i == "1.14" || i == "1.13" || i == "1.12" || i == "1.11" || i == "1.10" || i == "1.9" || i == "1.8" || i == "1.7" || i == "1.6")
                {

                }
                else
                {
                    comboBox1.Items.Add(i.Replace(@"\AppData\Roaming\.minecraft\versions\", "").Replace(user, ""));
                }
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Version = comboBox1.Text;

            Cracked_Launcher.Main(UserName, Version);


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = @"C:\Users\leonDev2\AppData\Roaming\.minecraft\versions\";
            string folder = "1.16.5";

            bool exists = Directory_exist(path, folder);

            if(exists == true) { Console.WriteLine("il existe"); }
            else { Console.WriteLine("dommaggggge"); }

        }

        private bool Directory_exist(string path, string folder)
        {

            if (Directory.Exists(path + folder))
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
