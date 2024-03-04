namespace mdiprotect.user
{
    partial class UserForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.사용자 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TB_ADDR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_EMAIL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2.SuspendLayout();
            this.사용자.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.사용자);
            this.panel2.Location = new System.Drawing.Point(3, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 270);
            this.panel2.TabIndex = 0;
            // 
            // 사용자
            // 
            this.사용자.Controls.Add(this.dataGridView1);
            this.사용자.Font = new System.Drawing.Font("궁서체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.사용자.Location = new System.Drawing.Point(0, 3);
            this.사용자.Name = "사용자";
            this.사용자.Size = new System.Drawing.Size(797, 264);
            this.사용자.TabIndex = 14;
            this.사용자.TabStop = false;
            this.사용자.Text = "사용자";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(797, 249);
            this.dataGridView1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.TB_ADDR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_PASSWORD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_NAME);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_EMAIL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("궁서체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(797, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자관리";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(244, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 150);
            this.panel1.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(187, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 25);
            this.textBox5.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "SEARCH";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 42);
            this.button4.TabIndex = 17;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 42);
            this.button3.TabIndex = 16;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "INSERT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 57);
            this.button1.TabIndex = 14;
            this.button1.Text = "SELCET";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TB_ADDR
            // 
            this.TB_ADDR.Location = new System.Drawing.Point(86, 134);
            this.TB_ADDR.Name = "TB_ADDR";
            this.TB_ADDR.Size = new System.Drawing.Size(138, 25);
            this.TB_ADDR.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "ADDR";
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.Location = new System.Drawing.Point(86, 96);
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.Size = new System.Drawing.Size(138, 25);
            this.TB_PASSWORD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "PASSWORD";
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(86, 56);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(138, 25);
            this.TB_NAME.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAME";
            // 
            // TB_EMAIL
            // 
            this.TB_EMAIL.Location = new System.Drawing.Point(86, 20);
            this.TB_EMAIL.Name = "TB_EMAIL";
            this.TB_EMAIL.Size = new System.Drawing.Size(138, 25);
            this.TB_EMAIL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMAIL";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel2.ResumeLayout(false);
            this.사용자.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_ADDR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_PASSWORD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_EMAIL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox 사용자;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}