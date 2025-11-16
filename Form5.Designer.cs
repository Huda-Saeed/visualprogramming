namespace lab9b
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            btnAddStudent = new Button();
            label11 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = SystemColors.ActiveCaption;
            btnAddStudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(647, 79);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(94, 45);
            btnAddStudent.TabIndex = 57;
            btnAddStudent.Text = "Search";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Image = (Image)resources.GetObject("label11.Image");
            label11.Location = new Point(319, 28);
            label11.Name = "label11";
            label11.Size = new Size(146, 26);
            label11.TabIndex = 56;
            label11.Text = "View Books";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(422, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 96);
            label1.Name = "label1";
            label1.Size = new Size(333, 20);
            label1.TabIndex = 54;
            label1.Text = "for getting specific book  data only enter BookID";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 286);
            dataGridView1.TabIndex = 58;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddStudent);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudent;
        private Label label11;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}