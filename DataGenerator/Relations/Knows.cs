using DataGenerator.Model;

namespace DataGenerator.Relations
{
    internal class Knows
    {
        public Person Person1 { get; set; }
        public Person Person2 { get; set; }
        public string Since { get; set; }
    }
}
