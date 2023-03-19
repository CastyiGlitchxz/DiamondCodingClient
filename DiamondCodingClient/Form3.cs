using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DiamondCodingClient
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("DiamondCodes Projects/" + Form2.Globals.ProjectName + "/" + "hope.html", textBox1.Text);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            AutoGenerateCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunProject();
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void RunProject()
        {

        }

        private void AutoGenerateCode()
        {

        }
    }
}
