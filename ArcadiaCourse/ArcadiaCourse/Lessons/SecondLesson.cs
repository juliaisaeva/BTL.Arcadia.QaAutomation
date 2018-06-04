using System;
using System.Collections.Generic;
namespace ArcadiaCourse.Lessons
{
    public class SecondLesson
    {
        private static void OldMain()
        {
            Dictionary<string, string> Languages = new Dictionary<string, string>();
            Languages.Add("Russian", "Этот текст на русском языке");
            Languages.Add("English", "This text is in English");
            Languages.Add("French", "Ce texte est en français");
            Languages.Add("German", "Dieser Text ist in Deutsch");

            foreach (string language in Languages.Keys)
                Console.WriteLine(language);

            Console.WriteLine("Please select language");

            string selectedLang = Console.ReadLine();

            Console.WriteLine(Languages[selectedLang]);

            Console.ReadLine();
        }

    }
}
