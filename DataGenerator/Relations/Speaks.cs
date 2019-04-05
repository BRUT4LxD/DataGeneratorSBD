using DataGenerator.Model;

namespace DataGenerator.Relations
{
    internal class Speaks
    {
        public Person Person { get; set; }
        public Language Language { get; set; }
        public string Level { get; set; }
    }
}
