//using System;

//namespace Language
//{
//    internal static class Program
//    {
//        internal static void WelcomeWorlds()
//        {
//            Console.WriteLine("Welcome to my dictionary!!!");
//            Console.WriteLine("Press any key");
//            Console.ReadKey();
//        }
        
//        private static void ExistLanguages()
//        {
//            Console.WriteLine("\n There are the following languages:");
//            foreach (var Lang in Enum.GetValues(typeof(Languages)))
//                Console.WriteLine(Lang);
//            Console.WriteLine("Press any key");
//            Console.ReadKey();
//        }

//        private static void SelectOriginalLanguage()
//        {
//            Console.WriteLine("\n Please select language!");
//            while (!Enum.TryParse(Console.ReadLine(), out Languages selectOriginalLanguage)) ;

//            Console.WriteLine("Press any key");
//            Console.ReadKey();
//        }

//        private static void SelectLocalLanguage()
//        {
//            Console.WriteLine("\n Please select language!");
//            while (!Enum.TryParse(Console.ReadLine(), out Languages selectLocalLanguage)) ;
       
//            Console.WriteLine("Press any key");
//            Console.ReadKey();
//        }

//        private static void TextForTranslate()
//        {
//            Console.WriteLine("Selected original language contains following phrase:");
//            foreach (var phrase in T)
//            { }
//        }


//        private static void Main()
//        {
//            WelcomeWorlds();
//            ExistLanguages();
//            SelectOriginalLanguage();
//            SelectLocalLanguage();
//        }

//    }
//}
