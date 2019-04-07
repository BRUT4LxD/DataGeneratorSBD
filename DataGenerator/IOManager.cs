using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataGenerator
{
    internal static class IOManager
    {
        public static List<string> LoadFile(string path)
        {
            return File.ReadAllLines(path).ToList();
        }

        public static void SaveCsv<T>(List<T> list)
        {
            var x = typeof(T).GetProperties();

            using (var file = new StreamWriter(typeof(T).Name + ".csv"))
            {
                var propertiesNames = x.Select(e => e.Name).ToList();
                file.WriteLine(string.Join(";", propertiesNames));
                foreach (var element in list)
                {
                    var values = x.Select(e => element.GetType().GetProperty(e.Name)?.GetValue(element).ToString()).ToList();
                    file.WriteLine(string.Join(";", values));
                }
            }

        }
    }
}
