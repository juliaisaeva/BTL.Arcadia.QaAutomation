using System;

namespace Translator
{
    internal class Program
    {
        internal static readonly LocalizedText[][] Phrases = {
            new[]
            {
                new LocalizedText
                {
                    Language = Language.English,
                    Text = "Hello!"
                },

                new LocalizedText
                {
                    Language = Language.French,
                    Text = "Bonjour!"
                },

                new LocalizedText
                {
                    Language = Language.German,
                    Text = "Hallo!"
                },

                new LocalizedText
                {
                    Language = Language.Spanish,
                    Text = "Hola!"
                }
            },

            new[]
            {
                new LocalizedText
                {
                    Language = Language.English,
                    Text = "How are you?"
                },

                new LocalizedText
                {
                    Language = Language.French,
                    Text = "Comment allez-vous?"
                },

                new LocalizedText
                {
                    Language = Language.German,
                    Text = "Wie geht es dir?"
                },

                new LocalizedText
                {
                    Language = Language.Spanish,
                    Text = "¿Cómo estás?"
                }
            },

            new[]
            {
                new LocalizedText
                {
                    Language = Language.English,
                    Text = "Goodbye!"
                },

                new LocalizedText
                {
                    Language = Language.French,
                    Text = "Au revoir!"
                },

                new LocalizedText
                {
                    Language = Language.German,
                    Text = "Auf Wiedersehen!"
                },

                new LocalizedText
                {
                    Language = Language.Spanish,
                    Text = "Adiós!"
                }
            },
        };

        internal static void WelcomeWord()
        {
            Console.WriteLine("Welcome to my dictionary!!!");
            Console.WriteLine();
        }

        private static void ExistLanguages()
        {
            Console.WriteLine("There are the following languages:");

            foreach (var Lang in Enum.GetValues(typeof(Language)))
                Console.WriteLine($"- {Lang}");

            Console.WriteLine();
        }

        private static Language SelectLanguage()
        {
            Console.WriteLine("Please select language!");

            Language selectedLocalLanguage;

            while (!Enum.TryParse(Console.ReadLine(), out selectedLocalLanguage))
            {
                Console.WriteLine("Language not found! Try again.");
            }

            return selectedLocalLanguage;
        }

        private static void ExistPhrases(Language language)
        {
            Console.WriteLine("There are the following pgrases:");
            for (int i = 0; i < Phrases.Length; i++)
            {
                foreach (var phrase in Phrases[i])
                {
                    if (phrase.Language == language)
                    {
                        Console.WriteLine($"{i + 1}) {phrase}");
                    }
                }
            }

        }

        private static int SelectPhrase(Language language)
        {
            Console.WriteLine("Please select a phrase:");

            int selectPhrase;
            while (!int.TryParse(Console.ReadLine(), out selectPhrase ))
            {
                Console.WriteLine("Phrase not found! Try again.");
            }

            return selectPhrase;
        }

        private static void Translate(Language localLanguage, int phrase, Language targetLanguage)
        {
            LocalizedText localPhrase = null, targetPhrase = null;
            foreach(var phr in Phrases[phrase - 1])
                {
                    if (phr.Language == localLanguage)
                    {
                        localPhrase = phr;
                    }

                    if (phr.Language == targetLanguage)
                    {
                        targetPhrase = phr;
                    }
                }
            Console.WriteLine($"Original phrase:\n{localPhrase}");
            Console.WriteLine($"Translated phrase:\n{targetPhrase}");
        }

        public static void Main()
        {
            WelcomeWord();
            ExistLanguages();
            var localLanguage = SelectLanguage();
            ExistPhrases(localLanguage);
            var selectPhrase = SelectPhrase(localLanguage);
            var targetLanguage = SelectLanguage();
            Translate(localLanguage, selectPhrase, targetLanguage);

            Console.ReadKey();
        }
    }
}
