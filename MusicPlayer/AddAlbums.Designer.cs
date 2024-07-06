namespace MusicPlayer
{
    partial class AddAlbums
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_albumName = new System.Windows.Forms.TextBox();
            this.txt_artist = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_imageURL = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ImageURL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // txt_albumName
            // 
            this.txt_albumName.Location = new System.Drawing.Point(150, 101);
            this.txt_albumName.Name = "txt_albumName";
            this.txt_albumName.Size = new System.Drawing.Size(334, 22);
            this.txt_albumName.TabIndex = 5;
            // 
            // txt_artist
            // 
            this.txt_artist.Location = new System.Drawing.Point(150, 151);
            this.txt_artist.Name = "txt_artist";
            this.txt_artist.Size = new System.Drawing.Size(334, 22);
            this.txt_artist.TabIndex = 6;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(150, 205);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(334, 22);
            this.txt_year.TabIndex = 7;
            this.txt_year.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_imageURL
            // 
            this.txt_imageURL.Location = new System.Drawing.Point(150, 268);
            this.txt_imageURL.Name = "txt_imageURL";
            this.txt_imageURL.Size = new System.Drawing.Size(334, 22);
            this.txt_imageURL.TabIndex = 8;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(150, 322);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(334, 22);
            this.txt_description.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_imageURL);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_artist);
            this.Controls.Add(this.txt_albumName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAlbums";
            this.Text = "AddAlbums";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_albumName;
        private System.Windows.Forms.TextBox txt_artist;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_imageURL;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Button button1;
    }
}