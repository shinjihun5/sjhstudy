using ex0223.DB;
using Oracle.ManagedDataAccess.Client;

namespace ex0223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.Items.AddRange(new object[] { "����", "����" });

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void INSERT(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameBox.Text.Trim())
                || string.IsNullOrEmpty(LastNameBox.Text.Trim()))
            {
                MessageBox.Show("�̸��� �Է��ϼ���", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = $"insert into tb_smart_crud " +
                $"values " +
                $"(TB_SMART_SEQ.nextval, " +
                $"'{FirstNameBox.Text}'," +
                $"'{LastNameBox.Text}'," +
                $"'{Gender}')";

            CRUD.con.Open();
            CRUD.cmd = new OracleCommand(sql,CRUD.con);
            CRUD.cmd.ExecuteNonQuery();
            CRUD.con.Close();
           
            MessageBox.Show("����Ǿ����ϴ�.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
