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
    }
}
