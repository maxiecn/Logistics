using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace LogisticsClient
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SkinManager.EnableFormSkins();
            BonusSkins.Register();
            Application.Run(new FrmMain());
        }
    }
}