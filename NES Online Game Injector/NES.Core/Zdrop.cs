using System.Diagnostics;

namespace NES_Online_Game_Injector.Core
{
    internal class Zdrop
    {
        private Process Zconvert = new Process();

        public Zdrop()
        {
            Zconvert.StartInfo.FileName = "zdrop.exe";
            Zconvert.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        }

        public void RunCommand(string Args)
        {
            Zconvert.StartInfo.Arguments = Args;
            Zconvert.Start();
            Zconvert.WaitForExit();
        }
    }
}