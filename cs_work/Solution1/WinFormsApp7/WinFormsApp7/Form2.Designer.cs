namespace WinFormsApp7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.Font = new Font("맑은 고딕", 9F);
            button2.Location = new Point(152, 48);
            button2.Name = "button2";
            button2.Size = new Size(120, 54);
            button2.TabIndex = 1;
            button2.Text = "카드로 결제하기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Font = new Font("맑은 고딕", 9F);
            button3.Location = new Point(12, 48);
            button3.Name = "button3";
            button3.Size = new Size(120, 54);
            button3.TabIndex = 2;
            button3.Text = "현금으로 결제하기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(284, 161);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
    }
}