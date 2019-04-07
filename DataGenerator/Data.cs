using System.Collections.Generic;

namespace DataGenerator
{
    internal static class Data
    {
        public static readonly List<string> PersonNames = IOManager.LoadFile("..\\Resources\\PersonNames.txt");
        public static readonly List<string> PersonSurnames = IOManager.LoadFile("..\\Resources\\PersonSurnames.txt");
        public static readonly List<string> Jobs = new List<string> { "Scrum Master", "Front End Developer", "Back End Developer", "Full stack Developer", "Mobile Application Developer", "Cyber Security", "DevOps", "ProductOwner", "Manager", "Director", "Machine Learning Engineer", "Data Scientist" };
        public static readonly List<string> Cities = new List<string> { "Warszawa", "Poznań", "Kraków", "Gniezno", "Toruń", "Bydgoszcz" };
        public static readonly List<string> Languages = new List<string> { "Niemiecki", "Angielski", "Francuski", "Rosyjski", "Hiszpański" };
        public static readonly List<string> LanguageLevel = new List<string> { "A2", "B1", "B2", "C1", "C2" };
        public static readonly List<string> Technologies = new List<string> { ".NET", "Spring", "MSSQL", "AWS", "Angular", "Android", "Azure", "iOS", "React", "MySQL", "Vue", "TensorFlow", "Keras", "Scikit-Learn", "ChatBot" };
        public static readonly List<string> ProgrammingLanguages = new List<string> { "C++", "javascript", "C#", "Java", "HTML", "CSS", "Haskel", "Ada", "SQL", "Typescript", "Python", "Swift", "Bash" };
        public static readonly List<string> University = new List<string> { "PW", "WAT", "WUM", "PJATK", "UW", "SGGW", "SGH" };
        public static readonly List<string> Hobbies = new List<string> { "Szachy", "Muai-Thai", "Kwiaciarstwo", "Matematyka", "Sztuczna Inteligencja", "Fizyka", "", "Czytanie", "Piłka nożna", "Rugby", "Bieganie", "Squash", "Piłka siatkowa", "Koszykówka" };
        public static readonly List<string> Companies = new List<string> { "KMD", "Asseco", "Google", "Microsoft", "Apple", "Facebook", "", "DeepMind", "Dell", "Creative", "Sony", "Samsung" };
        public static readonly List<string> Specializations = new List<string> { "Informatyka", "Fizyka", "Geografia", "Biologia", "Stomatologia", "Bazy danych", "Data Science", "Uczenie maszynowe", "Big Data", "NLP" };
    }
}
