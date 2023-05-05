
namespace Gourmet_s_Record
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbDecript = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(93, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 473);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dimension:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.lbWidth);
            this.groupBox1.Controls.Add(this.lbLength);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbArtist);
            this.groupBox1.Controls.Add(this.lbTitle);
            this.groupBox1.Controls.Add(this.tbDecript);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(530, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 419);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(361, 134);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(36, 20);
            this.lbWidth.TabIndex = 14;
            this.lbWidth.Text = "000";
            this.lbWidth.Click += new System.EventHandler(this.lbWidth_Click);
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(223, 134);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(36, 20);
            this.lbLength.TabIndex = 13;
            this.lbLength.Text = "000";
            this.lbLength.Click += new System.EventHandler(this.lbLength_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Width:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(154, 180);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(13, 20);
            this.lbType.TabIndex = 11;
            this.lbType.Text = "/";
            this.lbType.Click += new System.EventHandler(this.lbType_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Length:";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Location = new System.Drawing.Point(154, 89);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(13, 20);
            this.lbArtist.TabIndex = 9;
            this.lbArtist.Text = "/";
            this.lbArtist.Click += new System.EventHandler(this.lbArtist_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(154, 46);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(13, 20);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "/";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // tbDecript
            // 
            this.tbDecript.Location = new System.Drawing.Point(33, 256);
            this.tbDecript.Multiline = true;
            this.tbDecript.Name = "tbDecript";
            this.tbDecript.Size = new System.Drawing.Size(414, 147);
            this.tbDecript.TabIndex = 7;
            this.tbDecript.TextChanged += new System.EventHandler(this.tbDecript_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(29, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Artist:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description:";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.RosyBrown;
            this.btnHome.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(867, 30);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(155, 36);
            this.btnHome.TabIndex = 17;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCancel.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(788, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(191, 36);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOrder.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrder.Location = new System.Drawing.Point(563, 520);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(191, 36);
            this.btnOrder.TabIndex = 18;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1093, 649);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Artwork";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbDecript;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
    }
}