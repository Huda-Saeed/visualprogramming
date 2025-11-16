namespace lab9b
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            menuStrip1 = new MenuStrip();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            deleteBookToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            updateBookToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MediumOrchid;
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, deleteBookToolStripMenuItem, viewBooksToolStripMenuItem, updateBookToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(110, 29);
            addBookToolStripMenuItem.Text = "Add Book";
            addBookToolStripMenuItem.Click += addBookToolStripMenuItem_Click;
            // 
            // deleteBookToolStripMenuItem
            // 
            deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            deleteBookToolStripMenuItem.Size = new Size(130, 29);
            deleteBookToolStripMenuItem.Text = "Delete Book";
            deleteBookToolStripMenuItem.Click += deleteBookToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(124, 29);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // updateBookToolStripMenuItem
            // 
            updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            updateBookToolStripMenuItem.Size = new Size(137, 29);
            updateBookToolStripMenuItem.Text = "Update Book";
            updateBookToolStripMenuItem.Click += updateBookToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(86, 29);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonFace;
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem deleteBookToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem updateBookToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}