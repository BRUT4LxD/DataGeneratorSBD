using DataGenerator.Model;

namespace DataGenerator.Relations
{
    internal class HaveSkill
    {
        public Person Person { get; set; }
        public Skill Skill { get; set; }
        public string Level { get; set; }

    }
}
