using DataGenerator.Model;
using DataGenerator.Relations;
using System;
using System.Collections.Generic;

namespace DataGenerator.Generators
{
    internal class RelationGenerator : IRelationsGenerator
    {
        private readonly Random _random = new Random(2123);
        public List<Have> GenerateHaves(List<Person> persons, List<Hobby> hobbies)
        {
            var haves = new List<Have>();
            foreach (var person in persons)
            {
                haves.Add(new Have { PersonId = person.Id, Hobby = hobbies[_random.Next(hobbies.Count)].Name });
            }

            return haves;
        }

        public List<Knows> GenerateKnows(List<Person> persons)
        {
            var knows = new List<Knows>();
            List<int> ids;
            DateTime minDate = new DateTime(2011, 1, 1);
            var maxDays = DateTime.Now.Subtract(minDate).Days;
            foreach (var person in persons)
            {

                int connections = _random.Next(50);
                ids = new List<int> { person.Id };
                for (var i = 0; i < connections; i++)
                {
                    var personId = _random.Next(persons.Count);

                    while (ids.Contains(personId))
                    {
                        personId = _random.Next(persons.Count);
                    }

                    knows.Add(new Knows { Person1Id = person.Id, Person2Id = persons[personId].Id, Since = minDate.AddDays(_random.Next(maxDays)).ToString("d") });
                }
            }

            return knows;

        }

        public List<Lives> GenerateLivings(List<Person> persons, List<Country> countries)
        {
            var livings = new List<Lives>();
            foreach (var person in persons)
            {
                livings.Add(new Lives { PersonId = person.Id, Country = countries[_random.Next(countries.Count)].City });
            }

            return livings;
        }

        public List<Speaks> GenerateSpeaks(List<Person> persons, List<Language> languages)
        {
            const int maxLang = 4;
            var speaks = new List<Speaks>();
            var ids = new List<int>();
            foreach (var person in persons)
            {
                int numOfLanguages = _random.Next(1, maxLang);
                for (var i = 0; i < numOfLanguages; i++)
                {
                    int lang = _random.Next(languages.Count);
                    while (ids.Contains(lang))
                    {
                        lang = _random.Next(languages.Count);
                    }

                    speaks.Add(new Speaks { PersonId = person.Id, Language = languages[lang].Name, Level = Data.LanguageLevel[_random.Next(5)] });
                }
            }

            return speaks;
        }

        public List<Studies> GenerateStudying(List<Person> persons, List<University> universities)
        {
            var studies = new List<Studies>();
            const int maxSemester = 11;
            foreach (var person in persons)
            {
                studies.Add(new Studies { PersonId = person.Id, UniversityId = universities[_random.Next(universities.Count)].Id, Semester = _random.Next(maxSemester) + 1 });
            }

            return studies;
        }

        public List<WorksIn> GenerateWorksIn(List<Person> persons, List<Company> companies)
        {

            var worksIn = new List<WorksIn>();
            foreach (var person in persons)
            {

                var minDate = new DateTime(2018, 5, 5);
                var start = _random.Next(200);
                var end = _random.Next(500) + start;
                worksIn.Add(new WorksIn
                {
                    PersonId = person.Id,
                    Company = companies[_random.Next(companies.Count)].Name,
                    Start = minDate.AddDays(start).ToString("d"),
                    End = minDate.AddDays(end).Ticks > DateTime.Now.Ticks ? "---" : minDate.AddDays(end).ToString("d")
                });

            }

            return worksIn;
        }

        public List<WorksAs> GenerateWorksAs(List<Person> persons, List<Job> jobs)
        {
            var worksAs = new List<WorksAs>();
            foreach (var person in persons)
            {
                worksAs.Add(new WorksAs { PersonId = person.Id, Job = jobs[_random.Next(jobs.Count)].Name });
            }

            return worksAs;
        }

        public List<BestProgrammingLanguage> GenerateBestProgrammingLanguages(List<Person> persons, List<ProgrammingLanguage> languages)
        {
            var bestProgrammingLanguages = new List<BestProgrammingLanguage>();
            foreach (var person in persons)
            {
                bestProgrammingLanguages.Add(new BestProgrammingLanguage { PersonId = person.Id, Skill = languages[_random.Next(languages.Count)].Name, YearsOfExperience = _random.Next(1, 15) });
            }

            return bestProgrammingLanguages;
        }

        public List<BestTechnology> GenerateBestTechnologies(List<Person> persons, List<Technology> technologies)
        {
            var bestTechnology = new List<BestTechnology>();
            foreach (var person in persons)
            {
                bestTechnology.Add(new BestTechnology { PersonId = person.Id, Technology = technologies[_random.Next(technologies.Count)].Name, YearsOfExperience = _random.Next(1, 15) });
            }

            return bestTechnology;
        }
    }
}
