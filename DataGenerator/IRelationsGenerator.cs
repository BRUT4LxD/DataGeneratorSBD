using DataGenerator.Model;
using DataGenerator.Relations;
using System.Collections.Generic;

namespace DataGenerator
{
    internal interface IRelationsGenerator
    {
        List<Have> GenerateHaves(List<Person> persons, List<Hobby> hobbies);
        List<HaveSkill> GenerateHaveSkills(List<Person> persons, List<ProgrammingLanguage> skills);
        List<Knows> GenerateKnows(List<Person> persons, List<Person> persons2);
        List<Lives> GenerateLivings(List<Person> persons, List<Country> countries);
        List<Speaks> GenerateSpeaks(List<Person> persons, List<Language> languages);
        List<Studies> GenerateStudying(List<Person> persons, List<University> universities);
        List<Works> GenerateWorks(List<Person> persons, List<Job> jobs);
    }
}
