
namespace Gourmet_s_Record
{
    partial class General_Home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPriceRange6 = new System.Windows.Forms.CheckBox();
            this.cbPriceRange5 = new System.Windows.Forms.CheckBox();
            this.cbPriceRange4 = new System.Windows.Forms.CheckBox();
            this.cbPriceRange3 = new System.Windows.Forms.CheckBox();
            this.cbPriceRange2 = new System.Windows.Forms.CheckBox();
            this.cbPriceRange1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.msName = new System.Windows.Forms.ToolStripMenuItem();
            this.miProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSO = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(643, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 257);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.cbStyle);
            this.groupBox3.Location = new System.Drawing.Point(5, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 51);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Style";
            // 
            // cbStyle
            // 
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "Watercolor painting",
            "Acrylic painting",
            "Oil painting",
            "Spray painting",
            "Sculpture",
            "Digital Art"});
            this.cbStyle.Location = new System.Drawing.Point(11, 18);
            this.cbStyle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(163, 21);
            this.cbStyle.TabIndex = 0;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
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
            this.cbPriceRange1.CheckedChanged += new System.EventHandler(this.cbPriceRange1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Location = new System.Drawing.Point(93, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 55);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSearch.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(542, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(135, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(403, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Title",
            "Artist"});
            this.cbFilter.Location = new System.Drawing.Point(9, 19);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.Text = "Search by...";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gourmet_s_Record.Properties.Resources.Untitled18_20221019160221;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 56);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(616, 354);
            this.dataGridView1.TabIndex = 10;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.RosyBrown;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msName});
            this.menu.Location = new System.Drawing.Point(733, 27);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(233, 40);
            this.menu.TabIndex = 11;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // msName
            // 
            this.msName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProfile,
            this.miSO});
            this.msName.Image = global::Gourmet_s_Record.Properties.Resources.person_4_32;
            this.msName.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msName.Name = "msName";
            this.msName.Size = new System.Drawing.Size(107, 36);
            this.msName.Text = "ACCOUNT";
            // 
            // miProfile
            // 
            this.miProfile.Name = "miProfile";
            this.miProfile.Size = new System.Drawing.Size(180, 22);
            this.miProfile.Text = "Profile";
            this.miProfile.Click += new System.EventHandler(this.accountListToolStripMenuItem_Click);
            // 
            // miSO
            // 
            this.miSO.Name = "miSO";
            this.miSO.Size = new System.Drawing.Size(180, 22);
            this.miSO.Text = "Sign Out";
            this.miSO.Click += new System.EventHandler(this.miSO_Click);
            // 
            // General_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "General_Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.General_Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbPriceRange6;
        private System.Windows.Forms.CheckBox cbPriceRange5;
        private System.Windows.Forms.CheckBox cbPriceRange4;
        private System.Windows.Forms.CheckBox cbPriceRange3;
        private System.Windows.Forms.CheckBox cbPriceRange2;
        private System.Windows.Forms.CheckBox cbPriceRange1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem msName;
        private System.Windows.Forms.ToolStripMenuItem miProfile;
        private System.Windows.Forms.ToolStripMenuItem miSO;
    }
}