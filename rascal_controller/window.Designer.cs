namespace rascal_controller
{
    partial class window
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.databaseTabPage1 = new System.Windows.Forms.TabPage();
            this.serverGroupBox1 = new System.Windows.Forms.GroupBox();
            this.pingLog_rtxt1 = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.clientDisconnect_txt1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clientConnectURL_txt1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminDisconnectURL_txt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminConnectURL_txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.remoteUrlBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.serverPing_btn1 = new System.Windows.Forms.ToolStripButton();
            this.clientsGroupBox1 = new System.Windows.Forms.GroupBox();
            this.clientsListBox1 = new System.Windows.Forms.ListBox();
            this.clientsToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.clientsReload_btn1 = new System.Windows.Forms.ToolStripButton();
            this.clientsAdd_btn1 = new System.Windows.Forms.ToolStripButton();
            this.clientsRemove_btn1 = new System.Windows.Forms.ToolStripButton();
            this.clientsEdit_btn1 = new System.Windows.Forms.ToolStripButton();
            this.adminsGroupBox1 = new System.Windows.Forms.GroupBox();
            this.adminsListBox1 = new System.Windows.Forms.ListBox();
            this.adminsToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.adminsReload_btn1 = new System.Windows.Forms.ToolStripButton();
            this.adminsAdd_btn1 = new System.Windows.Forms.ToolStripButton();
            this.adminsRemove_btn1 = new System.Windows.Forms.ToolStripButton();
            this.adminsEdit_btn1 = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mainTabControl.SuspendLayout();
            this.databaseTabPage1.SuspendLayout();
            this.serverGroupBox1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.clientsGroupBox1.SuspendLayout();
            this.clientsToolStrip1.SuspendLayout();
            this.adminsGroupBox1.SuspendLayout();
            this.adminsToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.databaseTabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 450);
            this.mainTabControl.TabIndex = 0;
            // 
            // databaseTabPage1
            // 
            this.databaseTabPage1.Controls.Add(this.serverGroupBox1);
            this.databaseTabPage1.Controls.Add(this.clientsGroupBox1);
            this.databaseTabPage1.Controls.Add(this.adminsGroupBox1);
            this.databaseTabPage1.Location = new System.Drawing.Point(4, 22);
            this.databaseTabPage1.Name = "databaseTabPage1";
            this.databaseTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.databaseTabPage1.Size = new System.Drawing.Size(792, 424);
            this.databaseTabPage1.TabIndex = 0;
            this.databaseTabPage1.Text = "Database";
            this.databaseTabPage1.UseVisualStyleBackColor = true;
            // 
            // serverGroupBox1
            // 
            this.serverGroupBox1.Controls.Add(this.pingLog_rtxt1);
            this.serverGroupBox1.Controls.Add(this.splitter2);
            this.serverGroupBox1.Controls.Add(this.clientDisconnect_txt1);
            this.serverGroupBox1.Controls.Add(this.label5);
            this.serverGroupBox1.Controls.Add(this.clientConnectURL_txt1);
            this.serverGroupBox1.Controls.Add(this.label4);
            this.serverGroupBox1.Controls.Add(this.adminDisconnectURL_txt1);
            this.serverGroupBox1.Controls.Add(this.label3);
            this.serverGroupBox1.Controls.Add(this.adminConnectURL_txt1);
            this.serverGroupBox1.Controls.Add(this.label2);
            this.serverGroupBox1.Controls.Add(this.splitter1);
            this.serverGroupBox1.Controls.Add(this.remoteUrlBox1);
            this.serverGroupBox1.Controls.Add(this.label1);
            this.serverGroupBox1.Controls.Add(this.toolStrip3);
            this.serverGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.serverGroupBox1.Location = new System.Drawing.Point(403, 3);
            this.serverGroupBox1.Name = "serverGroupBox1";
            this.serverGroupBox1.Size = new System.Drawing.Size(200, 418);
            this.serverGroupBox1.TabIndex = 2;
            this.serverGroupBox1.TabStop = false;
            this.serverGroupBox1.Text = "Server";
            // 
            // pingLog_rtxt1
            // 
            this.pingLog_rtxt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pingLog_rtxt1.Location = new System.Drawing.Point(3, 212);
            this.pingLog_rtxt1.Name = "pingLog_rtxt1";
            this.pingLog_rtxt1.Size = new System.Drawing.Size(194, 203);
            this.pingLog_rtxt1.TabIndex = 13;
            this.pingLog_rtxt1.Text = "";
            this.pingLog_rtxt1.WordWrap = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(3, 209);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(194, 3);
            this.splitter2.TabIndex = 12;
            this.splitter2.TabStop = false;
            // 
            // clientDisconnect_txt1
            // 
            this.clientDisconnect_txt1.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientDisconnect_txt1.Location = new System.Drawing.Point(3, 189);
            this.clientDisconnect_txt1.Name = "clientDisconnect_txt1";
            this.clientDisconnect_txt1.Size = new System.Drawing.Size(194, 20);
            this.clientDisconnect_txt1.TabIndex = 11;
            this.clientDisconnect_txt1.Text = "client/<ip>/disconnect";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client disconnect sub-URL";
            // 
            // clientConnectURL_txt1
            // 
            this.clientConnectURL_txt1.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientConnectURL_txt1.Location = new System.Drawing.Point(3, 156);
            this.clientConnectURL_txt1.Name = "clientConnectURL_txt1";
            this.clientConnectURL_txt1.Size = new System.Drawing.Size(194, 20);
            this.clientConnectURL_txt1.TabIndex = 9;
            this.clientConnectURL_txt1.Text = "client/<ip>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Client connect sub-URL";
            // 
            // adminDisconnectURL_txt1
            // 
            this.adminDisconnectURL_txt1.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminDisconnectURL_txt1.Location = new System.Drawing.Point(3, 123);
            this.adminDisconnectURL_txt1.Name = "adminDisconnectURL_txt1";
            this.adminDisconnectURL_txt1.Size = new System.Drawing.Size(194, 20);
            this.adminDisconnectURL_txt1.TabIndex = 7;
            this.adminDisconnectURL_txt1.Text = "admin/<ip>/disconnect";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Admin disconnect sub-URL";
            // 
            // adminConnectURL_txt1
            // 
            this.adminConnectURL_txt1.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminConnectURL_txt1.Location = new System.Drawing.Point(3, 90);
            this.adminConnectURL_txt1.Name = "adminConnectURL_txt1";
            this.adminConnectURL_txt1.Size = new System.Drawing.Size(194, 20);
            this.adminConnectURL_txt1.TabIndex = 5;
            this.adminConnectURL_txt1.Text = "admin/<ip>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin connect sub-URL";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 74);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(194, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // remoteUrlBox1
            // 
            this.remoteUrlBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.remoteUrlBox1.Location = new System.Drawing.Point(3, 54);
            this.remoteUrlBox1.Name = "remoteUrlBox1";
            this.remoteUrlBox1.Size = new System.Drawing.Size(194, 20);
            this.remoteUrlBox1.TabIndex = 2;
            this.remoteUrlBox1.Text = "https://ee0rk.pythonanywhere.com/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remote URL:";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverPing_btn1});
            this.toolStrip3.Location = new System.Drawing.Point(3, 16);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(194, 25);
            this.toolStrip3.Stretch = true;
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // serverPing_btn1
            // 
            this.serverPing_btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.serverPing_btn1.Image = ((System.Drawing.Image)(resources.GetObject("serverPing_btn1.Image")));
            this.serverPing_btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.serverPing_btn1.Name = "serverPing_btn1";
            this.serverPing_btn1.Size = new System.Drawing.Size(35, 22);
            this.serverPing_btn1.Text = "Ping";
            this.serverPing_btn1.Click += new System.EventHandler(this.serverPing_btn1_Click);
            // 
            // clientsGroupBox1
            // 
            this.clientsGroupBox1.Controls.Add(this.clientsListBox1);
            this.clientsGroupBox1.Controls.Add(this.clientsToolStrip1);
            this.clientsGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientsGroupBox1.Location = new System.Drawing.Point(203, 3);
            this.clientsGroupBox1.Name = "clientsGroupBox1";
            this.clientsGroupBox1.Size = new System.Drawing.Size(200, 418);
            this.clientsGroupBox1.TabIndex = 1;
            this.clientsGroupBox1.TabStop = false;
            this.clientsGroupBox1.Text = "Clients";
            // 
            // clientsListBox1
            // 
            this.clientsListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsListBox1.FormattingEnabled = true;
            this.clientsListBox1.Location = new System.Drawing.Point(3, 41);
            this.clientsListBox1.Name = "clientsListBox1";
            this.clientsListBox1.Size = new System.Drawing.Size(194, 374);
            this.clientsListBox1.TabIndex = 1;
            // 
            // clientsToolStrip1
            // 
            this.clientsToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsReload_btn1,
            this.clientsAdd_btn1,
            this.clientsRemove_btn1,
            this.clientsEdit_btn1});
            this.clientsToolStrip1.Location = new System.Drawing.Point(3, 16);
            this.clientsToolStrip1.Name = "clientsToolStrip1";
            this.clientsToolStrip1.Size = new System.Drawing.Size(194, 25);
            this.clientsToolStrip1.TabIndex = 0;
            this.clientsToolStrip1.Text = "toolStrip2";
            // 
            // clientsReload_btn1
            // 
            this.clientsReload_btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clientsReload_btn1.Image = ((System.Drawing.Image)(resources.GetObject("clientsReload_btn1.Image")));
            this.clientsReload_btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clientsReload_btn1.Name = "clientsReload_btn1";
            this.clientsReload_btn1.Size = new System.Drawing.Size(47, 22);
            this.clientsReload_btn1.Text = "Reload";
            // 
            // clientsAdd_btn1
            // 
            this.clientsAdd_btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clientsAdd_btn1.Image = ((System.Drawing.Image)(resources.GetObject("clientsAdd_btn1.Image")));
            this.clientsAdd_btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clientsAdd_btn1.Name = "clientsAdd_btn1";
            this.clientsAdd_btn1.Size = new System.Drawing.Size(33, 22);
            this.clientsAdd_btn1.Text = "Add";
            // 
            // clientsRemove_btn1
            // 
            this.clientsRemove_btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clientsRemove_btn1.Image = ((System.Drawing.Image)(resources.GetObject("clientsRemove_btn1.Image")));
            this.clientsRemove_btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clientsRemove_btn1.Name = "clientsRemove_btn1";
            this.clientsRemove_btn1.Size = new System.Drawing.Size(54, 22);
            this.clientsRemove_btn1.Text = "Remove";
            // 
            // clientsEdit_btn1
            // 
            this.clientsEdit_btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clientsEdit_btn1.Image = ((System.Drawing.Image)(resources.GetObject("clientsEdit_btn1.Image")));
            this.clientsEdit_btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clientsEdit_btn1.Name = "clientsEdit_btn1";
            this.clientsEdit_btn1.Size = new System.Drawing.Size(31, 22);
            this.clientsEdit_btn1.Text = "Edit";
            // 
            // adminsGroupBox1
            // 
            this.adminsGroupBox1.Controls.Add(this.adminsListBox1);
            this.adminsGroupBox1.Controls.Add(this.adminsToolStrip1);
            this.adminsGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminsGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.adminsGroupBox1.Name = "adminsGroupBox1";
            this.adminsGroupBox1.Size = new System.Drawing.Size(200, 418);
            this.adminsGroupBox1.TabIndex = 0;
            this.adminsGroupBox1.TabStop = false;
            this.adminsGroupBox1.Text = "Admins";
            // 
            // adminsListBox1
            // 
            this.adminsListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminsListBox1.FormattingEnabled = true;
            this.adminsListBox1.Location = new System.Drawing.Point(3, 41);
            this.adminsListBox1.Name = "adminsListBox1";
            this.adminsListBox1.Size = new System.Drawing.Size(194, 374);
            this.adminsListBox1.TabIndex = 1;
            // 
            // adminsToolStrip1
            // 
            this.adminsToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminsReload_btn1,
            this.adminsAdd_btn1,
            this.adminsRemove_btn1,
            this.adminsEdit_btn1});
            this.adminsToolStrip1.Location = new System.Drawing.Point(3, 16);
            this.adminsToolStrip1.Name = "adminsToolStrip1";
            this.adminsToolStrip1.Size = new System.Drawing.Size(194, 25);
            this.adminsToolStrip1.TabIndex = 0;
            this.adminsToolStrip1.Text = "toolStrip1";
            // 
            // adminsReload_btn1
            // 
            this.adminsReload_btn1.Checked = true;
            this.adminsReload_btn1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.adminsReload_btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.adminsReload_btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adminsReload_btn1.Name = "adminsReload_btn1";
            this.adminsReload_btn1.Size = new System.Drawing.Size(47, 22);
            this.adminsReload_btn1.Text = "Reload";
            // 
            // adminsAdd_btn1
            // 
            this.adminsAdd_btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.adminsAdd_btn1.Image = ((System.Drawing.Image)(resources.GetObject("adminsAdd_btn1.Image")));
            this.adminsAdd_btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adminsAdd_btn1.Name = "adminsAdd_btn1";
            this.adminsAdd_btn1.Size = new System.Drawing.Size(33, 22);
            this.adminsAdd_btn1.Text = "Add";
            // 
            // adminsRemove_btn1
            // 
            this.adminsRemove_btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.adminsRemove_btn1.Image = ((System.Drawing.Image)(resources.GetObject("adminsRemove_btn1.Image")));
            this.adminsRemove_btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adminsRemove_btn1.Name = "adminsRemove_btn1";
            this.adminsRemove_btn1.Size = new System.Drawing.Size(54, 22);
            this.adminsRemove_btn1.Text = "Remove";
            // 
            // adminsEdit_btn1
            // 
            this.adminsEdit_btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.adminsEdit_btn1.Image = ((System.Drawing.Image)(resources.GetObject("adminsEdit_btn1.Image")));
            this.adminsEdit_btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adminsEdit_btn1.Name = "adminsEdit_btn1";
            this.adminsEdit_btn1.Size = new System.Drawing.Size(31, 22);
            this.adminsEdit_btn1.Text = "Edit";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabControl);
            this.Name = "window";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.window_Load);
            this.mainTabControl.ResumeLayout(false);
            this.databaseTabPage1.ResumeLayout(false);
            this.serverGroupBox1.ResumeLayout(false);
            this.serverGroupBox1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.clientsGroupBox1.ResumeLayout(false);
            this.clientsGroupBox1.PerformLayout();
            this.clientsToolStrip1.ResumeLayout(false);
            this.clientsToolStrip1.PerformLayout();
            this.adminsGroupBox1.ResumeLayout(false);
            this.adminsGroupBox1.PerformLayout();
            this.adminsToolStrip1.ResumeLayout(false);
            this.adminsToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage databaseTabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox clientsGroupBox1;
        private System.Windows.Forms.GroupBox adminsGroupBox1;
        private System.Windows.Forms.ListBox clientsListBox1;
        private System.Windows.Forms.ToolStrip clientsToolStrip1;
        private System.Windows.Forms.ListBox adminsListBox1;
        private System.Windows.Forms.ToolStrip adminsToolStrip1;
        private System.Windows.Forms.GroupBox serverGroupBox1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton serverPing_btn1;
        private System.Windows.Forms.ToolStripButton clientsReload_btn1;
        private System.Windows.Forms.ToolStripButton clientsAdd_btn1;
        private System.Windows.Forms.ToolStripButton clientsRemove_btn1;
        private System.Windows.Forms.ToolStripButton adminsReload_btn1;
        private System.Windows.Forms.ToolStripButton adminsAdd_btn1;
        private System.Windows.Forms.ToolStripButton adminsRemove_btn1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox remoteUrlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminConnectURL_txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox clientDisconnect_txt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientConnectURL_txt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminDisconnectURL_txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.RichTextBox pingLog_rtxt1;
        private System.Windows.Forms.ToolStripButton clientsEdit_btn1;
        private System.Windows.Forms.ToolStripButton adminsEdit_btn1;
    }
}

