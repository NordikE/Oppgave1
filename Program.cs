
namespace Oppgave1;
    class Program
    {
        static void Main(string[] args)
        {
            // Ulike variabeltyper
            int alder = 30;
            string navn = "Ola Nordmann";
            double høyde = 1.85;

            Console.WriteLine("Alder: " + alder);
            Console.WriteLine("Navn: " + navn);
            Console.WriteLine("Høyde: " + høyde);

            // Arrays og Lister
            string[] ukedager = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "Lørdag", "Søndag" };
            List<int> tall = new List<int> { 5, 12, 8, 3 };

            // Utskrift av array og liste (krever løkker)
            Console.WriteLine("\nUkedager:");
            for (int i = 0; i < ukedager.Length; i++)
            {
                Console.WriteLine(ukedager[i]);
            }

            Console.WriteLine("\nTall:");
            foreach (int tallVerdi in tall)
            {
                Console.WriteLine(tallVerdi);
            }

            // Klasse med constructor og get/set
            Person person = new Person("Kari Nordmann", 25);
            Console.WriteLine("\nPerson:");
            Console.WriteLine("Navn: " + person.Navn);
            Console.WriteLine("Alder: " + person.Alder);

            // Metoder for beregninger
            int sum = AddNumbers(5, 8);
            double sumDesimal = AddNumbers(3.5, 2.7); // Bruker overlagring for desimaltall
            Console.WriteLine("\nSum av heltall: " + sum);
            Console.WriteLine("Sum av desimaltall: " + sumDesimal);

            // String manipulasjon
            string setning = "Dette er en setning.";
            string[] ord = setning.Split(' ');
            Console.WriteLine("\nOrd i setningen:");
            foreach (string ordDel in ord)
            {
                Console.WriteLine(ordDel);
            }

            // Interface og implementasjon
            ICalculator kalkulator = new EnkelKalkulator();
            int resultat = kalkulator.Add(10, 15);
            Console.WriteLine("\nResultat fra kalkulator: " + resultat);
        }

        // Metode for å legge sammen tall (overlagret for int og double)
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static double AddNumbers(double a, double b)
        {
            return a + b;
        }
    }

    // Klasse for en person
    class Person
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public Person(string navn, int alder)
        {
            Navn = navn;
            Alder = alder;
        }
    }

    // Interface for kalkulator
    interface ICalculator
    {
        int Add(int a, int b);
        // Flere metoder kan legges til her
    }

    // Klasse som implementerer kalkulator-interfacet
    class EnkelKalkulator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
