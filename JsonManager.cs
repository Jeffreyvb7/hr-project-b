using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Applicatie
{
    public class JsonManager
    {
    
        private static string GetPath<T>(string fldrName) =>
            $@"./{fldrName}/";

        private static string GetPath<T>(string fldrName, string fleName) =>
            fleName.EndsWith(".json")
                ? $@"./{fldrName}/{fleName}"
                : $@"./{fldrName}/{fleName}.json";

        public static T GetData<T>(string fldrName, string name)
        {
            string r = File.ReadAllText(GetPath<T>(fldrName, name));
            return JsonConvert.DeserializeObject<T>(r);
        }

        public static List<T> GetAllData<T>(string fldrName)
        {
            DirectoryInfo directory = new DirectoryInfo(GetPath<T>(fldrName));
            FileInfo[] files = directory.GetFiles("*.json");
            return files.Select(file => GetData<T>(fldrName, file.Name)).ToList();
        }

        public static void SaveData<T>(T data, string fldrName, string name) {
            string r = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(GetPath<T>(fldrName, name), r);
        }

        public static bool DeleteData<T>(string flrdName, string name) {
            string path = GetPath<T>(flrdName, name);

            if (File.Exists(path)) {
                File.Delete(path);
                return true;
            }

            return false;
        }
    }
}
