

namespace Timekeeping
{
    public sealed class Serialization
    {
        public static bool FileExistenceCheck(string filename)
        {
            return File.Exists(filename);
        }

        public static bool FolderExistenceCheck(string path)
        {
            return Directory.Exists(path);
        }

        public static string[] ReadTextFileByLine(string path)
        {
            return File.ReadAllLines(path);
        }

        public static void SaveToTextFile(string content, string filename)
        {
            File.WriteAllText(filename, content);
        }

        public static void CreateFolder(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
