namespace lab9b
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label11 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label12 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Image = (Image)resources.GetObject("label11.Image");
            label11.Location = new Point(275, 21);
            label11.Name = "label11";
            label11.Size = new Size(163, 26);
            label11.TabIndex = 56;
            label11.Text = "Update Book";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 83);
            label1.Name = "label1";
            label1.Size = new Size(263, 20);
            label1.TabIndex = 54;
            label1.Text = "Enter BookID you want to update data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 557);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 79;
            label4.Text = "DateAdded";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 511);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 78;
            label3.Text = "RackNo";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(360, 508);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(151, 27);
            textBox8.TabIndex = 77;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(360, 463);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(151, 27);
            textBox7.TabIndex = 76;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(360, 420);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(151, 27);
            textBox6.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(236, 142);
            label2.Name = "label2";
            label2.Size = new Size(259, 26);
            label2.TabIndex = 74;
            label2.Text = "Update Book Details ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(360, 380);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 27);
            textBox5.TabIndex = 73;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(360, 297);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 72;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(360, 552);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 71;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(360, 254);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 70;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(207, 427);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 69;
            label10.Text = "Quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(207, 387);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 68;
            label9.Text = "ISBN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 345);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 67;
            label8.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(207, 304);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 66;
            label7.Text = "Publisher";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 470);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 65;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 261);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 64;
            label5.Text = "Author";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "computer science", "literature", "engineering" });
            comboBox1.Location = new Point(360, 337);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 63;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(360, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 62;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(207, 213);
            label12.Name = "label12";
            label12.Size = new Size(38, 20);
            label12.TabIndex = 60;
            label12.Text = "Title";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(306, 642);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 58;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(542, 70);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 80;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(664, 734);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label12;
        private Button button1;
        private Button button2;
    }
}