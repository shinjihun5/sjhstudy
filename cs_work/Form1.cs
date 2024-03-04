using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace WinFormsApp1
{
    // class AA { }
    // class BB { }
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.38)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=hr;Password=1234;";

        OracleConnection conn;
        OracleCommand cmd;

        public Form1()
        {
            InitializeComponent();

            // �ּ� ó�� ����Ű ctrl + k + c
            // mbox tab tab 
            // MessageBox.Show(strConnection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(connectionString);

                //cmd = new OracleCommand();
                //cmd.Connection = conn;

                conn.Open(); // database ����

                DataSet dataSet = new DataSet();
                string sql = "select * from emp";

                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = new OracleCommand(sql, conn);
                adapter.Fill(dataSet);


                dataGridView1.DataSource = dataSet.Tables[0];

                conn.Close(); // database �ݱ�
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            //MessageBox.Show("Test" +strConnection);
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}
