using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using UpdateFile;

namespace Updater
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            TUpdate up = new TUpdate();
            up.UpdateFiles();
            up.StartPro();
        }
    }
}
