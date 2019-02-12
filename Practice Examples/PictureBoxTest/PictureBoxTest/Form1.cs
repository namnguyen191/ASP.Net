using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String path = "AquariusLogo.png";
            pictureBox1.Image = Image.FromFile("~/PictureBoxTest/Images/AquariusLogo.png");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
