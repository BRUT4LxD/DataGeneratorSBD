using DataGenerator.Model;

namespace DataGenerator.Relations
{
    internal class Studies
    {
        public Person Person { get; set; }
        public University University { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}
