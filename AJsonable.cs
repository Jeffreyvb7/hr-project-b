using System.Collections.Generic;

namespace Applicatie
{
    // Put in a library so other people can't directly access it
    internal abstract class AJsonable
    {
        // Deze methods moeten in subclasses als EscapeRoom worden geïmplementeerd
        public abstract void Save();
        public abstract void Edit();

        // Deze methods kunnen vanuit elke class gebruikt worden
        // De implementatie is voor alle classes hetzelfde en op ieder moment te gebruiken
        public static bool Delete<T>(string folderName, string fileName) =>
            JsonManager.DeleteData<T>(folderName, fileName);

        public static T Get<T>(string folderName, string fileName) where T : AJsonable =>
            JsonManager.GetData<T>(folderName, fileName);

        public static List<T> GetAll<T>(string folderName) where T : AJsonable =>
            JsonManager.GetAllData<T>(folderName);

        public static string GetPath(string folderName, string fileName) =>
            JsonManager.GetPath<string>(folderName, fileName);
    }
}
