using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Applicatie
{
    public class JsonManager
    {
        
        // $@"./{default(T).GetType().Name}s/";
        private static string GetPath<T>() =>
            $@"./EscapeRooms/";

        private static string GetPath<T>(string fleName) =>
            fleName.EndsWith(".json")
                ? $@"./EscapeRooms/{fleName}"
                : $@"./EscapeRooms/{fleName}.json";

        public static T GetData<T>(string name)
        {
            string r = File.ReadAllText(GetPath<T>(name));
            return JsonConvert.DeserializeObject<T>(r);
        }

        public static List<T> GetAllData<T>()
        {
            DirectoryInfo directory = new DirectoryInfo(GetPath<T>());
            FileInfo[] files = directory.GetFiles("*.json");
            return files.Select(file => GetData<T>(file.Name)).ToList();
        }

        public static void SaveData<T>(T data, string name) {
            string r = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(GetPath<T>(name), r);
        }

        public static bool DeleteData<T>(string name) {
            string path = GetPath<T>(name);

            if (File.Exists(path)) {
                File.Delete(path);
                return true;
            }

            return false;
        }
    }
}
