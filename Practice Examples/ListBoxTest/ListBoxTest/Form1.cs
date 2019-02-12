using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<String> strList = new List<string>();
            strList.Add("New York");
            strList.Add("London");
            strList.Add("Paris");
            strList.Add("Toronto");
            strList.Add("Tokyo");
            listBox1.Items.AddRange(strList.ToArray());
            //listBox1.DataSource = strList;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedIndex.ToString();
            label1.Text = listBox1.SelectedItem.ToString();
            
        }
    }
}
