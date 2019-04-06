using DataGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataGenerator
{

    internal class ModelGenerator : IModelGenerator
    {
        private readonly Random _random = new Random(331);
        public List<Company> GenerateCompanies()
        {
            return Data.Companies.Select(e => new Company { Name = e, BrandPower = _random.Next(500, 1500) }).ToList();
        }

        public List<Country> GenerateCountries()
        {
            return Data.Cities.Select(e => new Country { City = e, Name = "Poland" }).ToList();
        }

        public List<University> GenerateUniversities()
        {
            var universities = new List<University>();
            const int maxSemester = 11;

            foreach (var university in Data.University)
            {
                foreach (var specialization in Data.Specializations)
                {
                    for (var i = 0; i < maxSemester; i++)
                    {
                        universities.Add(new University { Name = university, Semester = i, Specialization = specialization });
                    }
                }
            }

            return universities;
        }

        public List<Hobby> GenerateHobbies()
        {
            return Data.Hobbies.Select(e => new Hobby { Name = e }).ToList();
        }

        public List<Technology> GenerateTechnologies()
        {
            return Data.Technologies.Select(e => new Technology { Name = e }).ToList();
        }

        public List<Language> GenerateLanguages()
        {
            return Data.Languages.Select(e => new Language { Name = e }).ToList();
        }

        public List<Job> GenerateJobs(int number)
        {
            var jobNamesNumber = Data.Jobs.Count;
            var jobs = new List<Job>();
            for (var i = 0; i < number; i++)
            {
                jobs.Add(new Job
                {
                    AverageSalary = _random.Next(8000, 25000),
                    Name = Data.Jobs[_random.Next(jobNamesNumber)]
                });
            }

            return jobs;
        }

        public List<Person> GeneratePersons(int number)
        {
            var namesCount = Data.PersonNames.Count;
            var surnamesCount = Data.PersonSurnames.Count;
            var persons = new List<Person>();

            for (var i = 0; i < number; i++)
            {
                persons.Add(new Person
                {
                    Age = _random.Next(18, 50),
                    Id = i,
                    Name = Data.PersonNames[_random.Next(namesCount)],
                    Surname = Data.PersonSurnames[_random.Next(surnamesCount)],
                    Salary = _random.Next(5000, 50000)
                });
                persons[i].Sex = persons[i].Name[persons[i].Name.Length - 1] == 'a' ? "Kobieta" : "Mężczyzna";
            }

            return persons;
        }

        public List<ProgrammingLanguage> GenerateProgrammingLanguages(int number)
        {
            return Data.ProgrammingLanguages.Select(e => new ProgrammingLanguage { Name = e }).ToList();
        }

    }
}
