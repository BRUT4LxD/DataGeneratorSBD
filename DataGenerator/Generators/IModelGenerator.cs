using DataGenerator.Model;
using System.Collections.Generic;

namespace DataGenerator
{
    internal interface IModelGenerator
    {
        List<Company> GenerateCompanies();
        List<Country> GenerateCountries();
        List<University> GenerateUniversities();
        List<Hobby> GenerateHobbies();
        List<Technology> GenerateTechnologies();
        List<Language> GenerateLanguages();
        List<Job> GenerateJobs(int number);
        List<Person> GeneratePersons(int number);
        List<ProgrammingLanguage> GenerateProgrammingLanguages(int number);
    }
}