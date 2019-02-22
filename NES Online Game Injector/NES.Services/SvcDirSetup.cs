using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Online_Game_AutoInjector.Services
{
    internal class SvcDirSetup
    {
        private static string cd = Environment.CurrentDirectory;

        public static void PrepareCache()
        {
            if (!Directory.Exists(cd + "\\Common"))
            {
                Directory.CreateDirectory(cd + "\\Common");
                Directory.CreateDirectory(cd + "\\Common\\Cache");
                Directory.CreateDirectory(cd + "\\Common\\Cache\\Updates");
                return;
            }
        }
    }
}