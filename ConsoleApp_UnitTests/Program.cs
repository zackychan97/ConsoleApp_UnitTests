using System;
using System.Text;

namespace A1_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            do
            {
                ConsoleMenu(ref keepRunning);
            } while (keepRunning);
        }

        public static void ConsoleMenu(ref bool keepRunning)
        {
            Console.WriteLine("Welcome to the menu! Here are your options:\nEnter 1 for PrintRandomNumber()\nEnter 2 for PrintTodaysDate()\nEnter 3 for PrintRandomDino()\nEnter 4 to PrintRandomStringAction()\nEnter 5 to exit\nReminder: press return/enter after choosing menu item");
            string numInputStr = Console.ReadLine();
            Console.WriteLine();

            switch (numInputStr)
            {
                case "1":
                    Console.WriteLine("----------");
                    PrintRandomNumber();
                    Console.WriteLine("----------");
                    break;
                case "2":
                    Console.WriteLine("----------");
                    PrintTodaysDate();
                    Console.WriteLine("----------");
                    break;
                case "3":
                    Console.WriteLine("----------");
                    PrintRandomDino();
                    Console.WriteLine("----------");
                    break;
                case "4":
                    Console.WriteLine("----------");
                    PrintRandomStringAction();
                    Console.WriteLine("----------");
                    break;
                case "5":
                    Console.WriteLine("----------");
                    Console.WriteLine("Exiting. Goodbye.");
                    Console.WriteLine("----------");
                    keepRunning = false;
                    return;
                default:
                    Console.WriteLine("----------");
                    Console.WriteLine("That isn't an available menu command.");
                    Console.WriteLine("----------");
                    break;
            }
        }

        public static void PrintRandomNumber()
        {
            Console.WriteLine("Printing random number. Intense computation incoming!");
            Random rnd = new Random();
            int randNum = rnd.Next(1, 11);
            Console.WriteLine($"Random number: {randNum}");
        }

        public static void PrintTodaysDate()
        {
            string today = DateTime.Now.ToShortDateString();
            Console.WriteLine($"Todays date is: {today}");
        }

        public static void PrintRandomDino()
        {
            Console.WriteLine("Printing random dino.");
            Random rnd = new Random();
            int randNum = rnd.Next(0, 10);

            List<string> Dinosaurs = new List<string>();
            Dinosaurs.Add("Tyrannosaurus Rex");
            Dinosaurs.Add("Velociraptor");
            Dinosaurs.Add("Stegosaurus");
            Dinosaurs.Add("Triceratops");
            Dinosaurs.Add("Spinosaurus");
            Dinosaurs.Add("Ankylosaurus");
            Dinosaurs.Add("Brachiosaurus");
            Dinosaurs.Add("Dilophosaurus");
            Dinosaurs.Add("Argentinosaurus");
            Dinosaurs.Add("Parasaurolophus");

            var SortedDinosaursList = Dinosaurs.OrderBy(dino => dino).ToList();
            Console.WriteLine(SortedDinosaursList[randNum]);
        }

        public static void PrintRandomStringAction()
        {
            Console.Write("Enter in text string you would like: ");
            string? str = Console.ReadLine();

            if (str != null)
            {
                Console.WriteLine($"Taking random action with your string: {str}");

                Random rnd = new Random();
                int randNum = rnd.Next(0, 10);
                string? alteredStr;
                string? actionTaken;

                switch (randNum)
                {
                    case 0:
                        alteredStr = str.ToLower();
                        actionTaken = "toLower()";
                        Console.WriteLine($"{actionTaken} method applied: {alteredStr}");
                        break;
                    case 1:
                        alteredStr = str.ToUpper();
                        actionTaken = "toUpper()";
                        Console.WriteLine($"{actionTaken} method applied: {alteredStr}");
                        break;
                    case 2:
                        alteredStr = str.Length.ToString();
                        actionTaken = "Length";
                        Console.WriteLine($"{actionTaken} property derived: {alteredStr}");
                        break;
                    case 3:
                        int lastCharIndex = str.Length-1;
                        alteredStr = str.Substring(lastCharIndex);
                        actionTaken = "Substring()";
                        Console.WriteLine($"{actionTaken} method applied, getting last character: {alteredStr}");
                        break;
                    case 4:
                        alteredStr = str.LastIndexOf("a").ToString();
                        actionTaken = "LastIndexOf()";
                        Console.WriteLine($"{actionTaken} method applied: {alteredStr}");
                        break;
                    case 5:
                        string secretCode = "C# is awesome";
                        alteredStr = str.Contains(secretCode).ToString();
                        actionTaken = "Contains()";
                        Console.WriteLine($"{actionTaken} method applied, looking for 'C# is awesome': {alteredStr}");
                        break;
                    case 6:
                        alteredStr = str.GetType().ToString();
                        actionTaken = "GetType()";
                        Console.WriteLine($"{actionTaken} method applied, as predicted, this will always be a: {alteredStr}");
                        break;
                    case 7:
                        alteredStr = str.IndexOf("a").ToString();
                        actionTaken = "IndexOf";
                        Console.WriteLine($"{actionTaken} method applied, first index of 'a': {alteredStr}");
                        break;
                    case 8:
                        alteredStr = str.Replace("a", "X").Replace("e", "X").Replace("i", "X").Replace("o", "X").Replace("u", "X").Replace("y", "X");
                        actionTaken = "Replace()";
                        Console.WriteLine($"{actionTaken} method applied, replacing all vowels with 'X': {alteredStr}");
                        break;
                    case 9:
                        char[] charArray = str.ToCharArray();
                        Array.Reverse( charArray );
                        string reversedString = new string( charArray );
                        alteredStr = reversedString;
                        actionTaken = "Reverse()";
                        Console.WriteLine($"{actionTaken} method applied: {alteredStr}");
                        break;
                    default:
                        Console.WriteLine($"Something weird happened");
                        break;
                }
            }

        }
    }
}
