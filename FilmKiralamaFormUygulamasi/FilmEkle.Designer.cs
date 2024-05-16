namespace FilmKiralamaFormUygulamasi
{
    partial class FilmEkle
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
            Ekle = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(658, 50);
            button1.Name = "button1";
            button1.Size = new Size(112, 89);
            button1.TabIndex = 0;
            button1.Text = " Menü";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Film Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 84);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 2;
            label2.Text = " Tür:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 277);
            dataGridView1.TabIndex = 3;
            // 
            // Ekle
            // 
            Ekle.Location = new Point(396, 50);
            Ekle.Name = "Ekle";
            Ekle.Size = new Size(125, 89);
            Ekle.TabIndex = 4;
            Ekle.Text = "Ekle";
            Ekle.UseVisualStyleBackColor = true;
            Ekle.Click += Ekle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 131);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = " Yönetmen:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(213, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(527, 50);
            button2.Name = "button2";
            button2.Size = new Size(125, 89);
            button2.TabIndex = 9;
            button2.Text = "Filimler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FilmEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(Ekle);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FilmEkle";
            Text = "FilmEkle";
            Load += FilmEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button Ekle;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
    }
}