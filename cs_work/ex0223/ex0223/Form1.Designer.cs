namespace ex0223
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            Gender = new Label();
            FirstNameBox = new TextBox();
            LastNameBox = new TextBox();
            button4 = new Button();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 231);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("전주 완판본 각B", 12F);
            button1.Location = new Point(328, 83);
            button1.Name = "button1";
            button1.Size = new Size(90, 63);
            button1.TabIndex = 1;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += INSERT;
            // 
            // button2
            // 
            button2.Font = new Font("전주 완판본 각B", 12F);
            button2.Location = new Point(424, 83);
            button2.Name = "button2";
            button2.Size = new Size(90, 63);
            button2.TabIndex = 2;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("전주 완판본 각B", 12F);
            button3.Location = new Point(520, 83);
            button3.Name = "button3";
            button3.Size = new Size(88, 63);
            button3.TabIndex = 3;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("전주 완판본 각B", 12F);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(77, 16);
            label1.TabIndex = 4;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("전주 완판본 각B", 12F);
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(74, 16);
            label2.TabIndex = 5;
            label2.Text = "LastName\r\n";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("전주 완판본 각B", 12F);
            Gender.Location = new Point(13, 129);
            Gender.Name = "Gender";
            Gender.Size = new Size(55, 16);
            Gender.TabIndex = 6;
            Gender.Text = "Gender";
            // 
            // FirstNameBox
            // 
            FirstNameBox.Font = new Font("전주 완판본 각B", 12F);
            FirstNameBox.Location = new Point(97, 51);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(100, 23);
            FirstNameBox.TabIndex = 7;
            // 
            // LastNameBox
            // 
            LastNameBox.Font = new Font("전주 완판본 각B", 12F);
            LastNameBox.Location = new Point(98, 85);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(100, 23);
            LastNameBox.TabIndex = 8;
            LastNameBox.TextChanged += textBox2_TextChanged;
            // 
            // button4
            // 
            button4.Font = new Font("전주 완판본 각B", 12F);
            button4.Location = new Point(520, 12);
            button4.Name = "button4";
            button4.Size = new Size(90, 63);
            button4.TabIndex = 10;
            button4.Text = "SELECT\r\n";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("전주 완판본 각B", 12F);
            textBox4.Location = new Point(328, 33);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 23);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(97, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(79, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(LastNameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(Gender);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label Gender;
        private TextBox FirstNameBox;
        private TextBox LastNameBox;
        private Button button4;
        private TextBox textBox4;
        private ComboBox comboBox1;
    }
}
