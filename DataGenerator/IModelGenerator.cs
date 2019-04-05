﻿using DataGenerator.Model;
using System.Collections.Generic;

namespace DataGenerator
{
    internal interface IModelGenerator
    {
        List<Company> GenerateCompanies(int number);
        List<Country> GenerateCountries(int number);
        List<Job> GenerateJobs(int number);
        List<Person> GeneratePersons(int number);
        List<Skill> GenerateSkills(int number);
        List<University> GenerateUniversities(int number);

    }
}