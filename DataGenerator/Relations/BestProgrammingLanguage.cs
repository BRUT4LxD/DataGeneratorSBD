using DataGenerator.Model;

namespace DataGenerator.Relations
{
    internal class BestProgrammingLanguage
    {
        public Person Person { get; set; }
        public ProgrammingLanguage Skill { get; set; }
        public int YearsOfExperience { get; set; }
    }
}
