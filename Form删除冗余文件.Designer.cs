namespace Thinksea冗余文件清理工具
{
    partial class Form冗余文件清理工具
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form冗余文件清理工具));
            this.btn添加 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pan输出信息列表 = new System.Windows.Forms.Panel();
            this.btn显示输出视图右键菜单 = new System.Windows.Forms.Button();
            this.btn删除勾选的文件 = new System.Windows.Forms.Button();
            this.btn清空输出 = new System.Windows.Forms.Button();
            this.btn全部折叠 = new System.Windows.Forms.Button();
            this.btn全部展开 = new System.Windows.Forms.Button();
            this.treeView冗余文件 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip输出视图右键菜单 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.展开全部节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.折叠全部节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除全部节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.运行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用记事本打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.删除选中的冗余文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pan文件列表 = new System.Windows.Forms.Panel();
            this.cb删除文件内容相同的冗余文件 = new System.Windows.Forms.CheckBox();
            this.panel删除内容相同的冗余文件 = new System.Windows.Forms.Panel();
            this.btn取消清理目录 = new System.Windows.Forms.Button();
            this.tb只从这里清理 = new System.Windows.Forms.TextBox();
            this.btn浏览清理目录 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn清空 = new System.Windows.Forms.Button();
            this.btn删除所选 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb文件列表 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.提示信息计时器 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn开始 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn托盘处理 = new System.Windows.Forms.Button();
            this.contextMenuStrip添加按钮扩展菜单 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn关于 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.pan输出信息列表.SuspendLayout();
            this.contextMenuStrip输出视图右键菜单.SuspendLayout();
            this.pan文件列表.SuspendLayout();
            this.panel删除内容相同的冗余文件.SuspendLayout();
            this.contextMenuStrip添加按钮扩展菜单.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn添加
            // 
            this.btn添加.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn添加.Location = new System.Drawing.Point(88, 4);
            this.btn添加.Name = "btn添加";
            this.btn添加.Size = new System.Drawing.Size(42, 19);
            this.btn添加.TabIndex = 1;
            this.btn添加.Text = "添加";
            this.btn添加.Click += new System.EventHandler(this.btn添加_Click);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 197);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(476, 5);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.pan输出信息列表);
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Controls.Add(this.pan文件列表);
            this.panel3.Location = new System.Drawing.Point(8, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 344);
            this.panel3.TabIndex = 19;
            // 
            // pan输出信息列表
            // 
            this.pan输出信息列表.Controls.Add(this.btn显示输出视图右键菜单);
            this.pan输出信息列表.Controls.Add(this.btn删除勾选的文件);
            this.pan输出信息列表.Controls.Add(this.btn清空输出);
            this.pan输出信息列表.Controls.Add(this.btn全部折叠);
            this.pan输出信息列表.Controls.Add(this.btn全部展开);
            this.pan输出信息列表.Controls.Add(this.treeView冗余文件);
            this.pan输出信息列表.Controls.Add(this.label1);
            this.pan输出信息列表.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan输出信息列表.Location = new System.Drawing.Point(0, 202);
            this.pan输出信息列表.Name = "pan输出信息列表";
            this.pan输出信息列表.Size = new System.Drawing.Size(476, 142);
            this.pan输出信息列表.TabIndex = 12;
            // 
            // btn显示输出视图右键菜单
            // 
            this.btn显示输出视图右键菜单.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn显示输出视图右键菜单.Location = new System.Drawing.Point(397, 2);
            this.btn显示输出视图右键菜单.Name = "btn显示输出视图右键菜单";
            this.btn显示输出视图右键菜单.Size = new System.Drawing.Size(33, 21);
            this.btn显示输出视图右键菜单.TabIndex = 14;
            this.btn显示输出视图右键菜单.Text = ">>";
            this.toolTip1.SetToolTip(this.btn显示输出视图右键菜单, "显示全部功能菜单");
            this.btn显示输出视图右键菜单.UseVisualStyleBackColor = true;
            this.btn显示输出视图右键菜单.Click += new System.EventHandler(this.btn显示输出视图右键菜单_Click);
            // 
            // btn删除勾选的文件
            // 
            this.btn删除勾选的文件.Enabled = false;
            this.btn删除勾选的文件.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn删除勾选的文件.Location = new System.Drawing.Point(320, 2);
            this.btn删除勾选的文件.Name = "btn删除勾选的文件";
            this.btn删除勾选的文件.Size = new System.Drawing.Size(75, 21);
            this.btn删除勾选的文件.TabIndex = 13;
            this.btn删除勾选的文件.Text = "删除勾选的";
            this.toolTip1.SetToolTip(this.btn删除勾选的文件, "删除下面勾选的文件");
            this.btn删除勾选的文件.UseVisualStyleBackColor = false;
            this.btn删除勾选的文件.Click += new System.EventHandler(this.btn删除勾选的文件_Click);
            // 
            // btn清空输出
            // 
            this.btn清空输出.Enabled = false;
            this.btn清空输出.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn清空输出.Location = new System.Drawing.Point(243, 2);
            this.btn清空输出.Name = "btn清空输出";
            this.btn清空输出.Size = new System.Drawing.Size(75, 21);
            this.btn清空输出.TabIndex = 13;
            this.btn清空输出.Text = "清空";
            this.toolTip1.SetToolTip(this.btn清空输出, "清空输出信息");
            this.btn清空输出.UseVisualStyleBackColor = true;
            this.btn清空输出.Click += new System.EventHandler(this.btn清空输出_Click);
            // 
            // btn全部折叠
            // 
            this.btn全部折叠.Enabled = false;
            this.btn全部折叠.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn全部折叠.Location = new System.Drawing.Point(166, 2);
            this.btn全部折叠.Name = "btn全部折叠";
            this.btn全部折叠.Size = new System.Drawing.Size(75, 21);
            this.btn全部折叠.TabIndex = 13;
            this.btn全部折叠.Text = "全部折叠";
            this.toolTip1.SetToolTip(this.btn全部折叠, "折叠所有的节点");
            this.btn全部折叠.UseVisualStyleBackColor = true;
            this.btn全部折叠.Click += new System.EventHandler(this.btn全部折叠_Click);
            // 
            // btn全部展开
            // 
            this.btn全部展开.Enabled = false;
            this.btn全部展开.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn全部展开.Location = new System.Drawing.Point(89, 2);
            this.btn全部展开.Name = "btn全部展开";
            this.btn全部展开.Size = new System.Drawing.Size(75, 21);
            this.btn全部展开.TabIndex = 12;
            this.btn全部展开.Text = "全部展开";
            this.toolTip1.SetToolTip(this.btn全部展开, "展开所有的节点");
            this.btn全部展开.UseVisualStyleBackColor = true;
            this.btn全部展开.Click += new System.EventHandler(this.btn全部展开_Click);
            // 
            // treeView冗余文件
            // 
            this.treeView冗余文件.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView冗余文件.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView冗余文件.CheckBoxes = true;
            this.treeView冗余文件.ContextMenuStrip = this.contextMenuStrip输出视图右键菜单;
            this.treeView冗余文件.HideSelection = false;
            this.treeView冗余文件.Location = new System.Drawing.Point(0, 24);
            this.treeView冗余文件.Name = "treeView冗余文件";
            this.treeView冗余文件.Size = new System.Drawing.Size(476, 118);
            this.treeView冗余文件.TabIndex = 11;
            this.treeView冗余文件.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView冗余文件_AfterCheck);
            this.treeView冗余文件.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView冗余文件_BeforeCheck);
            // 
            // contextMenuStrip输出视图右键菜单
            // 
            this.contextMenuStrip输出视图右键菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.展开全部节点ToolStripMenuItem,
            this.折叠全部节点ToolStripMenuItem,
            this.删除全部节点ToolStripMenuItem,
            this.toolStripSeparator2,
            this.运行ToolStripMenuItem,
            this.用记事本打开ToolStripMenuItem,
            this.toolStripSeparator1,
            this.删除选中的冗余文件ToolStripMenuItem});
            this.contextMenuStrip输出视图右键菜单.Name = "contextMenuStrip输出视图右键菜单";
            this.contextMenuStrip输出视图右键菜单.Size = new System.Drawing.Size(179, 148);
            this.contextMenuStrip输出视图右键菜单.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip输出视图右键菜单_Opening);
            // 
            // 展开全部节点ToolStripMenuItem
            // 
            this.展开全部节点ToolStripMenuItem.Name = "展开全部节点ToolStripMenuItem";
            this.展开全部节点ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.展开全部节点ToolStripMenuItem.Text = "展开全部节点";
            this.展开全部节点ToolStripMenuItem.Click += new System.EventHandler(this.展开全部节点ToolStripMenuItem_Click);
            // 
            // 折叠全部节点ToolStripMenuItem
            // 
            this.折叠全部节点ToolStripMenuItem.Name = "折叠全部节点ToolStripMenuItem";
            this.折叠全部节点ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.折叠全部节点ToolStripMenuItem.Text = "折叠全部节点";
            this.折叠全部节点ToolStripMenuItem.Click += new System.EventHandler(this.折叠全部节点ToolStripMenuItem_Click);
            // 
            // 删除全部节点ToolStripMenuItem
            // 
            this.删除全部节点ToolStripMenuItem.Name = "删除全部节点ToolStripMenuItem";
            this.删除全部节点ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.删除全部节点ToolStripMenuItem.Text = "删除全部节点";
            this.删除全部节点ToolStripMenuItem.Click += new System.EventHandler(this.删除全部节点ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // 运行ToolStripMenuItem
            // 
            this.运行ToolStripMenuItem.Name = "运行ToolStripMenuItem";
            this.运行ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.运行ToolStripMenuItem.Text = "运行";
            this.运行ToolStripMenuItem.Click += new System.EventHandler(this.运行ToolStripMenuItem_Click);
            // 
            // 用记事本打开ToolStripMenuItem
            // 
            this.用记事本打开ToolStripMenuItem.Name = "用记事本打开ToolStripMenuItem";
            this.用记事本打开ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.用记事本打开ToolStripMenuItem.Text = "用记事本打开";
            this.用记事本打开ToolStripMenuItem.Click += new System.EventHandler(this.用记事本打开ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // 删除选中的冗余文件ToolStripMenuItem
            // 
            this.删除选中的冗余文件ToolStripMenuItem.Name = "删除选中的冗余文件ToolStripMenuItem";
            this.删除选中的冗余文件ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.删除选中的冗余文件ToolStripMenuItem.Text = "删除勾选的冗余文件";
            this.删除选中的冗余文件ToolStripMenuItem.Click += new System.EventHandler(this.删除选中的冗余文件ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "输出信息(&O)：";
            // 
            // pan文件列表
            // 
            this.pan文件列表.Controls.Add(this.cb删除文件内容相同的冗余文件);
            this.pan文件列表.Controls.Add(this.panel删除内容相同的冗余文件);
            this.pan文件列表.Controls.Add(this.btn清空);
            this.pan文件列表.Controls.Add(this.btn删除所选);
            this.pan文件列表.Controls.Add(this.btn添加);
            this.pan文件列表.Controls.Add(this.label3);
            this.pan文件列表.Controls.Add(this.lb文件列表);
            this.pan文件列表.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan文件列表.Location = new System.Drawing.Point(0, 0);
            this.pan文件列表.Name = "pan文件列表";
            this.pan文件列表.Size = new System.Drawing.Size(476, 197);
            this.pan文件列表.TabIndex = 11;
            // 
            // cb删除文件内容相同的冗余文件
            // 
            this.cb删除文件内容相同的冗余文件.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb删除文件内容相同的冗余文件.AutoSize = true;
            this.cb删除文件内容相同的冗余文件.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb删除文件内容相同的冗余文件.Location = new System.Drawing.Point(3, 148);
            this.cb删除文件内容相同的冗余文件.Name = "cb删除文件内容相同的冗余文件";
            this.cb删除文件内容相同的冗余文件.Size = new System.Drawing.Size(178, 16);
            this.cb删除文件内容相同的冗余文件.TabIndex = 4;
            this.cb删除文件内容相同的冗余文件.Text = "自动删除内容相同的冗余文件";
            this.cb删除文件内容相同的冗余文件.CheckedChanged += new System.EventHandler(this.cb删除文件内容相同的冗余文件_CheckedChanged);
            // 
            // panel删除内容相同的冗余文件
            // 
            this.panel删除内容相同的冗余文件.Controls.Add(this.btn取消清理目录);
            this.panel删除内容相同的冗余文件.Controls.Add(this.tb只从这里清理);
            this.panel删除内容相同的冗余文件.Controls.Add(this.btn浏览清理目录);
            this.panel删除内容相同的冗余文件.Controls.Add(this.label2);
            this.panel删除内容相同的冗余文件.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel删除内容相同的冗余文件.Enabled = false;
            this.panel删除内容相同的冗余文件.Location = new System.Drawing.Point(0, 170);
            this.panel删除内容相同的冗余文件.Name = "panel删除内容相同的冗余文件";
            this.panel删除内容相同的冗余文件.Size = new System.Drawing.Size(476, 27);
            this.panel删除内容相同的冗余文件.TabIndex = 10;
            // 
            // btn取消清理目录
            // 
            this.btn取消清理目录.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn取消清理目录.Enabled = false;
            this.btn取消清理目录.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn取消清理目录.Location = new System.Drawing.Point(396, 2);
            this.btn取消清理目录.Name = "btn取消清理目录";
            this.btn取消清理目录.Size = new System.Drawing.Size(75, 23);
            this.btn取消清理目录.TabIndex = 9;
            this.btn取消清理目录.Text = "清除";
            this.btn取消清理目录.UseVisualStyleBackColor = true;
            this.btn取消清理目录.Click += new System.EventHandler(this.btn取消锁定目录_Click);
            // 
            // tb只从这里清理
            // 
            this.tb只从这里清理.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb只从这里清理.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb只从这里清理.Location = new System.Drawing.Point(88, 3);
            this.tb只从这里清理.Name = "tb只从这里清理";
            this.tb只从这里清理.ReadOnly = true;
            this.tb只从这里清理.Size = new System.Drawing.Size(221, 21);
            this.tb只从这里清理.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tb只从这里清理, "当需要删除冗余文件时，只从这个目录清理文件");
            this.tb只从这里清理.TextChanged += new System.EventHandler(this.tb锁定目录_TextChanged);
            // 
            // btn浏览清理目录
            // 
            this.btn浏览清理目录.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn浏览清理目录.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn浏览清理目录.Location = new System.Drawing.Point(315, 2);
            this.btn浏览清理目录.Name = "btn浏览清理目录";
            this.btn浏览清理目录.Size = new System.Drawing.Size(75, 23);
            this.btn浏览清理目录.TabIndex = 9;
            this.btn浏览清理目录.Text = "浏览…";
            this.btn浏览清理目录.UseVisualStyleBackColor = true;
            this.btn浏览清理目录.Click += new System.EventHandler(this.btn浏览锁定目录_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "只从这里清理：";
            // 
            // btn清空
            // 
            this.btn清空.Enabled = false;
            this.btn清空.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn清空.Location = new System.Drawing.Point(206, 4);
            this.btn清空.Name = "btn清空";
            this.btn清空.Size = new System.Drawing.Size(39, 19);
            this.btn清空.TabIndex = 3;
            this.btn清空.Text = "清空";
            this.toolTip1.SetToolTip(this.btn清空, "清空文件列表");
            this.btn清空.Click += new System.EventHandler(this.btn清空_Click);
            // 
            // btn删除所选
            // 
            this.btn删除所选.Enabled = false;
            this.btn删除所选.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn删除所选.Location = new System.Drawing.Point(136, 4);
            this.btn删除所选.Name = "btn删除所选";
            this.btn删除所选.Size = new System.Drawing.Size(64, 19);
            this.btn删除所选.TabIndex = 2;
            this.btn删除所选.Text = "删除所选";
            this.btn删除所选.Click += new System.EventHandler(this.btn删除所选_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "文件列表(&F)：";
            // 
            // lb文件列表
            // 
            this.lb文件列表.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb文件列表.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb文件列表.HorizontalScrollbar = true;
            this.lb文件列表.IntegralHeight = false;
            this.lb文件列表.ItemHeight = 12;
            this.lb文件列表.Location = new System.Drawing.Point(0, 24);
            this.lb文件列表.Name = "lb文件列表";
            this.lb文件列表.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb文件列表.Size = new System.Drawing.Size(476, 121);
            this.lb文件列表.TabIndex = 6;
            this.lb文件列表.SelectedIndexChanged += new System.EventHandler(this.lb文件列表_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(8, 383);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(476, 12);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 20;
            // 
            // 提示信息计时器
            // 
            this.提示信息计时器.Interval = 1000;
            this.提示信息计时器.Tick += new System.EventHandler(this.提示信息计时器_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // btn开始
            // 
            this.btn开始.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn开始.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn开始.Location = new System.Drawing.Point(80, 354);
            this.btn开始.Name = "btn开始";
            this.btn开始.Size = new System.Drawing.Size(108, 23);
            this.btn开始.TabIndex = 17;
            this.btn开始.Text = "开始";
            this.toolTip1.SetToolTip(this.btn开始, "开始执行任务");
            this.btn开始.Click += new System.EventHandler(this.btn开始_Click);
            // 
            // btn托盘处理
            // 
            this.btn托盘处理.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn托盘处理.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn托盘处理.Location = new System.Drawing.Point(205, 354);
            this.btn托盘处理.Name = "btn托盘处理";
            this.btn托盘处理.Size = new System.Drawing.Size(108, 23);
            this.btn托盘处理.TabIndex = 18;
            this.btn托盘处理.Text = "隐藏主窗口";
            this.toolTip1.SetToolTip(this.btn托盘处理, "隐藏主窗口，缩小为右下角图标，在后台执行任务");
            this.btn托盘处理.Click += new System.EventHandler(this.btn托盘处理_Click);
            // 
            // contextMenuStrip添加按钮扩展菜单
            // 
            this.contextMenuStrip添加按钮扩展菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加文件ToolStripMenuItem,
            this.添加文件夹ToolStripMenuItem});
            this.contextMenuStrip添加按钮扩展菜单.Name = "contextMenuStrip1";
            this.contextMenuStrip添加按钮扩展菜单.Size = new System.Drawing.Size(131, 48);
            // 
            // 添加文件ToolStripMenuItem
            // 
            this.添加文件ToolStripMenuItem.Name = "添加文件ToolStripMenuItem";
            this.添加文件ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.添加文件ToolStripMenuItem.Text = "添加文件";
            this.添加文件ToolStripMenuItem.Click += new System.EventHandler(this.添加文件ToolStripMenuItem_Click);
            // 
            // 添加文件夹ToolStripMenuItem
            // 
            this.添加文件夹ToolStripMenuItem.Name = "添加文件夹ToolStripMenuItem";
            this.添加文件夹ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.添加文件夹ToolStripMenuItem.Text = "添加文件夹";
            this.添加文件夹ToolStripMenuItem.Click += new System.EventHandler(this.添加文件夹ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(157, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(320, 17);
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn关于
            // 
            this.btn关于.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn关于.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn关于.Location = new System.Drawing.Point(330, 354);
            this.btn关于.Name = "btn关于";
            this.btn关于.Size = new System.Drawing.Size(108, 23);
            this.btn关于.TabIndex = 18;
            this.btn关于.Text = "关于";
            this.toolTip1.SetToolTip(this.btn关于, "关于此程序");
            this.btn关于.Click += new System.EventHandler(this.btn关于_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Thinksea 冗余文件清理工具";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Form冗余文件清理工具
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 420);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn开始);
            this.Controls.Add(this.btn托盘处理);
            this.Controls.Add(this.btn关于);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(500, 447);
            this.Name = "Form冗余文件清理工具";
            this.Text = "Thinksea 冗余文件清理工具 v2.1.0.0";
            this.Load += new System.EventHandler(this.Form冗余文件清理工具_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form冗余文件清理工具_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form冗余文件清理工具_DragEnter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form冗余文件清理工具_FormClosing);
            this.panel3.ResumeLayout(false);
            this.pan输出信息列表.ResumeLayout(false);
            this.pan输出信息列表.PerformLayout();
            this.contextMenuStrip输出视图右键菜单.ResumeLayout(false);
            this.pan文件列表.ResumeLayout(false);
            this.pan文件列表.PerformLayout();
            this.panel删除内容相同的冗余文件.ResumeLayout(false);
            this.panel删除内容相同的冗余文件.PerformLayout();
            this.contextMenuStrip添加按钮扩展菜单.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn添加;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pan文件列表;
        private System.Windows.Forms.CheckBox cb删除文件内容相同的冗余文件;
        private System.Windows.Forms.Button btn清空;
        private System.Windows.Forms.Button btn删除所选;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan输出信息列表;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer 提示信息计时器;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn开始;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn托盘处理;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip添加按钮扩展菜单;
        private System.Windows.Forms.ToolStripMenuItem 添加文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加文件夹ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ListBox lb文件列表;
        private System.Windows.Forms.Button btn关于;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TreeView treeView冗余文件;
        private System.Windows.Forms.Button btn浏览清理目录;
        private System.Windows.Forms.TextBox tb只从这里清理;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn取消清理目录;
        private System.Windows.Forms.Button btn全部折叠;
        private System.Windows.Forms.Button btn全部展开;
        private System.Windows.Forms.Button btn清空输出;
        private System.Windows.Forms.Button btn删除勾选的文件;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel删除内容相同的冗余文件;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip输出视图右键菜单;
        private System.Windows.Forms.ToolStripMenuItem 用记事本打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 删除选中的冗余文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 展开全部节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 折叠全部节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除全部节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btn显示输出视图右键菜单;
    }
}