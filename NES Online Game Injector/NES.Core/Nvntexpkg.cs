using System.Diagnostics;

namespace NES_Online_Game_Injector.Core
{
    internal class Nvntexpkg
    {
        private Process Nconvert = new Process();

        public Nvntexpkg()
        {
            Nconvert.StartInfo.FileName = "NvnTexpkg.exe";
            Nconvert.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        }

        public void RunCommand(string Args)
        {
            Nconvert.StartInfo.Arguments = Args;
            Nconvert.Start();
            Nconvert.WaitForExit();
        }
    }
}