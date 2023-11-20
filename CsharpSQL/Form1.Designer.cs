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
            this.livresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Groupe_livre = new System.Windows.Forms.GroupBox();
            this.Price = new System.Windows.Forms.Label();
            this.Name_types = new System.Windows.Forms.Label();
            this.Name_genre = new System.Windows.Forms.Label();
            this.Name_author = new System.Windows.Forms.Label();
            this.Name_book = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Groupe_livre.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.homeToolStripMenuItem, this.genresToolStripMenuItem, this.auteurToolStripMenuItem, this.livresToolStripMenuItem, this.typesToolStripMenuItem, this.rechargerToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(15, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 28);
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
            this.rechargerToolStripMenuItem.Click += new System.EventHandler(this.rechargerToolStripMenuItem_Click);
            // 
            // Groupe_livre
            // 
            this.Groupe_livre.BackColor = System.Drawing.Color.Transparent;
            this.Groupe_livre.Controls.Add(this.Price);
            this.Groupe_livre.Controls.Add(this.Name_types);
            this.Groupe_livre.Controls.Add(this.Name_genre);
            this.Groupe_livre.Controls.Add(this.Name_author);
            this.Groupe_livre.Controls.Add(this.Name_book);
            this.Groupe_livre.Location = new System.Drawing.Point(38, 46);
            this.Groupe_livre.Name = "Groupe_livre";
            this.Groupe_livre.Size = new System.Drawing.Size(180, 278);
            this.Groupe_livre.TabIndex = 1;
            this.Groupe_livre.TabStop = false;
            // 
            // Price
            // 
            this.Price.Dock = System.Windows.Forms.DockStyle.Top;
            this.Price.ForeColor = System.Drawing.Color.White;
            this.Price.Location = new System.Drawing.Point(3, 218);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(174, 50);
            this.Price.TabIndex = 4;
            this.Price.Text = "label1";
            // 
            // Name_types
            // 
            this.Name_types.Dock = System.Windows.Forms.DockStyle.Top;
            this.Name_types.ForeColor = System.Drawing.Color.White;
            this.Name_types.Location = new System.Drawing.Point(3, 168);
            this.Name_types.Name = "Name_types";
            this.Name_types.Size = new System.Drawing.Size(174, 50);
            this.Name_types.TabIndex = 3;
            this.Name_types.Text = "label1";
            // 
            // Name_genre
            // 
            this.Name_genre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Name_genre.ForeColor = System.Drawing.Color.White;
            this.Name_genre.Location = new System.Drawing.Point(3, 118);
            this.Name_genre.Name = "Name_genre";
            this.Name_genre.Size = new System.Drawing.Size(174, 50);
            this.Name_genre.TabIndex = 2;
            this.Name_genre.Text = "label1";
            // 
            // Name_author
            // 
            this.Name_author.Dock = System.Windows.Forms.DockStyle.Top;
            this.Name_author.ForeColor = System.Drawing.Color.White;
            this.Name_author.Location = new System.Drawing.Point(3, 68);
            this.Name_author.Name = "Name_author";
            this.Name_author.Size = new System.Drawing.Size(174, 50);
            this.Name_author.TabIndex = 1;
            this.Name_author.Text = "label1";
            // 
            // Name_book
            // 
            this.Name_book.Dock = System.Windows.Forms.DockStyle.Top;
            this.Name_book.ForeColor = System.Drawing.Color.White;
            this.Name_book.Location = new System.Drawing.Point(3, 18);
            this.Name_book.Name = "Name_book";
            this.Name_book.Size = new System.Drawing.Size(174, 50);
            this.Name_book.TabIndex = 0;
            this.Name_book.Text = "label1";
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
            this.Controls.Add(this.Groupe_livre);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Groupe_livre.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label Name_book;
        private System.Windows.Forms.Label Name_author;
        private System.Windows.Forms.Label Name_genre;
        private System.Windows.Forms.Label Name_types;
        private System.Windows.Forms.Label Price;

        private System.Windows.Forms.GroupBox Groupe_livre;

        private System.Windows.Forms.ToolStripMenuItem livresToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechargerToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteurToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;

        #endregion
    }
}

