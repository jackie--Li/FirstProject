using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirstProject.AppDB;

namespace FirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            Dosqlconnection sql = new Dosqlconnection();
            string pass = sql.getpassword(name);
            if (pass != "")
            {
                textBox2.Text = pass;
            }
            else
            {
                textBox2.Text = "没找到";
            }

        }
    }
}
