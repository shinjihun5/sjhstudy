using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            button2.Location = new Point((this.ClientSize.Width - button2.Width) / 2, (this.ClientSize.Height - button2.Height) / 2);

            button3.Location = new Point((this.ClientSize.Width - button3.Width) / 2, (this.ClientSize.Height - button3.Height) / 2);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
