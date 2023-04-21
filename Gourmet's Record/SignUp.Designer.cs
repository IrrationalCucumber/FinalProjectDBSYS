
namespace Gourmet_s_Record
{
    partial class SignUp
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
            this.UptbEnPassword = new System.Windows.Forms.TextBox();
            this.UptbConPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UptbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btSignIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UptbEnPassword
            // 
            this.UptbEnPassword.Location = new System.Drawing.Point(121, 230);
            this.UptbEnPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UptbEnPassword.Name = "UptbEnPassword";
            this.UptbEnPassword.Size = new System.Drawing.Size(436, 26);
            this.UptbEnPassword.TabIndex = 1;
            this.UptbEnPassword.TextChanged += new System.EventHandler(this.UptbEnPassword_TextChanged);
            // 
            // UptbConPass
            // 
            this.UptbConPass.Location = new System.Drawing.Point(121, 321);
            this.UptbConPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UptbConPass.Name = "UptbConPass";
            this.UptbConPass.Size = new System.Drawing.Size(436, 26);
            this.UptbConPass.TabIndex = 2;
            this.UptbConPass.TextChanged += new System.EventHandler(this.UptbConPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(80, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(80, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Your Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(80, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UptbUsername
            // 
            this.UptbUsername.Location = new System.Drawing.Point(121, 138);
            this.UptbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UptbUsername.Name = "UptbUsername";
            this.UptbUsername.Size = new System.Drawing.Size(436, 26);
            this.UptbUsername.TabIndex = 7;
            this.UptbUsername.TextChanged += new System.EventHandler(this.UptbUsername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sign Up";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(262, 373);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(120, 20);
            this.lbMessage.TabIndex = 10;
            this.lbMessage.Text = "Error message";
            this.lbMessage.Click += new System.EventHandler(this.lbMessage_Click);
            // 
            // btSignIn
            // 
            this.btSignIn.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.btSignIn.Location = new System.Drawing.Point(202, 407);
            this.btSignIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(262, 35);
            this.btSignIn.TabIndex = 11;
            this.btSignIn.Text = "Sign Up";
            this.btSignIn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(198, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Already have an Account?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(398, 460);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign In";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 511);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UptbUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UptbConPass);
            this.Controls.Add(this.UptbEnPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UptbEnPassword;
        private System.Windows.Forms.TextBox UptbConPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UptbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}