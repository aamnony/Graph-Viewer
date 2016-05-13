namespace Graph_Viewer
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.scrlbar = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbDecode = new System.Windows.Forms.ToolStripComboBox();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.miBytesShown = new System.Windows.Forms.ToolStripMenuItem();
            this.txtByteShown = new System.Windows.Forms.ToolStripTextBox();
            this.qualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbQuality = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 28);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(947, 361);
            this.chart1.TabIndex = 0;
            this.chart1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // scrlbar
            // 
            this.scrlbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scrlbar.LargeChange = 500;
            this.scrlbar.Location = new System.Drawing.Point(0, 368);
            this.scrlbar.Maximum = 1000;
            this.scrlbar.Name = "scrlbar";
            this.scrlbar.Size = new System.Drawing.Size(947, 21);
            this.scrlbar.SmallChange = 100;
            this.scrlbar.TabIndex = 1;
            this.scrlbar.Visible = false;
            this.scrlbar.ValueChanged += new System.EventHandler(this.scrlbar_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.editToolStripMenuItem,
            this.miView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(44, 24);
            this.miFile.Text = "File";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(176, 24);
            this.miOpen.Text = "Open...";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.miExit.Size = new System.Drawing.Size(176, 24);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decodingToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // decodingToolStripMenuItem
            // 
            this.decodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbDecode});
            this.decodingToolStripMenuItem.Name = "decodingToolStripMenuItem";
            this.decodingToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.decodingToolStripMenuItem.Text = "Decoding";
            // 
            // cmbDecode
            // 
            this.cmbDecode.Items.AddRange(new object[] {
            "Big Endian",
            "Little Endian"});
            this.cmbDecode.Name = "cmbDecode";
            this.cmbDecode.Size = new System.Drawing.Size(121, 28);
            this.cmbDecode.SelectedIndexChanged += new System.EventHandler(this.cmbDecode_SelectedIndexChanged);
            // 
            // miView
            // 
            this.miView.AutoToolTip = true;
            this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBytesShown,
            this.qualityToolStripMenuItem});
            this.miView.Enabled = false;
            this.miView.Name = "miView";
            this.miView.Size = new System.Drawing.Size(53, 24);
            this.miView.Text = "View";
            // 
            // miBytesShown
            // 
            this.miBytesShown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtByteShown});
            this.miBytesShown.Name = "miBytesShown";
            this.miBytesShown.Size = new System.Drawing.Size(161, 24);
            this.miBytesShown.Text = "Bytes Shown";
            // 
            // txtByteShown
            // 
            this.txtByteShown.Name = "txtByteShown";
            this.txtByteShown.Size = new System.Drawing.Size(100, 27);
            this.txtByteShown.Text = "100";
            this.txtByteShown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtByteShown_KeyPress);
            this.txtByteShown.TextChanged += new System.EventHandler(this.txtByteShown_TextChanged);
            // 
            // qualityToolStripMenuItem
            // 
            this.qualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbQuality});
            this.qualityToolStripMenuItem.Name = "qualityToolStripMenuItem";
            this.qualityToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.qualityToolStripMenuItem.Text = "Quality";
            // 
            // cmbQuality
            // 
            this.cmbQuality.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(121, 28);
            this.cmbQuality.SelectedIndexChanged += new System.EventHandler(this.cmbQuality_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 389);
            this.Controls.Add(this.scrlbar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Graph Viewer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.HScrollBar scrlbar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem miBytesShown;
        private System.Windows.Forms.ToolStripTextBox txtByteShown;
        private System.Windows.Forms.ToolStripMenuItem qualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbQuality;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbDecode;
    }
}

