namespace lab9b
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label11 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btnAddStudent = new Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Image = (Image)resources.GetObject("label11.Image");
            label11.Location = new Point(323, 76);
            label11.Name = "label11";
            label11.Size = new Size(157, 26);
            label11.TabIndex = 52;
            label11.Text = "Delete Book";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(378, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 149);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 50;
            label1.Text = "BookID";
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = SystemColors.ActiveCaption;
            btnAddStudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(332, 208);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(94, 45);
            btnAddStudent.TabIndex = 53;
            btnAddStudent.Text = "Delete";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddStudent);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form4";
            Text = "delete form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private TextBox textBox1;
        private Label label1;
        private Button btnAddStudent;
    }
}