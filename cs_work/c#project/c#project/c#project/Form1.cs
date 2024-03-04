using MySql.Data.MySqlClient;

namespace c_project
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=192.168.0.38;Port=3306;Database=sjh;Uid=root;Pwd=1234;";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            button2.Location = new Point((this.ClientSize.Width - button2.Width) / 2, (this.ClientSize.Height - button2.Height) / 2);

            button3.Location = new Point((this.ClientSize.Width - button3.Width) / 2, (this.ClientSize.Height - button3.Height) / 2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cashPaymentButton_Click(object sender, EventArgs e)
        {
            string paymentType = "현금";

            AddPaymentToDatabase(paymentType);
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cardPaymentButton_Click(object sender, EventArgs e)
        {
            string paymentType = "카드";

            AddPaymentToDatabase(paymentType);
        }
        private void AddPaymentToDatabase(string paymentType)
        {

            string connectionString = "Server=서버주소;Port=3306;Database=sjh;Uid=root;Pwd=1234;";


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {

                    connection.Open();

                    string query = "INSERT INTO Payment (PaymentType, Amount) VALUES (@PaymentType, @Amount)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@PaymentType", paymentType);
                //    command.Parameters.AddWithValue("@Amount", amount);


                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

