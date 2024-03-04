namespace WinFormsApp2
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            button5 = new Button();
            textBox5 = new TextBox();
            button6 = new Button();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("바탕체", 12F, FontStyle.Bold);
            button1.Location = new Point(351, 227);
            button1.Name = "button1";
            button1.Size = new Size(128, 26);
            button1.TabIndex = 0;
            button1.Text = "자동차 추가";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("바탕체", 12F, FontStyle.Bold);
            textBox1.Location = new Point(193, 227);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 26);
            textBox1.TabIndex = 1;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("바탕체", 12F, FontStyle.Bold);
            textBox2.Location = new Point(193, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 26);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("바탕체", 12F, FontStyle.Bold);
            button2.Location = new Point(351, 291);
            button2.Name = "button2";
            button2.Size = new Size(128, 26);
            button2.TabIndex = 2;
            button2.Text = "자동차 추가";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("바탕체", 12F, FontStyle.Bold);
            textBox3.Location = new Point(193, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 26);
            textBox3.TabIndex = 5;
            // 
            // button3
            // 
            button3.Font = new Font("바탕체", 12F, FontStyle.Bold);
            button3.Location = new Point(351, 259);
            button3.Name = "button3";
            button3.Size = new Size(128, 26);
            button3.TabIndex = 4;
            button3.Text = "자동차 추가";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("바탕체", 12F, FontStyle.Bold);
            button4.Location = new Point(351, 195);
            button4.Name = "button4";
            button4.Size = new Size(128, 26);
            button4.TabIndex = 0;
            button4.Text = "자동차 추가";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("바탕체", 12F, FontStyle.Bold);
            textBox4.Location = new Point(193, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(133, 26);
            textBox4.TabIndex = 1;
            textBox4.KeyUp += textBox1_KeyUp;
            // 
            // button5
            // 
            button5.Font = new Font("바탕체", 12F, FontStyle.Bold);
            button5.Location = new Point(351, 163);
            button5.Name = "button5";
            button5.Size = new Size(128, 26);
            button5.TabIndex = 0;
            button5.Text = "자동차 추가";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("바탕체", 12F, FontStyle.Bold);
            textBox5.Location = new Point(193, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(133, 26);
            textBox5.TabIndex = 1;
            textBox5.KeyUp += textBox1_KeyUp;
            // 
            // button6
            // 
            button6.Font = new Font("바탕체", 12F, FontStyle.Bold);
            button6.Location = new Point(351, 131);
            button6.Name = "button6";
            button6.Size = new Size(128, 26);
            button6.TabIndex = 0;
            button6.Text = "자동차 추가";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("바탕체", 12F, FontStyle.Bold);
            textBox6.Location = new Point(193, 131);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(133, 26);
            textBox6.TabIndex = 1;
            textBox6.KeyUp += textBox1_KeyUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
        private Button button5;
        private TextBox textBox5;
        private Button button6;
        private TextBox textBox6;
    }
}
