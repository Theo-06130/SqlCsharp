using System.ComponentModel;

namespace CsharpSQL
{
    partial class FormTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.block_livre = new System.Windows.Forms.Panel();
            this.Gender_book = new System.Windows.Forms.Label();
            this.Lang_book = new System.Windows.Forms.Label();
            this.Author_book = new System.Windows.Forms.Label();
            this.name_book = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.block_livre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.block_livre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 320);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // block_livre
            // 
            this.block_livre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.block_livre.Controls.Add(this.Gender_book);
            this.block_livre.Controls.Add(this.Lang_book);
            this.block_livre.Controls.Add(this.Author_book);
            this.block_livre.Controls.Add(this.name_book);
            this.block_livre.Location = new System.Drawing.Point(20, 19);
            this.block_livre.Name = "block_livre";
            this.block_livre.Size = new System.Drawing.Size(200, 230);
            this.block_livre.TabIndex = 1;
            this.block_livre.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Gender_book
            // 
            this.Gender_book.Location = new System.Drawing.Point(14, 205);
            this.Gender_book.Name = "Gender_book";
            this.Gender_book.Size = new System.Drawing.Size(65, 16);
            this.Gender_book.TabIndex = 3;
            this.Gender_book.Text = "Genres";
            // 
            // Lang_book
            // 
            this.Lang_book.Location = new System.Drawing.Point(131, 12);
            this.Lang_book.Name = "Lang_book";
            this.Lang_book.Size = new System.Drawing.Size(66, 21);
            this.Lang_book.TabIndex = 2;
            this.Lang_book.Text = "Langue";
            // 
            // Author_book
            // 
            this.Author_book.Location = new System.Drawing.Point(14, 31);
            this.Author_book.Name = "Author_book";
            this.Author_book.Size = new System.Drawing.Size(89, 20);
            this.Author_book.TabIndex = 1;
            this.Author_book.Text = "Nom_Auteur";
            // 
            // name_book
            // 
            this.name_book.Location = new System.Drawing.Point(14, 12);
            this.name_book.Name = "name_book";
            this.name_book.Size = new System.Drawing.Size(75, 19);
            this.name_book.TabIndex = 0;
            this.name_book.Text = "Nom_livre";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.panel1);
            this.Name = "FormTest";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "FormTest";
            this.panel1.ResumeLayout(false);
            this.block_livre.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label Gender_book;

        private System.Windows.Forms.Label Author_book;
        private System.Windows.Forms.Label Lang_book;

        private System.Windows.Forms.Panel block_livre;

        private System.Windows.Forms.Label name_book;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}