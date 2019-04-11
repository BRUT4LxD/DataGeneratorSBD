using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

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
            var x = typeof(T).GetProperties().ToList();

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

            using (var file = new StreamWriter(typeof(T).Name + "_insert.csv"))
            {
                if (!IsModel(typeof(T).Name))
                {
                    CreateRelationInserts(list, x, file);
                }
                else
                {
                    CreateModelInserts(list, x, file);
                }


            }
        }

        private static bool IsModel(string className)
        {
            return className != "BestProgrammingLanguage" && className != "BestTechnology" && className != "Have" && className != "Knows" && className != "Lives" && className != "Speaks" && className != "Studies" && className != "WorksIn" && className != "WorksAs";
        }

        private static void CreateModelInserts<T>(IEnumerable<T> list, IReadOnlyCollection<PropertyInfo> x, TextWriter file)
        {
            foreach (var element in list)
            {
                string line = "INSERT INTO dbo." + typeof(T).Name + "(";
                line += string.Join(",", x.Select(e => e.Name).ToList()) + ")\n";
                var values = x.Select(e => "'" + element.GetType().GetProperty(e.Name)?.GetValue(element).ToString() + "'").ToList();
                line += "VALUES(" + string.Join(",", values) + ")";
                file.WriteLine(line);
            }
        }

        private static void CreateRelationInserts<T>(IEnumerable<T> list, IReadOnlyCollection<PropertyInfo> x,
            TextWriter file)
        {
            var content = x.Skip(2).ToList();
            var connection = x.Take(2).ToList();
            foreach (var element in list)
            {
                string line = "\n\n INSERT INTO " + typeof(T).Name + "($from_id ,$to_id";

                if (x.Count > 2)
                {
                    line += ",";
                    line += string.Join(",", content.Select(e => e.Name).ToList()) + ")\n";
                }
                else
                {
                    line += ")";
                }

                var values = connection.Select(e => "\n(SELECT $node_id from " + e
                                                                             + " where " + e.Name
                                                                             + "='" + element.GetType().GetProperty(e.Name)?.GetValue(element).ToString() + "')").ToList();
                values.AddRange(content.Select(e => "'" + element.GetType().GetProperty(e.Name)?.GetValue(element).ToString() + "'"));
                line += "\nVALUES(" + string.Join(",", values) + ")";
                file.WriteLine(line);
            }
        }
    }
}
