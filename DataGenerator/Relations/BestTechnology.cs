using DataGenerator.Model;

namespace DataGenerator.Relations
{
    internal class BestTechnology
    {
        public Person Person { get; set; }
        public Technology Technology { get; set; }
        public int YearsOfExperience { get; set; }
    }
}
