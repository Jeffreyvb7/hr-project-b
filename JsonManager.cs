using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Applicatie
{
    public class JsonManager
    {
    
        private static string GetPath<T>(string folderName) =>
            $@"./{folderName}/";

        private static string GetPath<T>(string folderName, string fileName) =>
            fileName.EndsWith(".json")
                ? $@"./{folderName}/{fileName}"
                : $@"./{folderName}/{fileName}.json";

        public static T GetData<T>(string folderName, string fileName)
        {
            string jsonData = File.ReadAllText(GetPath<T>(folderName, fileName));
            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public static List<T> GetAllData<T>(string folderName)
        {
            DirectoryInfo directory = new DirectoryInfo(GetPath<T>(folderName));
            FileInfo[] files = directory.GetFiles("*.json");
            return files.Select(file => GetData<T>(folderName, file.Name)).ToList();
        }

        public static void SaveData<T>(T data, string folderName, string fileName) {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(GetPath<T>(folderName, fileName), jsonData);
        }

        public static bool DeleteData<T>(string folderName, string fileName) {
            string path = GetPath<T>(folderName, fileName);

            if (File.Exists(path)) {
                File.Delete(path);
                return true;
            }

            return false;
        }
    }
}
