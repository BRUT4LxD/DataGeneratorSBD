using DataGenerator.Model;
using System.Collections.Generic;

namespace DataGenerator.Generators
{
    internal interface IModelGenerator
    {
        List<Company> GenerateCompanies();
        List<City> GenerateCountries();
        List<University> GenerateUniversities();
        List<Hobby> GenerateHobbies();
        List<Technology> GenerateTechnologies();
        List<Language> GenerateLanguages();
        List<Job> GenerateJobs();
        List<Person> GeneratePersons(int number);
        List<ProgrammingLanguage> GenerateProgrammingLanguages();
    }
}