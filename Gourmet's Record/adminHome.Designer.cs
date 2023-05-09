
namespace Gourmet_s_Record
{
    partial class adminHome
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.msName = new System.Windows.Forms.ToolStripMenuItem();
            this.accountListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chStyle4 = new System.Windows.Forms.CheckBox();
            this.chStyle3 = new System.Windows.Forms.CheckBox();
            this.chStyle2 = new System.Windows.Forms.CheckBox();
            this.chStyle1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPriceRange6 = new System.Windows.Forms.CheckBox();
            this.cbPriceRange5 = new System.Windows.Forms.CheckBox();
            this.cbPriceRange4 = new System.Windows.Forms.CheckBox();
            this.cbPriceRange3 = new System.Windows.Forms.CheckBox();
            this.cbPriceRange2 = new System.Windows.Forms.CheckBox();
            this.cbPriceRange1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msName});
            this.menu.Location = new System.Drawing.Point(688, 19);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(115, 40);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // msName
            // 
            this.msName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountListToolStripMenuItem,
            this.mToolStripMenuItem});
            this.msName.Image = global::Gourmet_s_Record.Properties.Resources.person_4_32;
            this.msName.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msName.Name = "msName";
            this.msName.Size = new System.Drawing.Size(107, 36);
            this.msName.Text = "ACCOUNT";
            // 
            // accountListToolStripMenuItem
            // 
            this.accountListToolStripMenuItem.Name = "accountListToolStripMenuItem";
            this.accountListToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.accountListToolStripMenuItem.Text = "Account List";
            this.accountListToolStripMenuItem.Click += new System.EventHandler(this.accountListToolStripMenuItem_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.mToolStripMenuItem.Text = "Artwork List";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Title",
            "Artist"});
            this.cbFilter.Location = new System.Drawing.Point(3, 9);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.Text = "Search by...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Location = new System.Drawing.Point(57, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 48);
            this.panel1.TabIndex = 2;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSearch.Image = global::Gourmet_s_Record.Properties.Resources.s;
            this.btSearch.Location = new System.Drawing.Point(524, 3);
            this.btSearch.Name = "btSearch";
            this.btSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSearch.Size = new System.Drawing.Size(81, 42);
            this.btSearch.TabIndex = 3;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(132, 10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(386, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(617, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 419);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chStyle4);
            this.groupBox3.Controls.Add(this.chStyle3);
            this.groupBox3.Controls.Add(this.chStyle2);
            this.groupBox3.Controls.Add(this.chStyle1);
            this.groupBox3.Location = new System.Drawing.Point(7, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 216);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Style";
            // 
            // chStyle4
            // 
            this.chStyle4.AutoSize = true;
            this.chStyle4.Location = new System.Drawing.Point(24, 88);
            this.chStyle4.Name = "chStyle4";
            this.chStyle4.Size = new System.Drawing.Size(38, 17);
            this.chStyle4.TabIndex = 3;
            this.chStyle4.Text = "Oil";
            this.chStyle4.UseVisualStyleBackColor = true;
            // 
            // chStyle3
            // 
            this.chStyle3.AutoSize = true;
            this.chStyle3.Location = new System.Drawing.Point(24, 65);
            this.chStyle3.Name = "chStyle3";
            this.chStyle3.Size = new System.Drawing.Size(57, 17);
            this.chStyle3.TabIndex = 2;
            this.chStyle3.Text = "Acrylic";
            this.chStyle3.UseVisualStyleBackColor = true;
            // 
            // chStyle2
            // 
            this.chStyle2.AutoSize = true;
            this.chStyle2.Location = new System.Drawing.Point(24, 42);
            this.chStyle2.Name = "chStyle2";
            this.chStyle2.Size = new System.Drawing.Size(55, 17);
            this.chStyle2.TabIndex = 1;
            this.chStyle2.Text = "Digital";
            this.chStyle2.UseVisualStyleBackColor = true;
            // 
            // chStyle1
            // 
            this.chStyle1.AutoSize = true;
            this.chStyle1.Location = new System.Drawing.Point(24, 19);
            this.chStyle1.Name = "chStyle1";
            this.chStyle1.Size = new System.Drawing.Size(78, 17);
            this.chStyle1.TabIndex = 0;
            this.chStyle1.Text = "Watercolor";
            this.chStyle1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.cbPriceRange6);
            this.groupBox2.Controls.Add(this.cbPriceRange5);
            this.groupBox2.Controls.Add(this.cbPriceRange4);
            this.groupBox2.Controls.Add(this.cbPriceRange3);
            this.groupBox2.Controls.Add(this.cbPriceRange2);
            this.groupBox2.Controls.Add(this.cbPriceRange1);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price";
            // 
            // cbPriceRange6
            // 
            this.cbPriceRange6.AutoSize = true;
            this.cbPriceRange6.Location = new System.Drawing.Point(24, 134);
            this.cbPriceRange6.Name = "cbPriceRange6";
            this.cbPriceRange6.Size = new System.Drawing.Size(105, 17);
            this.cbPriceRange6.TabIndex = 5;
            this.cbPriceRange6.Text = "1000 and Higher";
            this.cbPriceRange6.UseVisualStyleBackColor = true;
            this.cbPriceRange6.CheckedChanged += new System.EventHandler(this.cbPriceRange6_CheckedChanged);
            // 
            // cbPriceRange5
            // 
            this.cbPriceRange5.AutoSize = true;
            this.cbPriceRange5.Location = new System.Drawing.Point(24, 111);
            this.cbPriceRange5.Name = "cbPriceRange5";
            this.cbPriceRange5.Size = new System.Drawing.Size(77, 17);
            this.cbPriceRange5.TabIndex = 4;
            this.cbPriceRange5.Text = "800 - 1000";
            this.cbPriceRange5.UseVisualStyleBackColor = true;
            this.cbPriceRange5.CheckedChanged += new System.EventHandler(this.cbPriceRange5_CheckedChanged);
            // 
            // cbPriceRange4
            // 
            this.cbPriceRange4.AutoSize = true;
            this.cbPriceRange4.Location = new System.Drawing.Point(24, 88);
            this.cbPriceRange4.Name = "cbPriceRange4";
            this.cbPriceRange4.Size = new System.Drawing.Size(71, 17);
            this.cbPriceRange4.TabIndex = 3;
            this.cbPriceRange4.Text = "600 - 800";
            this.cbPriceRange4.UseVisualStyleBackColor = true;
            this.cbPriceRange4.CheckedChanged += new System.EventHandler(this.cbPriceRange4_CheckedChanged);
            // 
            // cbPriceRange3
            // 
            this.cbPriceRange3.AutoSize = true;
            this.cbPriceRange3.Location = new System.Drawing.Point(24, 65);
            this.cbPriceRange3.Name = "cbPriceRange3";
            this.cbPriceRange3.Size = new System.Drawing.Size(71, 17);
            this.cbPriceRange3.TabIndex = 2;
            this.cbPriceRange3.Text = "400 - 600";
            this.cbPriceRange3.UseVisualStyleBackColor = true;
            this.cbPriceRange3.CheckedChanged += new System.EventHandler(this.cbPriceRange3_CheckedChanged);
            // 
            // cbPriceRange2
            // 
            this.cbPriceRange2.AutoSize = true;
            this.cbPriceRange2.Location = new System.Drawing.Point(24, 42);
            this.cbPriceRange2.Name = "cbPriceRange2";
            this.cbPriceRange2.Size = new System.Drawing.Size(71, 17);
            this.cbPriceRange2.TabIndex = 1;
            this.cbPriceRange2.Text = "200 - 400";
            this.cbPriceRange2.UseVisualStyleBackColor = true;
            this.cbPriceRange2.CheckedChanged += new System.EventHandler(this.cbPriceRange2_CheckedChanged);
            // 
            // cbPriceRange1
            // 
            this.cbPriceRange1.AutoSize = true;
            this.cbPriceRange1.Location = new System.Drawing.Point(24, 19);
            this.cbPriceRange1.Name = "cbPriceRange1";
            this.cbPriceRange1.Size = new System.Drawing.Size(62, 17);
            this.cbPriceRange1.TabIndex = 0;
            this.cbPriceRange1.Text = " 0 - 200";
            this.cbPriceRange1.UseVisualStyleBackColor = true;
            this.cbPriceRange1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Image = global::Gourmet_s_Record.Properties.Resources.upload;
            this.button2.Location = new System.Drawing.Point(44, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 56);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // adminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menu;
            this.Name = "adminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem msName;
        private System.Windows.Forms.ToolStripMenuItem accountListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chStyle2;
        private System.Windows.Forms.CheckBox chStyle1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbPriceRange4;
        private System.Windows.Forms.CheckBox cbPriceRange3;
        private System.Windows.Forms.CheckBox cbPriceRange2;
        private System.Windows.Forms.CheckBox cbPriceRange1;
        private System.Windows.Forms.CheckBox chStyle4;
        private System.Windows.Forms.CheckBox chStyle3;
        private System.Windows.Forms.CheckBox cbPriceRange6;
        private System.Windows.Forms.CheckBox cbPriceRange5;
        private System.Windows.Forms.Button button2;
    }
}