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
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.livresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.auteurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testConnexionBDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.miniToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.homeToolStripMenuItem, this.genresToolStripMenuItem, this.auteurToolStripMenuItem, this.livresToolStripMenuItem, this.typesToolStripMenuItem, this.rechargerToolStripMenuItem });
            this.miniToolStrip.Location = new System.Drawing.Point(480, 4);
            this.miniToolStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1106, 28);
            this.miniToolStrip.TabIndex = 0;
            this.miniToolStrip.Visible = false;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
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
            // livresToolStripMenuItem
            // 
            this.livresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.livresToolStripMenuItem.Name = "livresToolStripMenuItem";
            this.livresToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.livresToolStripMenuItem.Text = "Livres";
            this.livresToolStripMenuItem.Click += new System.EventHandler(this.livresToolStripMenuItem_Click_1);
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
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.homeToolStripMenuItem1, this.livresToolStripMenuItem1, this.genresToolStripMenuItem1, this.auteurToolStripMenuItem1, this.typesToolStripMenuItem1, this.testConnexionBDDToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(15, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1106, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // livresToolStripMenuItem1
            // 
            this.livresToolStripMenuItem1.Name = "livresToolStripMenuItem1";
            this.livresToolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.livresToolStripMenuItem1.Text = "Livres";
            // 
            // genresToolStripMenuItem1
            // 
            this.genresToolStripMenuItem1.Name = "genresToolStripMenuItem1";
            this.genresToolStripMenuItem1.Size = new System.Drawing.Size(66, 24);
            this.genresToolStripMenuItem1.Text = "Genres";
            // 
            // auteurToolStripMenuItem1
            // 
            this.auteurToolStripMenuItem1.Name = "auteurToolStripMenuItem1";
            this.auteurToolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.auteurToolStripMenuItem1.Text = "Auteur";
            // 
            // typesToolStripMenuItem1
            // 
            this.typesToolStripMenuItem1.Name = "typesToolStripMenuItem1";
            this.typesToolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.typesToolStripMenuItem1.Text = "Types";
            // 
            // testConnexionBDDToolStripMenuItem
            // 
            this.testConnexionBDDToolStripMenuItem.Name = "testConnexionBDDToolStripMenuItem";
            this.testConnexionBDDToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.testConnexionBDDToolStripMenuItem.Text = "Test Connexion BDD";
            this.testConnexionBDDToolStripMenuItem.Click += new System.EventHandler(this.testConnexionBDDToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1106, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenue sur Biblivres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(26)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1136, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem livresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem auteurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testConnexionBDDToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripMenuItem livresToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechargerToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteurToolStripMenuItem;

        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;

        #endregion
    }
}

