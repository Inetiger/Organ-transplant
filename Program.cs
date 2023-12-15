using System;

namespace Organ_transplant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kåres nyre svikt");
            start();
        }

        private static void start()
        {
            bool nyrestorage;
            Person kåre = new Person(true, true);
            Person bernt = new Person(false, false);
            while (true)
            {
                Console.ReadLine();
                Console.Clear();
                switch (Ask("vil du gir nyre til Kåre eller Bernt"))
                {
                    case "Kåre":
                        nyrestorage = kåre.nyre;
                        kåre.nyre = bernt.nyre;
                        bernt.nyre = nyrestorage;

                        if (kåre.nyre && kåre.nyre2) Console.WriteLine("Begge nyrene til Kåre er gode");
                        else if (!kåre.nyre && !kåre.nyre2) Console.WriteLine("Begge nyrene til Kåre er dårlige");
                        else Console.WriteLine("En av nyrene til Kåre er dårlige");


                        if (bernt.nyre && bernt.nyre2) Console.WriteLine("Begge nyrene til Bernt er gode");
                        else if (!bernt.nyre && !bernt.nyre2) Console.WriteLine("Begge nyrene til Bernt er dårlige");
                        else Console.WriteLine("En av nyrene til Bernt er dårlige");
                        break;
                    case "Bernt":
                        nyrestorage = bernt.nyre;
                        bernt.nyre = kåre.nyre;
                        kåre.nyre = nyrestorage;

                        if (bernt.nyre && bernt.nyre2) Console.WriteLine("Begge nyrene til Bernt er gode");
                        else if (bernt.nyre && !bernt.nyre2) Console.WriteLine("Begge nyrene til Bernt er dårlige");
                        else Console.WriteLine("En av nyrene til Bernt er dårlige");


                        if (kåre.nyre && kåre.nyre2) Console.WriteLine("Begge nyrene til Kåre er gode");
                        else if (!kåre.nyre && !kåre.nyre2) Console.WriteLine("Begge nyrene til Kåre er dårlige");
                        else Console.WriteLine("En av nyrene til Kåre er dårlige");
                        break;
                    default:
                        Console.WriteLine("not valid");
                        start();
                        break;
                }
            }

            //Console.WriteLine($"bernt nyre 1: {bernt.nyre} nyre 2: {bernt.nyre2}");
            //Console.WriteLine($"kåre nyre 1: {kåre.nyre} nyre 2: {kåre.nyre2}");

            //Console.WriteLine();
            //Console.WriteLine($"bernt nyre 1: {bernt.nyre} nyre 2: {bernt.nyre2}");
            //Console.WriteLine($"kåre nyre 1: {kåre.nyre} nyre 2: {kåre.nyre2}");
        }

        private static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
