namespace FilmKiralamaFormUygulamasi
{
    partial class FilmKirala
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(662, 105);
            button1.Name = "button1";
            button1.Size = new Size(108, 70);
            button1.TabIndex = 1;
            button1.Text = " Menü";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 46);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 2;
            label1.Text = " Müşteri Ad-Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 83);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 3;
            label2.Text = " Müşteri Tel No:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(755, 246);
            dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 31);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = " Başlangıç:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 64);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 7;
            label5.Text = " Bitiş:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(315, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 112);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = " Kiralama Tarihi";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(664, 23);
            button2.Name = "button2";
            button2.Size = new Size(106, 76);
            button2.TabIndex = 13;
            button2.Text = "Kirala";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 154);
            label3.Name = "label3";
            label3.Size = new Size(242, 20);
            label3.TabIndex = 14;
            label3.Text = " Kiralama istediğiniz filmi seçiniz!!!!";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(93, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(93, 64);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // FilmKirala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FilmKirala";
            Text = "FilmKirala";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Button button2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}