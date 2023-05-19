namespace Gourmet_s_Record
{
    partial class Artist_Upload_Artwork
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
            this.tbArtTitle = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.emImage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBArtType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(553, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(554, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dimension:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(553, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(554, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbArtTitle
            // 
            this.tbArtTitle.Location = new System.Drawing.Point(696, 89);
            this.tbArtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArtTitle.Name = "tbArtTitle";
            this.tbArtTitle.Size = new System.Drawing.Size(376, 22);
            this.tbArtTitle.TabIndex = 5;
            this.tbArtTitle.TextChanged += new System.EventHandler(this.tbArtTitle_TextChanged);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(760, 138);
            this.tbWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(113, 22);
            this.tbWidth.TabIndex = 6;
            this.tbWidth.TextChanged += new System.EventHandler(this.tbWidth_TextChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(695, 301);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(377, 172);
            this.tbDescription.TabIndex = 8;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // emImage
            // 
            this.emImage.AutoSize = true;
            this.emImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.emImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emImage.Location = new System.Drawing.Point(90, 515);
            this.emImage.Name = "emImage";
            this.emImage.Size = new System.Drawing.Size(101, 17);
            this.emImage.TabIndex = 9;
            this.emImage.Text = "Error Message";
            this.emImage.Click += new System.EventHandler(this.emImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(702, 494);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCancel.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(902, 494);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(959, 138);
            this.tbLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(113, 22);
            this.tbLength.TabIndex = 12;
            this.tbLength.TextChanged += new System.EventHandler(this.tbLength_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Width";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(901, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Length";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CBArtType
            // 
            this.CBArtType.FormattingEnabled = true;
            this.CBArtType.Items.AddRange(new object[] {
            "Acrylic Painting",
            "Oil Painting",
            "Watercolor Painting",
            "Spray Painting",
            "Sculpture",
            "Digital Art"});
            this.CBArtType.Location = new System.Drawing.Point(696, 197);
            this.CBArtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBArtType.Name = "CBArtType";
            this.CBArtType.Size = new System.Drawing.Size(376, 24);
            this.CBArtType.TabIndex = 15;
            this.CBArtType.SelectedIndexChanged += new System.EventHandler(this.CBArtType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(554, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(697, 249);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(376, 22);
            this.tbPrice.TabIndex = 18;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Gourmet_s_Record.Properties.Resources.download3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(477, 90);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 407);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Gourmet_s_Record.Properties.Resources.download3;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(29, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 407);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Gourmet_s_Record.Properties.Resources.kindpng_822748;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(29, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 38);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(93, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 407);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Artist_Upload_Artwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 576);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBArtType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.emImage);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbArtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Artist_Upload_Artwork";
            this.Text = "Artwork Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbArtTitle;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label emImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBArtType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}