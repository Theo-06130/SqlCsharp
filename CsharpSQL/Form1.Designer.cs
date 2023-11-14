namespace CsharpSQL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.homeToolStripMenuItem, this.genresToolStripMenuItem, this.auteurToolStripMenuItem, this.typesToolStripMenuItem, this.rechargerToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(15, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.genresToolStripMenuItem.Text = "Genres";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.genresToolStripMenuItem_Click);
            // 
            // auteurToolStripMenuItem
            // 
            this.auteurToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.auteurToolStripMenuItem.Name = "auteurToolStripMenuItem";
            this.auteurToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.auteurToolStripMenuItem.Text = "Auteur";
            this.auteurToolStripMenuItem.Click += new System.EventHandler(this.auteurToolStripMenuItem_Click);
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.typesToolStripMenuItem.Text = "Types";
            this.typesToolStripMenuItem.Click += new System.EventHandler(this.typesToolStripMenuItem_Click);
            // 
            // rechargerToolStripMenuItem
            // 
            this.rechargerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rechargerToolStripMenuItem.Name = "rechargerToolStripMenuItem";
            this.rechargerToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.rechargerToolStripMenuItem.Text = "Check Connexion bdd";
            this.rechargerToolStripMenuItem.Click += new System.EventHandler(this.rechargerToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(15);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(770, 407);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechargerToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteurToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;

        #endregion
    }
}

