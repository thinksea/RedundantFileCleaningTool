using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Thinksea冗余文件清理工具
{
    public partial class Form冗余文件清理工具 : Form
    {
        /// <summary>
        /// 用来描述一个文件的摘要信息。
        /// </summary>
        private class 文件信息摘要
        {
            /// <summary>
            /// 文件名。
            /// </summary>
            public string FileName;
            /// <summary>
            /// 文件大小。
            /// </summary>
            public long Length;
            /// <summary>
            /// SHA1 值。
            /// </summary>
            public string SHA1;
            /// <summary>
            /// 指示此文件是否冗余的文件。
            /// </summary>
            public bool IsRepeat = false;

            /// <summary>
            /// 用指定的数据初始化此实例。
            /// </summary>
            /// <param name="FileName">文件名。</param>
            /// <param name="Length">文件大小。</param>
            /// <param name="SHA1">SHA1 值。</param>
            public 文件信息摘要(string FileName, long Length, string SHA1)
            {
                this.FileName = FileName;
                this.Length = Length;
                this.SHA1 = SHA1;

            }

        }

        public enum 当前执行步骤
        {
            操作结束 = 0,
            正在统计需要处理的文件 = 1,
            正在计算冗余文件 = 2,
            正在删除冗余文件 = 3,
        }

        #region 预定义方法代理。
        /// <summary>
        /// 封装一个方法，该方法无参数并且不返回值。
        /// </summary>
        public delegate void VoidHandler();

        /// <summary>
        /// 封装一个方法，该方法无参数并且有返回值。
        /// </summary>
        /// <typeparam name="TReturn">返回值的数据类型。</typeparam>
        public delegate TReturn ReturnHandler<TReturn>();

        /// <summary>
        /// 封装一个方法，该方法只采用一个参数并且不返回值。
        /// </summary>
        /// <typeparam name="T">参数的数据类型。</typeparam>
        /// <param name="parameter">参数。</param>
        public delegate void VoidHandler<T>(T parameter);

        /// <summary>
        /// 封装一个方法，该方法只采用一个参数并且有返回值。
        /// </summary>
        /// <typeparam name="TReturn">返回值的数据类型。</typeparam>
        /// <typeparam name="T">参数的数据类型。</typeparam>
        /// <param name="parameter">参数。</param>
        public delegate TReturn ReturnHandler<TReturn, T>(T parameter);

        /// <summary>
        /// 封装一个方法，该方法只采用两个参数并且不返回值。
        /// </summary>
        /// <typeparam name="T1">第一个参数的数据类型。</typeparam>
        /// <typeparam name="T2">第二个参数的数据类型。</typeparam>
        /// <param name="p1">第一个参数。</param>
        /// <param name="p2">第二个参数。</param>
        public delegate void VoidHandler<T1, T2>(T1 p1, T2 p2);

        /// <summary>
        /// 封装一个方法，该方法只采用两个参数并且有返回值。
        /// </summary>
        /// <typeparam name="TReturn">返回值的数据类型。</typeparam>
        /// <typeparam name="T1">第一个参数的数据类型。</typeparam>
        /// <typeparam name="T2">第二个参数的数据类型。</typeparam>
        /// <param name="p1">第一个参数。</param>
        /// <param name="p2">第二个参数。</param>
        public delegate TReturn ReturnHandler<TReturn, T1, T2>(T1 p1, T2 p2);

        /// <summary>
        /// 封装一个方法，该方法只采用三个参数并且不返回值。
        /// </summary>
        /// <typeparam name="T1">第一个参数的数据类型。</typeparam>
        /// <typeparam name="T2">第二个参数的数据类型。</typeparam>
        /// <typeparam name="T3">第三个参数的数据类型。</typeparam>
        /// <param name="p1">第一个参数。</param>
        /// <param name="p2">第二个参数。</param>
        /// <param name="p3">第三个参数。</param>
        public delegate void VoidHandler<T1, T2, T3>(T1 p1, T2 p2, T3 p3);

        /// <summary>
        /// 封装一个方法，该方法只采用三个参数并且有返回值。
        /// </summary>
        /// <typeparam name="TReturn">返回值的数据类型。</typeparam>
        /// <typeparam name="T1">第一个参数的数据类型。</typeparam>
        /// <typeparam name="T2">第二个参数的数据类型。</typeparam>
        /// <typeparam name="T3">第三个参数的数据类型。</typeparam>
        /// <param name="p1">第一个参数。</param>
        /// <param name="p2">第二个参数。</param>
        /// <param name="p3">第三个参数。</param>
        public delegate TReturn ReturnHandler<TReturn, T1, T2, T3>(T1 p1, T2 p2, T3 p3);

        /// <summary>
        /// 封装一个方法，该方法只采用数目可变的参数并且不返回值。
        /// </summary>
        /// <typeparam name="T">参数的数据类型。</typeparam>
        /// <param name="parameters">参数。</param>
        public delegate void VoidNParamHandler<T>(params T[] parameters);

        /// <summary>
        /// 封装一个方法，该方法只采用数目可变的参数并且有返回值。
        /// </summary>
        /// <typeparam name="TReturn">返回值的数据类型。</typeparam>
        /// <typeparam name="T">参数的数据类型。</typeparam>
        /// <param name="parameters">参数。</param>
        public delegate TReturn ReturnNParamHandler<TReturn, T>(params T[] parameters);

        #endregion

        public Form冗余文件清理工具()
        {
            InitializeComponent();

        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    System.Reflection.AssemblyTitleAttribute titleAttribute = (System.Reflection.AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void Form冗余文件清理工具_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} v{1}", AssemblyTitle, AssemblyVersion);

            this.设置操作项提示("准备就绪！");

        }

        private void Form冗余文件清理工具_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.停止文件处理线程(true);

        }

        private void btn添加_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip添加按钮扩展菜单.Show(this.btn添加, new System.Drawing.Point(0, 0));

        }

        private void btn删除所选_Click(object sender, EventArgs e)
        {
            for (int i = this.lb文件列表.SelectedIndices.Count - 1; i >= 0; i--)
            {
                this.lb文件列表.Items.RemoveAt(this.lb文件列表.SelectedIndices[i]);
            }
            this.重新计算文件列表关联界面状态();

        }

        private void btn清空_Click(object sender, EventArgs e)
        {
            this.lb文件列表.Items.Clear();
            this.重新计算文件列表关联界面状态();

        }

        private void btn开始_Click(object sender, EventArgs e)
        {
            if (this.lb文件列表.Items.Count == 0)
            {
                return;
            }

            if (this.文件处理线程 == null)
            {
                this.文件处理线程 = new System.Threading.Thread(new System.Threading.ThreadStart(this.文件处理方法));
                this.文件处理线程.Name = "冗余文件清理工具";
                this.文件处理线程.IsBackground = true;
                this.文件处理线程.Start();
            }
            else
            {
                this.停止文件处理线程(true);
            }

        }

        private void Form冗余文件清理工具_DragDrop(object sender, DragEventArgs e)
        {
            System.String[] files = (System.String[])(e.Data.GetData("FileDrop"));
            this.添加文件到文件列表(files);

        }

        private void Form冗余文件清理工具_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = System.Windows.Forms.DragDropEffects.Copy;

            }

        }

        private void 添加文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.添加文件到文件列表(this.openFileDialog1.FileNames);
            }

        }

        private void 添加文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dr = this.folderBrowserDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.添加文件到文件列表(this.folderBrowserDialog1.SelectedPath);

            }

        }

        private void btn托盘处理_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btn关于_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    if (this.Visible)
                    {
                        this.Hide();
                    }
                    else
                    {
                        this.Show();
                    }
                    break;

            }

        }

        private void btn浏览锁定目录_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tb只从这里清理.Text = this.folderBrowserDialog1.SelectedPath;
            }

        }

        private void btn取消锁定目录_Click(object sender, EventArgs e)
        {
            this.tb只从这里清理.Clear();

        }

        private void btn全部展开_Click(object sender, EventArgs e)
        {
            this.treeView冗余文件.ExpandAll();

        }

        private void btn全部折叠_Click(object sender, EventArgs e)
        {
            this.treeView冗余文件.CollapseAll();

        }

        private void btn清空输出_Click(object sender, EventArgs e)
        {
            this.treeView冗余文件.Nodes.Clear();
            this.重新计算输出信息操作界面状态();

        }

        private void treeView冗余文件_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            文件信息摘要 fi = e.Node.Tag as 文件信息摘要;
            if (fi == null)
            {
                e.Cancel = true;
                return;
            }

            if (System.IO.File.Exists(fi.FileName) == false)
            {
                e.Cancel = true;
                return;
            }

        }

        private void btn删除勾选的文件_Click(object sender, EventArgs e)
        {
            TreeNode[] tns = this.获取已经勾选复选框的节点(this.treeView冗余文件.Nodes);
            foreach (TreeNode tmp in tns)
            {
                文件信息摘要 fi = tmp.Tag as 文件信息摘要;
                if (fi == null)
                {
                    continue;
                }

                if (!System.IO.File.Exists(fi.FileName))
                {
                    continue;
                }

                System.IO.File.SetAttributes(fi.FileName, System.IO.FileAttributes.Normal);
                System.IO.File.Delete(fi.FileName);
                this.成功清理文件总数++;
                this.设置节点文本(tmp, string.Format("[删除完成] {0}", fi.FileName));

            }

            this.设置进度提示(string.Format("冗余文件数：{0} 清理文件数：{1}"
                , this.冗余文件总数
                , this.成功清理文件总数)
                );
            this.重新计算输出信息操作界面状态();

        }

        private void tb锁定目录_TextChanged(object sender, EventArgs e)
        {
            this.btn取消清理目录.Enabled = !string.IsNullOrEmpty(this.tb只从这里清理.Text);

        }

        private void cb删除文件内容相同的冗余文件_CheckedChanged(object sender, EventArgs e)
        {
            this.panel删除内容相同的冗余文件.Enabled = this.cb删除文件内容相同的冗余文件.Checked;
        }

        private void contextMenuStrip输出视图右键菜单_Opening(object sender, CancelEventArgs e)
        {
            this.重新计算输出信息操作界面状态();

        }

        private void 展开全部节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.treeView冗余文件.ExpandAll();
        }

        private void 折叠全部节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.treeView冗余文件.CollapseAll();
        }

        private void 删除全部节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.treeView冗余文件.Nodes.Clear();
            this.重新计算输出信息操作界面状态();
        }

        private void 用记事本打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            文件信息摘要 fi = this.treeView冗余文件.SelectedNode.Tag as 文件信息摘要;
            if(fi == null)
            {
                return;
            }

            string fileName = fi.FileName;
            if(!System.IO.File.Exists(fileName))
            {
                return;
            }

            System.Diagnostics.Process.Start("notepad.exe", "\"" + fileName + "\"");

        }

        private void 运行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            文件信息摘要 fi = this.treeView冗余文件.SelectedNode.Tag as 文件信息摘要;
            if (fi == null)
            {
                return;
            }

            string fileName = fi.FileName;
            if (!System.IO.File.Exists(fileName))
            {
                return;
            }

            System.Diagnostics.Process.Start(fileName);

        }

        private void 删除选中的冗余文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btn删除勾选的文件_Click(sender, e);
        }

        private void btn显示输出视图右键菜单_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip输出视图右键菜单.Show(this.btn显示输出视图右键菜单, new System.Drawing.Point(0, 0));
        }

        private void lb文件列表_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.重新计算文件列表关联界面状态();

        }

        private void treeView冗余文件_AfterCheck(object sender, TreeViewEventArgs e)
        {
            this.重新计算输出信息操作界面状态();

        }

        private void 添加文件到文件列表(params string[] files)
        {
            foreach (string tmp in files)
            {
                if (!this.lb文件列表.Items.Contains(tmp))
                {
                    this.lb文件列表.Items.Add(tmp);
                }
            }
            this.重新计算文件列表关联界面状态();

        }

        private void 重新计算文件列表关联界面状态()
        {
            this.btn开始.Enabled = (this.lb文件列表.Items.Count > 0);
            this.btn删除所选.Enabled = (this.lb文件列表.SelectedIndex != -1);
            this.btn清空.Enabled = (this.lb文件列表.Items.Count > 0);

        }

        private void 重新计算输出信息操作界面状态()
        {
            if (this.InvokeRequired)
            {
                VoidHandler d = new VoidHandler(this.重新计算输出信息操作界面状态);
                this.Invoke(d);
            }
            else
            {
                this.btn全部展开.Enabled = this.展开全部节点ToolStripMenuItem.Enabled = (this.treeView冗余文件.Nodes.Count > 0);
                this.btn全部折叠.Enabled = this.折叠全部节点ToolStripMenuItem.Enabled = (this.treeView冗余文件.Nodes.Count > 0);
                this.btn清空输出.Enabled = this.删除全部节点ToolStripMenuItem.Enabled = (this.treeView冗余文件.Nodes.Count > 0);

                {
                    bool 显示用记事本打开菜单 = false;
                    if (this.treeView冗余文件.SelectedNode != null)
                    {
                        文件信息摘要 fi = this.treeView冗余文件.SelectedNode.Tag as 文件信息摘要;
                        if (fi != null && System.IO.File.Exists(fi.FileName))
                        {
                            显示用记事本打开菜单 = true;
                        }
                    }
                    this.用记事本打开ToolStripMenuItem.Enabled = 显示用记事本打开菜单;
                    this.运行ToolStripMenuItem.Enabled = 显示用记事本打开菜单;
                }

                {
                    bool 显示删除选中的冗余文件菜单 = false;
                    TreeNode[] tns = this.获取已经勾选复选框的节点(this.treeView冗余文件.Nodes);
                    foreach (TreeNode tmp in tns)
                    {
                        文件信息摘要 fi = tmp.Tag as 文件信息摘要;
                        if (fi == null)
                        {
                            continue;
                        }

                        if (!System.IO.File.Exists(fi.FileName))
                        {
                            continue;
                        }

                        显示删除选中的冗余文件菜单 = true;
                        break;
                    }
                    this.btn删除勾选的文件.Enabled = this.删除选中的冗余文件ToolStripMenuItem.Enabled = 显示删除选中的冗余文件菜单;
                }
            }

        }

        private TreeNode[] 获取已经勾选复选框的节点(TreeNodeCollection tnc)
        {
            System.Collections.Generic.List<TreeNode> l = new List<TreeNode>();
            foreach (TreeNode tmp in tnc)
            {
                if (tmp.Checked)
                {
                    l.Add(tmp);
                }
                l.AddRange(this.获取已经勾选复选框的节点(tmp.Nodes));
            }
            return l.ToArray();

        }

        #region Invoke
        private void 设置操作项提示(string text)
        {
            if (this.statusStrip1.InvokeRequired)
            {
                VoidHandler<string> d = new VoidHandler<string>(this.设置操作项提示);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.toolStripStatusLabel1.Text = text;
            }
        }

        private void 设置进度提示(string text)
        {
            if (this.statusStrip1.InvokeRequired)
            {
                VoidHandler<string> d = new VoidHandler<string>(this.设置进度提示);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.toolStripStatusLabel2.Text = text;
            }
        }

        private void 设置开始按钮文本(string text)
        {
            if (this.btn开始.InvokeRequired)
            {
                VoidHandler<string> d = new VoidHandler<string>(this.设置开始按钮文本);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.btn开始.Text = text;
            }
        }

        private void 设置进度条当前值(int v)
        {
            if (this.progressBar1.InvokeRequired)
            {
                VoidHandler<int> d = new VoidHandler<int>(this.设置进度条当前值);
                this.Invoke(d, new object[] { v });
            }
            else
            {
                this.progressBar1.Value = v;
            }
        }

        private void 设置进度条最大值(int v)
        {
            if (this.progressBar1.InvokeRequired)
            {
                VoidHandler<int> d = new VoidHandler<int>(this.设置进度条最大值);
                this.Invoke(d, new object[] { v });
            }
            else
            {
                this.progressBar1.Maximum = v;
            }
        }

        private void 设置文件列表面板Enabled属性(bool v)
        {
            if (this.pan文件列表.InvokeRequired)
            {
                VoidHandler<bool> d = new VoidHandler<bool>(this.设置文件列表面板Enabled属性);
                this.Invoke(d, new object[] { v });
            }
            else
            {
                this.pan文件列表.Enabled = v;
            }
        }

        private void 启动或停止提示信息计时器(bool Enable)
        {
            if (this.InvokeRequired)
            {
                VoidHandler<bool> d = new VoidHandler<bool>(this.启动或停止提示信息计时器);
                this.Invoke(d, new object[] { Enable });
            }
            else
            {
                if (Enable)
                {
                    this.提示信息计时器.Start();
                }
                else
                {
                    this.提示信息计时器.Stop();
                }
            }
        }

        private void 添加节点(TreeNodeCollection parentTNC, TreeNode tn)
        {
            if (this.InvokeRequired)
            {
                VoidHandler<TreeNodeCollection, TreeNode> d = new VoidHandler<TreeNodeCollection, TreeNode>(this.添加节点);
                this.Invoke(d, new object[] { parentTNC, tn });
            }
            else
            {
                parentTNC.Add(tn);
            }

        }

        private void 设置节点文本(TreeNode tn, string text)
        {
            if (this.InvokeRequired)
            {
                VoidHandler<TreeNode, string> d = new VoidHandler<TreeNode, string>(this.设置节点文本);
                this.Invoke(d, new object[] { tn, text });
            }
            else
            {
                tn.Text = text;
            }

        }

        private void 设置树视图更新状态(bool v)
        {
            if (this.treeView冗余文件.InvokeRequired)
            {
                VoidHandler<bool> d = new VoidHandler<bool>(this.设置树视图更新状态);
                this.Invoke(d, new object[] { v });
            }
            else
            {
                if (v)
                {
                    this.treeView冗余文件.EndUpdate();
                }
                else
                {
                    this.treeView冗余文件.BeginUpdate();
                }
            }
        }

        private void 清空节点()
        {
            if (this.treeView冗余文件.InvokeRequired)
            {
                VoidHandler d = new VoidHandler(this.清空节点);
                this.Invoke(d);
            }
            else
            {
                this.treeView冗余文件.Nodes.Clear();
                this.重新计算输出信息操作界面状态();
            }
        }

        #endregion

        #region 主要处理过程
        private System.Threading.Thread 文件处理线程 = null;
        private System.Collections.Generic.List<文件信息摘要> 文件信息摘要集合 = new List<文件信息摘要>();
        private int 当前处理的文件索引 = 0;
        private System.DateTime 文件处理线程起始执行时间 = System.DateTime.MinValue;
        private int 冗余文件总数 = 0;
        private int 成功清理文件总数 = 0;
        private 当前执行步骤 当前正在执行的步骤 = 当前执行步骤.操作结束;

        private void 添加文件信息摘要(string FileName)
        {
            if (this.InvokeRequired)
            {
                VoidHandler<string> d = new VoidHandler<string>(this.添加文件信息摘要);
                this.Invoke(d, new object[] { FileName });
            }
            else
            {
                foreach (文件信息摘要 tmp2 in this.文件信息摘要集合)
                {
                    if (tmp2.FileName == FileName)
                    {
                        return;
                    }
                }

                this.文件信息摘要集合.Add(new 文件信息摘要(FileName, new System.IO.FileInfo(FileName).Length, ""));

            }
        }
        private void 添加目录(System.String path)
        {
            System.IO.DirectoryInfo di = null;
            try
            {
                di = new System.IO.DirectoryInfo(path);
            }
            catch
            {
                throw;
            }
            if (!di.Exists)
            {
                return;
            }

            System.IO.FileInfo[] files = null;
            try
            {
                files = di.GetFiles();
            }
            catch
            {
                throw;
            }
            foreach (System.IO.FileInfo tmp in files)
            {
                this.添加文件信息摘要(tmp.FullName);
            }

            System.String[] directories = null;
            try
            {
                directories = System.IO.Directory.GetDirectories(path);
            }
            catch
            {
                throw;
            }

            foreach (System.String tmp in directories)
            {
                try
                {
                    this.添加目录(tmp);
                }
                catch
                {
                    throw;
                }
            }

        }

        private void 提示信息计时器_Tick(object sender, EventArgs e)
        {
            switch (this.当前正在执行的步骤)
            {
                case 当前执行步骤.操作结束:
                    break;
                case 当前执行步骤.正在统计需要处理的文件:
                    this.设置进度提示(string.Format("预计处理文件数量：{0}", this.文件信息摘要集合.Count));
                    break;
                case 当前执行步骤.正在计算冗余文件:
                    this.设置操作项提示(this.文件信息摘要集合[this.当前处理的文件索引].FileName);
                    this.设置进度条当前值(this.当前处理的文件索引);
                    this.设置进度提示(string.Format("{0}/{1} ({2}%) 估计剩余时间：{3}"
                        , this.当前处理的文件索引
                        , this.文件信息摘要集合.Count
                        , (int)(((double)this.当前处理的文件索引 / (double)this.文件信息摘要集合.Count) * 100)
                        , this.计算剩余时间())
                        );
                    break;
                case 当前执行步骤.正在删除冗余文件:
                    this.设置操作项提示("正在删除冗余文件……");
                    this.设置进度提示(string.Format("冗余文件数：{0} 清理文件数：{1}"
                        , this.冗余文件总数
                        , this.成功清理文件总数)
                        );
                    break;
            }

        }

        private void 文件处理方法()
        {
            this.设置文件列表面板Enabled属性(false);
            this.文件处理线程起始执行时间 = System.DateTime.Now;
            this.设置开始按钮文本("停止");
            this.设置进度条当前值(0);
            this.当前处理的文件索引 = 0;
            this.冗余文件总数 = 0;
            this.成功清理文件总数 = 0;
            this.清空节点();
            this.启动或停止提示信息计时器(true);

            #region 开始添加文件
            this.当前正在执行的步骤 = 当前执行步骤.正在统计需要处理的文件;
            this.设置操作项提示("正在统计需要处理的文件……");
            this.设置进度提示("");
            this.文件信息摘要集合.Clear();
            foreach (string tmp in this.lb文件列表.Items)
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(tmp);

                if ((di.Attributes & System.IO.FileAttributes.Directory) == System.IO.FileAttributes.Directory)
                {
                    if (!System.IO.Directory.Exists(di.FullName))
                    {
                        continue;
                    }
                    this.添加目录(di.FullName);
                }
                else
                {
                    if (!System.IO.File.Exists(di.FullName))
                    {
                        continue;
                    }
                    this.添加文件信息摘要(di.FullName);
                }
            }
            #endregion

            this.设置进度条最大值(this.文件信息摘要集合.Count);
            #region 搜索冗余文件。
            {
                this.当前正在执行的步骤 = 当前执行步骤.正在计算冗余文件;
                System.Collections.Generic.List<文件信息摘要> SameFiles = new System.Collections.Generic.List<文件信息摘要>();
                for (int i = 0; i < this.文件信息摘要集合.Count - 1; i++)
                {
                    this.当前处理的文件索引 = i;

                    文件信息摘要 tmpi = this.文件信息摘要集合[i];
                    if (tmpi.IsRepeat)//如果此文件已经比较过并且明确为冗余文件，则跳过此文件不进行比较。
                    {
                        continue;
                    }

                    #region 寻找与当前文件相同的冗余文件。
                    SameFiles.Clear();
                    for (int j = i + 1; j < this.文件信息摘要集合.Count; j++)
                    {
                        文件信息摘要 tmpj = this.文件信息摘要集合[j];
                        if (tmpj.IsRepeat)//如果此文件已经比较过并且明确为冗余文件，则跳过此文件不进行比较。
                        {
                            continue;
                        }
                        if (tmpi.Length == tmpj.Length)
                        {
                            if (string.IsNullOrEmpty(tmpi.SHA1))
                            {
                                tmpi.SHA1 = 计算文件的SHA1(tmpi.FileName).Replace("-", "");
                            }
                            if (string.IsNullOrEmpty(tmpj.SHA1))
                            {
                                tmpj.SHA1 = 计算文件的SHA1(tmpj.FileName).Replace("-", "");
                            }
                            if (tmpi.SHA1 == tmpj.SHA1)
                            {
                                if (CompareFile(tmpi.FileName, tmpj.FileName))
                                {
                                    SameFiles.Add(tmpj);
                                    tmpj.IsRepeat = true;
                                }
                            }
                        }
                    }
                    #endregion

                    #region 将冗余文件添加到记录集。
                    if (SameFiles.Count > 0) //如果存在冗余文件。
                    {
                        TreeNode rootTreeNode = new TreeNode();
                        {
                            TreeNode subTreeNode = new TreeNode();
                            subTreeNode.Text = tmpi.FileName;
                            subTreeNode.Tag = tmpi;
                            this.添加节点(rootTreeNode.Nodes, subTreeNode);
                        }

                        this.冗余文件总数 += SameFiles.Count;
                        foreach (文件信息摘要 tmp in SameFiles)
                        {
                            TreeNode subTreeNode = new TreeNode();
                            subTreeNode.Text = tmp.FileName;
                            subTreeNode.Tag = tmp;
                            this.添加节点(rootTreeNode.Nodes, subTreeNode);
                        }
                        this.设置节点文本(rootTreeNode, string.Format("冗余文件 {0} 个 [大小：{2} Byte]：> {1}", SameFiles.Count, tmpi.FileName, tmpi.Length));
                        this.添加节点(this.treeView冗余文件.Nodes, rootTreeNode);

                    }
                    #endregion

                }
            }
            #endregion

            #region 清理冗余文件。
            if (this.treeView冗余文件.Nodes.Count > 0 && this.cb删除文件内容相同的冗余文件.Checked) //如果存在冗余文件。
            {
                this.当前正在执行的步骤 = 当前执行步骤.正在删除冗余文件;
                bool 是否指定了清理目录 = !string.IsNullOrEmpty(this.tb只从这里清理.Text);
                this.设置树视图更新状态(false);
                foreach (TreeNode rootNode in this.treeView冗余文件.Nodes)
                {
                    if (rootNode.Nodes.Count < 2)
                    {
                        continue;
                    }

                    int startIndex = (是否指定了清理目录 ? 0 : 1); //如果设置清理目录则从 0 开始遍历；否则从 1 开始遍历，保留第一个节点。
                    for (int i = startIndex; i < rootNode.Nodes.Count; i++)
                    {
                        TreeNode subNode = rootNode.Nodes[i];
                        文件信息摘要 tmp = subNode.Tag as 文件信息摘要;
                        if (是否指定了清理目录 && tmp.FileName.StartsWith(this.tb只从这里清理.Text) == false)
                        {
                            continue;
                        }

                        try
                        {
                            System.IO.File.SetAttributes(tmp.FileName, System.IO.FileAttributes.Normal);
                            System.IO.File.Delete(tmp.FileName);
                            this.成功清理文件总数++;
                            this.设置节点文本(subNode, string.Format("[删除完成] {0}", tmp.FileName));
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }

                }

            }
            #endregion

            this.停止文件处理线程(false);

        }

        private void 停止文件处理线程(bool 是否由用户终止线程)
        {
            if (this.文件处理线程 != null)
            {
                if (是否由用户终止线程)
                {
                    this.文件处理线程.Abort();
                }

                System.DateTime endTime = System.DateTime.Now;
                this.启动或停止提示信息计时器(false);
                this.设置进度条当前值(this.progressBar1.Minimum);
                this.设置操作项提示(是否由用户终止线程 ? "用户终止！" : "完成！");

                if (this.cb删除文件内容相同的冗余文件.Checked)
                {
                    this.设置进度提示(string.Format("冗余文件数：{0} 清理文件数：{1} 耗费时间：{2}"
                        , this.冗余文件总数
                        , this.成功清理文件总数
                        , this.转换时间到文本(endTime.Subtract(this.文件处理线程起始执行时间)))
                        );
                }
                else
                {
                    this.设置进度提示(string.Format("冗余文件数：{0} 耗费时间：{1}"
                        , this.冗余文件总数
                        , this.转换时间到文本(endTime.Subtract(this.文件处理线程起始执行时间)))
                        );
                }

                this.设置树视图更新状态(true);
                this.设置开始按钮文本("开始");
                this.设置文件列表面板Enabled属性(true);
                this.当前正在执行的步骤 = 当前执行步骤.操作结束;
                this.重新计算输出信息操作界面状态();
                this.文件处理线程 = null;
            }

        }
        #endregion

        private string 计算剩余时间()
        {
            int 当前正在处理的文件索引 = this.当前处理的文件索引;
            int 总共需要处理的文件数量 = this.文件信息摘要集合.Count;
            int 未处理的文件数量 = 总共需要处理的文件数量 - 当前正在处理的文件索引;
            System.DateTime 起始运行时间 = this.文件处理线程起始执行时间;
            System.DateTime 当前系统时间 = System.DateTime.Now;
            System.TimeSpan 已经耗费的时间 = 当前系统时间 - 起始运行时间;
            long 平均耗费时间 = 已经耗费的时间.Ticks / (当前正在处理的文件索引 + 1);

            System.TimeSpan 剩余时间 = new TimeSpan(平均耗费时间 * 未处理的文件数量);
            return this.转换时间到文本(剩余时间);

        }

        private string 转换时间到文本(System.TimeSpan t)
        {
            string s = "";

            if (t.Days > 0)
            {
                s = t.Days.ToString() + "天" + t.Hours.ToString("D2") + ":" + t.Minutes.ToString("D2") + ":" + t.Seconds.ToString("D2");
            }
            else if (t.Hours > 0)
            {
                s = t.Hours.ToString("D2") + ":" + t.Minutes.ToString("D2") + ":" + t.Seconds.ToString("D2");
            }
            else if (t.Minutes > 0)
            {
                s = "00:" + t.Minutes.ToString("D2") + ":" + t.Seconds.ToString("D2");
            }
            else
            {
                s = "00:00:" + t.Seconds.ToString("D2");
            }

            return s;

        }

        /// <summary>
        /// 计算文件的 SHA1 值。
        /// </summary>
        /// <param name="file">文件。</param>
        /// <returns>计算得出的文件 SHA1 值。</returns>
        private static string 计算文件的SHA1(string file)
        {
            byte[] bytes_sha1_out;
            System.IO.FileStream fs = new System.IO.FileStream(file, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
            try
            {
                System.Security.Cryptography.SHA1 sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                bytes_sha1_out = sha1.ComputeHash(fs);
            }
            finally
            {
                fs.Close();
            }
            return BitConverter.ToString(bytes_sha1_out);

        }

        /// <summary>
        /// 比较两个文件内容是否相同。注意：两个文件都不存在视为不相同。
        /// </summary>
        /// <param name="sourceFileName">原始文件。</param>
        /// <param name="destFileName">待比较文件。</param>
        /// <returns></returns>
        private static bool CompareFile(string sourceFileName, string destFileName)
        {
            System.IO.FileInfo sourceFileInfo = new System.IO.FileInfo(sourceFileName);
            System.IO.FileInfo destFileInfo = new System.IO.FileInfo(destFileName);
            if (!sourceFileInfo.Exists && !destFileInfo.Exists)
            {
                return false;
            }
            if (sourceFileInfo.Exists != destFileInfo.Exists)
            {
                return false;
            }
            if (sourceFileInfo.Length != destFileInfo.Length)//根据文件长度判断两文件是否相同。
            {
                return false;
            }

            System.IO.FileStream sourceFileStream = null;
            System.IO.FileStream destFileStream = null;
            try
            {
                sourceFileStream = sourceFileInfo.OpenRead();
                destFileStream = destFileInfo.OpenRead();
                if (sourceFileStream.Length != destFileStream.Length)//根据文件长度判断两文件是否相同。
                {
                    return false;
                }

                #region 循环比较文件内容是否相同。
                byte[] sourceBuffer = new byte[sourceFileStream.Length > 1024 ? 1024 : sourceFileStream.Length];
                byte[] destBuffer = new byte[destFileStream.Length > 1024 ? 1024 : destFileStream.Length];
                int sourceCount = 0;
                int destCount = 0;
                while (sourceFileStream.Position < sourceFileStream.Length)
                {
                    sourceCount = sourceFileStream.Read(sourceBuffer, 0, sourceBuffer.Length);
                    destCount = destFileStream.Read(destBuffer, 0, destBuffer.Length);
                    if (sourceCount != destCount)
                    {
                        return false;
                    }
                    for (int i = 0; i < sourceCount; i++)
                    {
                        if (sourceBuffer[i] != destBuffer[i])
                        {
                            return false;
                        }
                    }
                }
                #endregion

                return true;

            }
            finally
            {
                if (sourceFileStream != null)
                {
                    sourceFileStream.Close();
                    sourceFileStream = null;
                }
                if (destFileStream != null)
                {
                    destFileStream.Close();
                    destFileStream = null;
                }
            }

        }

    }
}
