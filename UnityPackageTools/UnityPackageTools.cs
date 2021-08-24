using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Tar;
using System.Threading;
using System.Windows.Forms;

namespace UnityPackageTools
{
    [Obsolete]
    class UnityPackage_Extract_Tools
    {
        private static void extract_to_folder()
        {
            Global.Reset_data_files();
            Extract_Tar_GZIP(Global.UnityPackage_Path);
            Check_UnityPackage_Format(Global.Global_Cache_Path + "temp_dir");
            if (Global.Is_Format_correct)
                ReadUnityPackageFiles(Global.Global_Cache_Path + "temp_dir", Global.UnityPackage_Extract_Path);
            else
                MessageBox.Show("The selected UnityPackage format is corrupted", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Global.Reset_data_files();
        }
        public static void Extract_To_Folder()
        {
            new Thread(extract_to_folder).Start();
        }
        public static void Decompress_GZIP(FileInfo fileToDecompress, string Path_newFile)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = Path_newFile;

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        try
                        {
                            decompressionStream.CopyTo(decompressedFileStream);
                        }
                        catch
                        {
                            Global.Is_Format_correct = false;
                        }
                    }
                }
            }
        }
        public static void ExtractTar(string tarFileName, string destFolder)
        {
            Stream inStream = File.OpenRead(tarFileName);
            TarArchive tarArchive = TarArchive.CreateInputTarArchive(inStream);
            TarArchive tarArchive2 = TarArchive.CreateOutputTarArchive(inStream);

            try
            {
                tarArchive.ExtractContents(destFolder);

            }
            catch (TarException)
            {
                Global.Is_Format_correct = false;
            }
            finally
            {
                tarArchive.Close();
                inStream.Close();
            }
        }
        public static void ReadUnityPackageFiles(string RootUnityPackage_Extracted, string SaveFiles_Path)
        {
            DirectoryInfo dir_info = new DirectoryInfo(RootUnityPackage_Extracted);
            foreach (DirectoryInfo dir in dir_info.GetDirectories())
            {
                try
                {
                    string dirpath = dir.FullName;
                    string asset = File.ReadAllText(dirpath + "/asset", Encoding.Default);
                    string asset_meta = File.ReadAllText(dirpath + "/asset.meta", Encoding.Default);
                    string FullName = File.ReadAllText(dirpath + "/pathname", Encoding.Default);
                    string path = Path.GetDirectoryName(FullName);
                    string fileName = Path.GetFileName(FullName);
                    string original_path = SaveFiles_Path + "/" + path + "/";

                    Directory.CreateDirectory(original_path);
                    File.WriteAllText(original_path + fileName, asset);
                    File.WriteAllText(original_path + fileName + ".meta", asset_meta);
                }
                catch { }
            }
        }
        public static void Extract_Tar_GZIP(string source)
        {
            Decompress_GZIP(new FileInfo(source), Global.Global_Cache_Path + "temp");
            ExtractTar(Global.Global_Cache_Path + "temp", Global.Global_Cache_Path + "temp_dir");
        }
        public static void Check_UnityPackage_Format(string RootUnityPackage_Extracted)
        {
            DirectoryInfo dir_info = new DirectoryInfo(RootUnityPackage_Extracted);
            foreach (DirectoryInfo dir in dir_info.GetDirectories())
            {
                if (!File.Exists(dir.FullName + "/asset.meta") || !File.Exists(dir.FullName + "/pathname"))
                {
                    Global.Is_Format_correct = false;
                }
            }
            return;
        }
        public static void ConvertToZIP(string zip_path)
        {
            Global.Reset_data_files();
            Extract_Tar_GZIP(Global.UnityPackage_Path);
            Check_UnityPackage_Format(Global.Global_Cache_Path + "temp_dir");
            if (Global.Is_Format_correct)
                ReadUnityPackageFiles(Global.Global_Cache_Path + "temp_dir", Global.Global_Cache_Path + "temp_dir2");
            else
            {
                MessageBox.Show("The selected UnityPackage format is corrupted", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ZipFile.CreateFromDirectory(Global.Global_Cache_Path + "temp_dir2", zip_path);
            Global.Reset_data_files();
        }
        public static void ConvertToTAR(string tar_path)
        {
            Global.Reset_data_files();
            Extract_Tar_GZIP(Global.UnityPackage_Path);
            Check_UnityPackage_Format(Global.Global_Cache_Path + "temp_dir");
            if (Global.Is_Format_correct)
                ReadUnityPackageFiles(Global.Global_Cache_Path + "temp_dir", Global.Global_Cache_Path + "temp_dir2");
            else
            {
                MessageBox.Show("The selected UnityPackage format is corrupted", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UnityPackage_CompressTools.CreateTar(Global.Global_Cache_Path + "temp_dir2", tar_path);
            Global.Reset_data_files();
        }
        public static void ConvertToTGZ(string tar_path)
        {
            Global.Reset_data_files();
            Extract_Tar_GZIP(Global.UnityPackage_Path);
            Check_UnityPackage_Format(Global.Global_Cache_Path + "temp_dir");
            if (Global.Is_Format_correct)
                ReadUnityPackageFiles(Global.Global_Cache_Path + "temp_dir", Global.Global_Cache_Path + "temp_dir2");
            else
            {
                MessageBox.Show("The selected UnityPackage format is corrupted", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UnityPackage_CompressTools.CreateTGZ(Global.Global_Cache_Path + "temp_dir2", tar_path);
            Global.Reset_data_files();
        }
    }
    public static class UnityPackage_CompressTools
    {
        #region Tar.GZ
        public static void CreateTGZ(string sourceDirectory, string TGZ_Path)
        {
            string tgzFileName = Path.GetFileName(TGZ_Path);
            string targetDirectory = Path.GetDirectoryName(TGZ_Path);

            using (var outStream = File.Create(Path.Combine(targetDirectory, tgzFileName)))
            using (var gzoStream = new GZipStream(outStream, CompressionLevel.Optimal))
            {
                var tarArchive = TarArchive.CreateOutputTarArchive(gzoStream);

                tarArchive.RootPath = sourceDirectory.Replace('\\', '/');
                if (tarArchive.RootPath.EndsWith("/"))
                {
                    tarArchive.RootPath = tarArchive.RootPath.Remove(tarArchive.RootPath.Length - 1);
                }

                AddDirectoryFilesToTar(tarArchive, sourceDirectory);

                tarArchive.Close();
            }
        }
        #endregion
        #region Tar
        public static void CreateTar(string sourceDirectory, string Tar_Path)
        {
            string tarFileName = Path.GetFileName(Tar_Path);
            string targetDirectory = Path.GetDirectoryName(Tar_Path);

            using (var outStream = File.Create(Path.Combine(targetDirectory, tarFileName)))
            {
                var tarArchive = TarArchive.CreateOutputTarArchive(outStream);

                tarArchive.RootPath = sourceDirectory.Replace('\\', '/');
                if (tarArchive.RootPath.EndsWith("/"))
                {
                    tarArchive.RootPath = tarArchive.RootPath.Remove(tarArchive.RootPath.Length - 1);
                }

                AddDirectoryFilesToTar(tarArchive, sourceDirectory);

                tarArchive.Close();
            }
        }
        private static void AddDirectoryFilesToTar(TarArchive tarArchive, string sourceDirectory)
        {
            AddDirectoryFilesToTar(tarArchive, sourceDirectory, string.Empty);
        }
        private static void AddDirectoryFilesToTar(TarArchive tarArchive, string sourceDirectory, string currentDirectory)
        {
            var pathToCurrentDirectory = Path.Combine(sourceDirectory, currentDirectory);

            // Write each file to the tgz.
            var filePaths = Directory.GetFiles(pathToCurrentDirectory);
            foreach (string filePath in filePaths)
            {
                var tarEntry = TarEntry.CreateEntryFromFile(filePath);

                // Name sets where the file is written. Write it in the same spot it exists in the source directory
                tarEntry.Name = filePath.Replace(sourceDirectory, "");

                // If the Name starts with '\' then an extra folder (with a blank name) will be created, we don't want that.
                if (tarEntry.Name.StartsWith(@"\"))
                {
                    tarEntry.Name = tarEntry.Name.Substring(1);
                }
                tarArchive.WriteEntry(tarEntry, true);
            }

            // Write directories to tgz
            var directories = Directory.GetDirectories(pathToCurrentDirectory);
            foreach (string directory in directories)
            {
                AddDirectoryFilesToTar(tarArchive, sourceDirectory, directory);
            }
        }
        #endregion
    }
}
