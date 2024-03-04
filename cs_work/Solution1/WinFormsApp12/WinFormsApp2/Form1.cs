namespace WinFormsApp2
{
    class Car
    {
        public string Name { get; set; }
        
    }
    public partial class Form1 : Form
    {
        int y = 10;

        List<Car> list = new List<Car>();
        Car car = new Car() {Name="마이자동차" };
        public Form1()
        {
            InitializeComponent();
            MakeLabel(10, y = 10, "gd");
            MakeLabel(10, y += 40, "gd");
            // MakeLabel(10, y+=40, "gd");
            Car car1 = new Car() { Name = "마이자동차" };
            Car car2 = new Car() { Name = "마이자동차2" };
            
            list.Add(car1);
            list.Add(car2); 

        }
        public void MakeLabel(int x, int y, String text)
        {
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new Point(x, y);
            label1.TabIndex = 0;
            label1.Text = text;
            Controls.Add(label1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeLabel(10, y = y + 40, textBox1.Text);
            Console.WriteLine(textBox1.Text);
            textBox1.Text = "";

        }

     

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
    }
}
