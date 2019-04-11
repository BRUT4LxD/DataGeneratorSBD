using DataGenerator.Model;
using DataGenerator.Relations;
using System.Collections.Generic;

namespace DataGenerator.Generators
{
    internal interface IRelationsGenerator
    {
        List<Have> GenerateHaves(List<Person> persons, List<Hobby> hobbies);
        List<Knows> GenerateKnows(List<Person> persons);
        List<Lives> GenerateLivings(List<Person> persons, List<City> countries);
        List<Speaks> GenerateSpeaks(List<Person> persons, List<Language> languages);
        List<Studies> GenerateStudying(List<Person> persons, List<University> universities);
        List<WorksIn> GenerateWorksIn(List<Person> persons, List<Company> companies);
        List<WorksAs> GenerateWorksAs(List<Person> persons, List<Job> jobs);
        List<BestProgrammingLanguage> GenerateBestProgrammingLanguages(List<Person> persons, List<ProgrammingLanguage> languages);
        List<BestTechnology> GenerateBestTechnologies(List<Person> persons, List<Technology> technologies);
    }
}
