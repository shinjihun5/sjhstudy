using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codereview
{
    public partial class Form1 : Form
    {
        private PictureBox[] cardPictureBoxes;
        private Dictionary<string, Image> imagePanths = new Dictionary<string, Image>();
        private Image cardBackImage;
        private Timer flipTimer;
        private bool canClick;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            cardPictureBoxes = new PictureBox[10];
            imagePanths.Add("Apple", Image.FromFile(@"D:\Students\과일1\3.jpg"));
            imagePanths.Add("Grape", Image.FromFile(@"D:\Students\과일1\4.jpg"));
            imagePanths.Add("Banana", Image.FromFile(@"D:\Students\과일1\2.jpg"));
            imagePanths.Add("Tangerine", Image.FromFile(@"D:\Students\과일1\5.jpg"));
            imagePanths.Add("Strawberry", Image.FromFile(@"D:\Students\과일1\1.jpg"));

            foreach (var item in imagePanths.ToList())
            {
                imagePanths.Add(item.Key + "1", item.Value);
            }

            cardBackImage = Image.FromFile(@"D:\Students\다운로드.jpg");

            Random random = new Random();
            for (int i = 0; i < cardPictureBoxes.Length; i++)
            {
                cardPictureBoxes[i] = new PictureBox();
                cardPictureBoxes[i].Name = "Card" + i;
                cardPictureBoxes[i].Size = new Size(143, 201);
                cardPictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                cardPictureBoxes[i].Image = cardBackImage;
                cardPictureBoxes[i].Click += Card_Click;
                this.Controls.Add(cardPictureBoxes[i]);
            }

            Button startButton = new Button();
            startButton.Text = "게임 시작";
            startButton.Location = new Point(10, 10);
            startButton.Click += StartButton_Click;
            this.Controls.Add(startButton);

            flipTimer = new Timer { Interval = 5000 };
            flipTimer.Tick += FlipTimer_Tick;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ShuffleCards();
            ShowCards();
            flipTimer.Start();
            canClick = true;
        }

        private void FlipTimer_Tick(object sender, EventArgs e)
        {
            HideCards();
            flipTimer.Stop();
            canClick = false;
        }

        private void ShuffleCards()
        {
            Random rnd = new Random();
            var keys = imagePanths.Keys.ToList();
            keys.Remove("Apple");
            keys.Remove("Grape");
            keys.Remove("Banana");
            keys.Remove("Tangerine");
            keys.Remove("Strawberry");
            keys = keys.OrderBy(x => rnd.Next()).ToList();
            keys.InsertRange(0, new List<string> { "Apple", "Grape", "Banana", "Tangerine", "Strawberry" });

            for (int i = 0; i < cardPictureBoxes.Length; i++)
            {
                cardPictureBoxes[i].Name = keys[i];
            }
        }

        private void ShowCards()
        {
            foreach (PictureBox pictureBox in cardPictureBoxes)
            {
                pictureBox.Image = imagePanths[pictureBox.Name];
            }
        }

        private void HideCards()
        {
            foreach (PictureBox pictureBox in cardPictureBoxes)
            {
                pictureBox.Image = cardBackImage;
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (!canClick)
                return;

            PictureBox clickedCard = sender as PictureBox;
            if (clickedCard != null)
            {
                // 카드 클릭 시 동작
            }
        }
    }
}