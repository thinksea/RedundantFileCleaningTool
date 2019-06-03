using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Thinksea冗余文件清理工具
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form冗余文件清理工具());
        }
    }
}
