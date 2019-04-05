using DataGenerator.Model;
using DataGenerator.Relations;
using System.Collections.Generic;

namespace DataGenerator
{
    internal class RelationGenerator : IRelationsGenerator
    {
        public List<Have> GenerateHaves(List<Person> persons, List<Hobby> hobbies)
        {
            throw new System.NotImplementedException();
        }

        public List<HaveSkill> GenerateHaveSkills(List<Person> persons, List<Skill> skills)
        {
            throw new System.NotImplementedException();
        }

        public List<Knows> GenerateKnows(List<Person> persons, List<Person> persons2)
        {
            throw new System.NotImplementedException();
        }

        public List<Lives> GenerateLivings(List<Person> persons, List<Country> countries)
        {
            throw new System.NotImplementedException();
        }

        public List<Speaks> GenerateSpeaks(List<Person> persons, List<Language> languages)
        {
            throw new System.NotImplementedException();
        }

        public List<Studies> GenerateStudying(List<Person> persons, List<University> universities)
        {
            throw new System.NotImplementedException();
        }

        public List<Works> GenerateWorks(List<Person> persons, List<Job> jobs)
        {
            throw new System.NotImplementedException();
        }
    }
}
