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
using System.Diagnostics;

namespace DiamondCodingClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("DiamondCodes Projects" + "/" + Pname.Text);
            Globals.ProjectName = Pname.Text;
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        public static class Globals
        {
            public static string ProjectName = "";
        }
    }
}
