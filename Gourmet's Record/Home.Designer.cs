
namespace Gourmet_s_Record
{
    partial class Home
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
            this.btSI = new System.Windows.Forms.Button();
            this.btAP = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSI
            // 
            this.btSI.BackColor = System.Drawing.Color.Silver;
            this.btSI.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSI.Location = new System.Drawing.Point(701, 56);
            this.btSI.Name = "btSI";
            this.btSI.Size = new System.Drawing.Size(75, 23);
            this.btSI.TabIndex = 0;
            this.btSI.Text = "Sign Out";
            this.btSI.UseVisualStyleBackColor = false;
            this.btSI.Click += new System.EventHandler(this.btSI_Click);
            // 
            // btAP
            // 
            this.btAP.BackColor = System.Drawing.Color.Silver;
            this.btAP.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAP.Location = new System.Drawing.Point(701, 27);
            this.btAP.Name = "btAP";
            this.btAP.Size = new System.Drawing.Size(75, 23);
            this.btAP.TabIndex = 1;
            this.btAP.Text = "Account";
            this.btAP.UseVisualStyleBackColor = false;
            this.btAP.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(145, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 17);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // btUpload
            // 
            this.btUpload.BackColor = System.Drawing.Color.Silver;
            this.btUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpload.Location = new System.Drawing.Point(701, 403);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(75, 33);
            this.btUpload.TabIndex = 4;
            this.btUpload.Text = "+";
            this.btUpload.UseVisualStyleBackColor = false;
            this.btUpload.Visible = false;
            this.btUpload.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 459);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btAP);
            this.Controls.Add(this.btSI);
            this.Name = "Homepage";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSI;
        private System.Windows.Forms.Button btAP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btUpload;
    }
}