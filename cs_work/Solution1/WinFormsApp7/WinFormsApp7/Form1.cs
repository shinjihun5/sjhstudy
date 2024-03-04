namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenSecondForm()
        {
            Form2 secondForm = new Form2();
            secondForm.StartPosition = FormStartPosition.CenterParent; 
            secondForm.Size = new Size(300, 200); 
            secondForm.ShowDialog(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("menu", "메뉴");
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("와퍼", "와퍼");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.StartPosition = FormStartPosition.CenterParent;
            secondForm.Size = new Size(300, 200);
            secondForm.ShowDialog();
           
        }
    }
}
