using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 


namespace WinFormsApp1
{
    public partial class MainForm1 : Form
    {
        private TextBox txtAmount;
        public MainForm1()
        {
            InitializeComponent();

            txtAmount = new TextBox();
            txtAmount.Location = new System.Drawing.Point(100, 50);
            txtAmount.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(txtAmount);

            Button btnPay = new Button();
            btnPay.Text = "결제하기";
            btnPay.Location = new System.Drawing.Point(100, 100);
            btnPay.Click += BtnPay_Click;
            this.Controls.Add(btnPay);
        }

        private void BtnPay_Click(object? sender, EventArgs e)
        {
            string userInput = txtAmount.Text;
            MessageBox.Show("사용자가 입력한 금액: " + userInput);
            throw new NotImplementedException();
            c_project otherForm = new c_project();
            otherForm.Show();
        }

    
       
    }
}
    

