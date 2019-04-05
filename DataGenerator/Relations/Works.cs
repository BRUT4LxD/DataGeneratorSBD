using DataGenerator.Model;

namespace DataGenerator.Relations
{
    internal class Works
    {
        public Person Person { get; set; }
        public Company Company { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}
