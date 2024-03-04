namespace c
{
    public partial class Form1 : Form
    {
        public TextBox txtAmount;
        public Form1()
        {
            InitializeComponent();
            txtAmount = new TextBox();
            txtAmount.Location = new System.Drawing.Point(100, 50);
            txtAmount.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(txtAmount);

            Button btnPay = new Button();
            btnPay.Text = "�����ϱ�";
            btnPay.Location = new System.Drawing.Point(100, 100);
            btnPay.Click += BtnPay_Click;
            this.Controls.Add(btnPay);
        }


        private void BtnPay_Click(object sender, EventArgs e)
        {
           
            decimal paymentAmount;
            if (decimal.TryParse(txtAmount.Text, out paymentAmount))
            {
                Form2 otherForm = new Form2();
                otherForm.SetPaymentAmount(paymentAmount);
                otherForm.Show();
            }
            else
            {
                MessageBox.Show("�ùٸ� ������ �ݾ��� �Է��ϼ���.");
            }
        

    }
    private void textBox_TextChanged(object sender, EventArgs e)
        {
            txtAmount = new TextBox();
            txtAmount.Location = new System.Drawing.Point(100, 50);
            txtAmount.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(txtAmount);
        }
    }
}
