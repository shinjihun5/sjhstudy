namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
    
            InitializeComponent();
            MakeLabel(10, 10, "gd");
            MakeLabel(10, 50, "gd");

        }


        public void MakeLabel(int x,int y, String text)
        {
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new Point(x, y);
            label1.TabIndex = 0;
            label1.Text = text;
            Controls.Add(label1);

        }
    }
}
