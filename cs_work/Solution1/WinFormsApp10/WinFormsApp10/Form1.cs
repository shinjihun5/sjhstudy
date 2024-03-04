using NAudio.Wave;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            timer1.Enabled = true;  

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("A" + e.KeyCode);
            if (e.KeyCode == Keys.Q) { }

            panel1.Visible = false;
            WaveOutEvent woe = new WaveOutEvent();
            woe.Init(new AudioFileReader(@"D:\Students\cs_work\Solution1\WinFormsApp10\WinFormsApp10\dd\¶ó.mp3"));
            woe.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    /* private void Form1_KeyUp(object sender, KeyEventArgs e)
     {
         Console.WriteLine("B" + e.KeyCode);
         panel1.Visible = true;

     }
    */
}
    

