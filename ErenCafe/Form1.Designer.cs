namespace ErenCafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listBox4 = new ListBox();
            label9 = new Label();
            listBox5 = new ListBox();
            label10 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            label13 = new Label();
            comboBox4 = new ComboBox();
            label12 = new Label();
            comboBox5 = new ComboBox();
            label14 = new Label();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 0;
            label1.Text = "Masa Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 1;
            label2.Text = "Yiyecekler:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 2;
            label3.Text = "İçecekler:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 238);
            label4.Name = "label4";
            label4.Size = new Size(115, 30);
            label4.TabIndex = 3;
            label4.Text = "Süre Sınırı:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Çikolatalı gofret", "Tost", "Köfte", "Bisküvi" });
            comboBox1.Location = new Point(122, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Fanta", "Kola", "Soda", "Meyveli Soda", "Ayran" });
            comboBox2.Location = new Point(122, 182);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "30 dk", "1 saat" });
            comboBox3.Location = new Point(122, 240);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(32, 289);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 34);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "3 kol";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(191, 289);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 34);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "4 kol";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 402);
            button1.Name = "button1";
            button1.Size = new Size(171, 66);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(240, 402);
            button2.Name = "button2";
            button2.Size = new Size(170, 66);
            button2.TabIndex = 11;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(201, 9);
            label5.Name = "label5";
            label5.Size = new Size(234, 50);
            label5.TabIndex = 13;
            label5.Text = "ErenPlayCafe";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(977, 388);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 124);
            listBox1.TabIndex = 14;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(1144, 388);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 124);
            listBox2.TabIndex = 15;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(1312, 388);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(160, 124);
            listBox3.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(441, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(418, 341);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1016, 353);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 21;
            label6.Text = "Masa Ad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1178, 353);
            label7.Name = "label7";
            label7.Size = new Size(116, 30);
            label7.TabIndex = 22;
            label7.Text = "Yiyecekler:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1359, 353);
            label8.Name = "label8";
            label8.Size = new Size(104, 30);
            label8.TabIndex = 23;
            label8.Text = "İçecekler:";
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 20;
            listBox4.Location = new Point(806, 388);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(150, 124);
            listBox4.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(854, 353);
            label9.Name = "label9";
            label9.Size = new Size(115, 30);
            label9.TabIndex = 25;
            label9.Text = "Süre Sınırı:";
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 20;
            listBox5.Location = new Point(629, 388);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(150, 124);
            listBox5.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(663, 353);
            label10.Name = "label10";
            label10.Size = new Size(107, 30);
            label10.TabIndex = 27;
            label10.Text = "Kol Sayısı:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(32, 337);
            label11.Name = "label11";
            label11.Size = new Size(70, 30);
            label11.TabIndex = 28;
            label11.Text = "Ücret:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 340);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(911, 119);
            label13.Name = "label13";
            label13.Size = new Size(152, 30);
            label13.TabIndex = 31;
            label13.Text = "2 kol kiralama:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "24 saat kiralama", "48 saat kiralama", "72 saat kiralama" });
            comboBox4.Location = new Point(1060, 119);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 32;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(902, 194);
            label12.Name = "label12";
            label12.Size = new Size(152, 30);
            label12.TabIndex = 33;
            label12.Text = "4 kol kiralama:";
            // 
            // comboBox5
            // 
            comboBox5.Enabled = false;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "24 saat kiralama", "48 saat kiralama", "72 saat kiralama" });
            comboBox5.Location = new Point(1060, 194);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(151, 28);
            comboBox5.TabIndex = 34;
            comboBox5.SelectedValueChanged += comboBox5_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(911, 262);
            label14.Name = "label14";
            label14.Size = new Size(161, 30);
            label14.TabIndex = 35;
            label14.Text = "Kiralama ücreti:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1069, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 36;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(969, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 24);
            radioButton1.TabIndex = 37;
            radioButton1.TabStop = true;
            radioButton1.Tag = "test";
            radioButton1.Text = "2 KOLLU";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(1109, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 24);
            radioButton2.TabIndex = 38;
            radioButton2.Tag = "test";
            radioButton2.Text = "4 KOLLU";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 515);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(label14);
            Controls.Add(comboBox5);
            Controls.Add(label12);
            Controls.Add(comboBox4);
            Controls.Add(label13);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(listBox5);
            Controls.Add(label9);
            Controls.Add(listBox4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Button button2;
        private Label label5;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox listBox4;
        private Label label9;
        private ListBox listBox5;
        private Label label10;
        private Label label11;
        private TextBox textBox2;
        private Label label13;
        private ComboBox comboBox4;
        private Label label12;
        private ComboBox comboBox5;
        private Label label14;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}