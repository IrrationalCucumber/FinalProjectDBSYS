namespace Gourmet_s_Record
{
    partial class Update_Password
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.tbNewPassword2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNewPassword1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsernameMessage = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.btCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancel.Location = new System.Drawing.Point(210, 450);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(173, 28);
            this.btCancel.TabIndex = 35;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btSubmit
            // 
            this.btSubmit.BackColor = System.Drawing.Color.RosyBrown;
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSubmit.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.btSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSubmit.Location = new System.Drawing.Point(210, 406);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(173, 28);
            this.btSubmit.TabIndex = 34;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = false;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbNewPassword2
            // 
            this.tbNewPassword2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbNewPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword2.Location = new System.Drawing.Point(116, 337);
            this.tbNewPassword2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewPassword2.Name = "tbNewPassword2";
            this.tbNewPassword2.Size = new System.Drawing.Size(365, 23);
            this.tbNewPassword2.TabIndex = 33;
            this.tbNewPassword2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(113, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Confirm Password";
            // 
            // tbNewPassword1
            // 
            this.tbNewPassword1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbNewPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword1.Location = new System.Drawing.Point(116, 268);
            this.tbNewPassword1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewPassword1.Name = "tbNewPassword1";
            this.tbNewPassword1.Size = new System.Drawing.Size(365, 23);
            this.tbNewPassword1.TabIndex = 31;
            this.tbNewPassword1.UseSystemPasswordChar = true;
            this.tbNewPassword1.TextChanged += new System.EventHandler(this.tbNewPassword1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(113, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "New Password";
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPassword.Location = new System.Drawing.Point(116, 201);
            this.tbOldPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(365, 23);
            this.tbOldPassword.TabIndex = 29;
            this.tbOldPassword.UseSystemPasswordChar = true;
            this.tbOldPassword.TextChanged += new System.EventHandler(this.tbOldPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(113, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Old Password";
            // 
            // lbUsernameMessage
            // 
            this.lbUsernameMessage.AutoSize = true;
            this.lbUsernameMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameMessage.ForeColor = System.Drawing.Color.Red;
            this.lbUsernameMessage.Location = new System.Drawing.Point(244, 375);
            this.lbUsernameMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsernameMessage.Name = "lbUsernameMessage";
            this.lbUsernameMessage.Size = new System.Drawing.Size(101, 17);
            this.lbUsernameMessage.TabIndex = 27;
            this.lbUsernameMessage.Text = "Error Message";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(116, 134);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(365, 23);
            this.tbUsername.TabIndex = 26;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(113, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(162, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "UPDATE ACCOUNT";
            // 
            // Update_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gourmet_s_Record.Properties.Resources.download2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 537);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbNewPassword2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNewPassword1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUsernameMessage);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Update_Password";
            this.Text = "UpdatePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.TextBox tbNewPassword2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNewPassword1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUsernameMessage;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}