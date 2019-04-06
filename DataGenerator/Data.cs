using System.Collections.Generic;

namespace DataGenerator
{
    internal static class Data
    {
        public static List<string> PersonNames = IOManager.LoadFile("..\\Resources\\PersonNames.txt");
        public static List<string> PersonSurnames = IOManager.LoadFile("..\\Resources\\PersonSurnames.txt");
        public static List<string> Jobs = new List<string> { "Scrum Master", "Front End Developer", "Back End Developer", "Cyber Security", "DevOps", "ProductOwner", "Manager", "Director", "Machine Learning Engineer", "Data Scientist" };
        public static List<string> Cities = new List<string> { "Warszawa", "Poznań", "Kraków", "Gniezno", "Toruń", "Bydgoszcz" };
        public static List<string> Languages = new List<string> { "German", "English", "French", "Russian", "Spanish" };
        public static List<string> Technologies = new List<string> { ".NET", "Spring", "MSSQL", "Angular", "React", "MySQL", "Vue", "TensorFlow", "Keras", "Scikit-Learn", "ChatBot" };
        public static List<string> SkillLevel = new List<string> { "Beginner", "Intermediate", "Advanced" };
        public static List<string> University = new List<string> { "PW", "WAT", "WUM", "PJATK", "UW", "SGGW", "SGH" };
        public static List<string> Hobbies = new List<string> { "Chess", "Muai-Thai", "Flowers", "Mathematics", "AI", "Physics", "", "Reading", "Soccer", "Rugby", "Running", "Squash", "VolleyBall", "BasketBall" };
        public static List<string> Companies = new List<string> { "KMD", "Asseco", "Google", "Microsoft", "Apple", "Facebook", "", "DeepMind", "Dell", "Creative", "Sony", "Samsung" };
        public static List<string> Specializations = new List<string> { "Informatics", "Psychics", "Geography", "Biology", "Dentist", "Databases", "Data Science", "Machine Learning", "Big Data", "NLP" };

    }
}
