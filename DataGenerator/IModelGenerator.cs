using DataGenerator.Model;
using System.Collections.Generic;

namespace DataGenerator
{
    internal interface IModelGenerator
    {
        List<Company> GenerateCompanies();
        List<Country> GenerateCountries();
        List<Job> GenerateJobs(int number);
        List<Person> GeneratePersons(int number);
        List<Skill> GenerateSkills(int number);
        List<University> GenerateUniversities(int number);

    }
}