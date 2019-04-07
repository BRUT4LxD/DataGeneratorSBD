using DataGenerator.Generators;
using System;

namespace DataGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var modelGenerator = new ModelGenerator();

            var persons = modelGenerator.GeneratePersons(500);
            var companies = modelGenerator.GenerateCompanies();
            var countries = modelGenerator.GenerateCountries();
            var hobbies = modelGenerator.GenerateHobbies();
            var jobs = modelGenerator.GenerateJobs();
            var languages = modelGenerator.GenerateLanguages();
            var programmingLanguages = modelGenerator.GenerateProgrammingLanguages();
            var universities = modelGenerator.GenerateUniversities();
            var technologies = modelGenerator.GenerateTechnologies();
            
            IOManager.SaveCsv(persons);
            IOManager.SaveCsv(companies);
            IOManager.SaveCsv(countries);
            IOManager.SaveCsv(hobbies);
            IOManager.SaveCsv(jobs);
            IOManager.SaveCsv(languages);
            IOManager.SaveCsv(programmingLanguages);
            IOManager.SaveCsv(universities);
            IOManager.SaveCsv(technologies);

            var relationGenerator = new RelationGenerator();

            IOManager.SaveCsv(relationGenerator.GenerateBestProgrammingLanguages(persons, programmingLanguages));
            IOManager.SaveCsv(relationGenerator.GenerateBestTechnologies(persons, technologies));
            IOManager.SaveCsv(relationGenerator.GenerateHaves(persons, hobbies));
            IOManager.SaveCsv(relationGenerator.GenerateKnows(persons));
            IOManager.SaveCsv(relationGenerator.GenerateLivings(persons, countries));
            IOManager.SaveCsv(relationGenerator.GenerateSpeaks(persons, languages));
            IOManager.SaveCsv(relationGenerator.GenerateStudying(persons, universities));
            IOManager.SaveCsv(relationGenerator.GenerateWorksAs(persons, jobs));
            IOManager.SaveCsv(relationGenerator.GenerateWorksIn(persons, companies));
        }
    }
}
