using MaterialSkin;
using NES_Online_Game_Injector.GUI;
using System;
using System.Windows.Forms;

namespace NES_Online_Game_Injector
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        public static void EnableVisualStyles()
        {
            MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
            skinmgr.Theme = MaterialSkinManager.Themes.DARK;
            skinmgr.ColorScheme = new ColorScheme(Primary.LightGreen400, Primary.LightGreen400, Primary.LightGreen400, Accent.Red100, TextShade.WHITE);
            return;
        }

        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UIMain());
        }
    }
}