namespace Gourmet_s_Record
{
    partial class AdminHome
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.msName = new System.Windows.Forms.ToolStripMenuItem();
            this.accountListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(924, 544);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gourmet_s_Record.Properties.Resources.Untitled18_20221019160221;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(965, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(294, 395);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.cbStyle);
            this.groupBox3.Location = new System.Drawing.Point(10, 295);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(274, 79);
            this.groupBox3.TabIndex = 18;
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
            this.cbStyle.Location = new System.Drawing.Point(16, 27);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(242, 28);
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
            this.groupBox2.Location = new System.Drawing.Point(10, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(274, 243);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price";
            // 
            // cbPriceRange6
            // 
            this.cbPriceRange6.AutoSize = true;
            this.cbPriceRange6.Location = new System.Drawing.Point(36, 206);
            this.cbPriceRange6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPriceRange6.Name = "cbPriceRange6";
            this.cbPriceRange6.Size = new System.Drawing.Size(153, 24);
            this.cbPriceRange6.TabIndex = 5;
            this.cbPriceRange6.Text = "1000 and Higher";
            this.cbPriceRange6.UseVisualStyleBackColor = true;
            this.cbPriceRange6.CheckedChanged += new System.EventHandler(this.cbPriceRange6_CheckedChanged);
            // 
            // cbPriceRange5
            // 
            this.cbPriceRange5.AutoSize = true;
            this.cbPriceRange5.Location = new System.Drawing.Point(36, 171);
            this.cbPriceRange5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPriceRange5.Name = "cbPriceRange5";
            this.cbPriceRange5.Size = new System.Drawing.Size(111, 24);
            this.cbPriceRange5.TabIndex = 4;
            this.cbPriceRange5.Text = "800 - 1000";
            this.cbPriceRange5.UseVisualStyleBackColor = true;
            this.cbPriceRange5.CheckedChanged += new System.EventHandler(this.cbPriceRange5_CheckedChanged);
            // 
            // cbPriceRange4
            // 
            this.cbPriceRange4.AutoSize = true;
            this.cbPriceRange4.Location = new System.Drawing.Point(36, 135);
            this.cbPriceRange4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPriceRange4.Name = "cbPriceRange4";
            this.cbPriceRange4.Size = new System.Drawing.Size(102, 24);
            this.cbPriceRange4.TabIndex = 3;
            this.cbPriceRange4.Text = "600 - 800";
            this.cbPriceRange4.UseVisualStyleBackColor = true;
            this.cbPriceRange4.CheckedChanged += new System.EventHandler(this.cbPriceRange4_CheckedChanged);
            // 
            // cbPriceRange3
            // 
            this.cbPriceRange3.AutoSize = true;
            this.cbPriceRange3.Location = new System.Drawing.Point(36, 100);
            this.cbPriceRange3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPriceRange3.Name = "cbPriceRange3";
            this.cbPriceRange3.Size = new System.Drawing.Size(102, 24);
            this.cbPriceRange3.TabIndex = 2;
            this.cbPriceRange3.Text = "400 - 600";
            this.cbPriceRange3.UseVisualStyleBackColor = true;
            this.cbPriceRange3.CheckedChanged += new System.EventHandler(this.cbPriceRange3_CheckedChanged);
            // 
            // cbPriceRange2
            // 
            this.cbPriceRange2.AutoSize = true;
            this.cbPriceRange2.Location = new System.Drawing.Point(36, 65);
            this.cbPriceRange2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPriceRange2.Name = "cbPriceRange2";
            this.cbPriceRange2.Size = new System.Drawing.Size(102, 24);
            this.cbPriceRange2.TabIndex = 1;
            this.cbPriceRange2.Text = "200 - 400";
            this.cbPriceRange2.UseVisualStyleBackColor = true;
            this.cbPriceRange2.CheckedChanged += new System.EventHandler(this.cbPriceRange2_CheckedChanged);
            // 
            // cbPriceRange1
            // 
            this.cbPriceRange1.AutoSize = true;
            this.cbPriceRange1.Location = new System.Drawing.Point(36, 29);
            this.cbPriceRange1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPriceRange1.Name = "cbPriceRange1";
            this.cbPriceRange1.Size = new System.Drawing.Size(88, 24);
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
            this.panel1.Location = new System.Drawing.Point(123, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 83);
            this.panel1.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSearch.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(813, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(202, 31);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(602, 26);
            this.tbSearch.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Title",
            "Artist"});
            this.cbFilter.Location = new System.Drawing.Point(14, 29);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(180, 27);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.Text = "Search by...";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.RosyBrown;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msName});
            this.menu.Location = new System.Drawing.Point(1082, 33);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(150, 42);
            this.menu.TabIndex = 17;
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
            this.msName.Size = new System.Drawing.Size(142, 36);
            this.msName.Text = "ACCOUNT";
            // 
            // accountListToolStripMenuItem
            // 
            this.accountListToolStripMenuItem.Name = "accountListToolStripMenuItem";
            this.accountListToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.accountListToolStripMenuItem.Text = "Account List";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.mToolStripMenuItem.Text = "Artwork List";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1283, 692);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbPriceRange6;
        private System.Windows.Forms.CheckBox cbPriceRange5;
        private System.Windows.Forms.CheckBox cbPriceRange4;
        private System.Windows.Forms.CheckBox cbPriceRange3;
        private System.Windows.Forms.CheckBox cbPriceRange2;
        private System.Windows.Forms.CheckBox cbPriceRange1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem msName;
        private System.Windows.Forms.ToolStripMenuItem accountListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbStyle;
    }
}