using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCraftV4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Cracked Button
        private void Button2_Click(object sender, EventArgs e)
        {
            Cracked_window maForm = new Cracked_window();
            maForm.Show();
            //Application.Run(new Cracked_window());
        }

        // Premium Button
        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
