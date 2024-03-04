namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(528, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(205, 225);
            button1.Name = "button1";
            button1.Size = new Size(87, 36);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 63);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 132);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 29);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 29);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 183);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 5;
            label4.Text = "label3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 132);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 3;
            label5.Text = "label2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 316);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 3;
            label7.Text = "label2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(238, 316);
            label8.Name = "label8";
            label8.Size = new Size(54, 21);
            label8.TabIndex = 5;
            label8.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
    }
}
