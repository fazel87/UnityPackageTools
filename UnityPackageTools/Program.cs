using System;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using ICSharpCode.SharpZipLib.Tar;

namespace UnityPackageTools
{
    static class Program
    {
        [STAThread, Obsolete]
        static void Main()
        {
            Global.Reset_data_files();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
            //CreateTar(@"C:\Users\Fazel\Desktop\UnityPackageToolsTest", "unitypackagetools.tar", @"C:\Users\Fazel\Desktop\");
        }

    }
}
