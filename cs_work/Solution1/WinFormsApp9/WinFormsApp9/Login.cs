

using WinFormsApp9.member;

namespace WinFormsApp9
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);
            Console.WriteLine(textBox2.Text);

            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("�α��μ���");
                Hide();
                Mainform mf = new Mainform(textBox1.Text, textBox2.Text);
                mf.ShowDialog();               

                Show();
            }
            else
            {
                MessageBox.Show("���̵�� ��й�ȣ Ȯ���ϼ���");
            }
        }

    }
}
