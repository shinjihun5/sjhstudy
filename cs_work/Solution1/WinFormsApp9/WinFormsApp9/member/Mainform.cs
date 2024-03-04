using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9.member
{
    public partial class Mainform : Form
    {
        public Mainform(string id, string password)
        {
            InitializeComponent();
            label1.Text = id;
            label2.Text = password;
            UserControl1 userControl1 = new UserControl1();
            UserControl2 userControl2 = new UserControl2();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }
    }
}
