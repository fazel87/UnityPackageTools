using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Global
{
    public static readonly string Global_Data_Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/UnityPackageTools/";
    public static readonly string Global_Cache_Path = Global_Data_Path + "cache/";

    public static string UnityPackage_Path = null;
    public static string UnityPackage_Extract_Path = null;

    public static bool Is_Format_correct = true;
    public static void create_data_folder()
    {
        Directory.CreateDirectory(Global.Global_Data_Path);
        Directory.CreateDirectory(Global.Global_Cache_Path);
        Directory.CreateDirectory(Global.Global_Cache_Path + "temp_dir");
        Directory.CreateDirectory(Global.Global_Cache_Path + "temp_dir2");
    }
    public static void delete_cache_and_temp()
    {
        string temp_dir1 = Global.Global_Cache_Path + "temp_dir";
        string temp_dir2 = Global.Global_Cache_Path + "temp_dir2";
        string temp_file = Global.Global_Cache_Path + "temp";

        try
        {
            if (Directory.Exists(temp_dir1))
                Directory.Delete(temp_dir1, true);

            if (Directory.Exists(temp_dir1))
                Directory.Delete(temp_dir2, true);

            if (File.Exists(temp_file))
                File.Delete(temp_file);
        }
        catch{}
    }
    public static void Reset_data_files()
    {
        delete_cache_and_temp();
        create_data_folder();
    }
}