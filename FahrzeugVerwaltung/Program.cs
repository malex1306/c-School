namespace FahrzeugVerwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage meineGarage = new Garage();

            while (true)
            {
                Console.WriteLine("Geben Sie Modell und Marke ein (z.B. 'Mazda 6') oder 'exit' zum Beenden:");
                string input = Console.ReadLine();
                
                if (input.ToLower() == "exit")
                    break;

                string[] parts = input.Split(' ');

                if (parts.Length == 2)
                {
                    string marke = parts[0];
                    string modell = parts[1];

                    Fahrzeug neuesFahrzeug = new Fahrzeug(marke, modell, 0, 0);
                    meineGarage.FahrzeugHinzufuegen(neuesFahrzeug);
                    Console.WriteLine($"Fahrzeug {marke} {modell} wurde zur Garage hinzugefügt.");

                    // Interaktive Eingabe für Tankvorgänge
                    while (true)
                    {
                        Console.WriteLine("Möchten Sie den Kilometerstand und Verbrauch für dieses Fahrzeug aktualisieren? (y/n)");
                        string updateInput = Console.ReadLine();
                        if (updateInput.ToLower() == "y")
                        {
                            Console.WriteLine("Geben Sie die gefahrenen Kilometer ein:");
                            double gefahreneKm = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Geben Sie die verbrauchten Liter ein:");
                            double getanktLiter = Convert.ToDouble(Console.ReadLine());

                            neuesFahrzeug.TankvorgangHinzufuegen(gefahreneKm, getanktLiter);
                            Console.WriteLine($"Kilometerstand: {neuesFahrzeug.Kilometerstand}, Verbrauchte Liter: {neuesFahrzeug.VerbrauchteLiter}");
                        }
                        else
                        {
                            break;
                        }
                    }

                    // Anzeige aller Fahrzeuge nach jeder Änderung
                    meineGarage.AnzeigeAlleFahrzeuge();
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie sowohl Marke als auch Modell ein.");
                }
            }
        }
    }

    class Fahrzeug
    {
        public string Marke { get; set; }
        public string Modell { get; set; }
        public double Kilometerstand { get; set; }
        public double VerbrauchteLiter { get; set; }

        public Fahrzeug(string marke, string modell, double kilometerstand, double verbrauchteLiter)
        {
            Marke = marke;
            Modell = modell;
            Kilometerstand = kilometerstand;
            VerbrauchteLiter = verbrauchteLiter;
        }

        public void TankvorgangHinzufuegen(double gefahreneKm, double getanktLiter)
        {
            Kilometerstand += gefahreneKm;
            VerbrauchteLiter += getanktLiter;
        }

        public double DurchschnittsverbrauchBerechnen()
        {
            if (Kilometerstand == 0)
                return 0;
            return (VerbrauchteLiter * 100) / Kilometerstand;
        }
    }

    class Garage
    {
        private List<Fahrzeug> fahrzeuge = new List<Fahrzeug>();

        public void FahrzeugHinzufuegen(Fahrzeug neuesFahrzeug)
        {
            fahrzeuge.Add(neuesFahrzeug);
        }

        public void AnzeigeAlleFahrzeuge()
        {
            if (fahrzeuge.Count == 0)
            {
                Console.WriteLine("Es gibt keine Fahrzeuge in der Garage.");
            }
            else
            {
                Console.WriteLine("Alle Fahrzeuge in der Garage:");
                foreach (var fz in fahrzeuge)
                {
                    Console.WriteLine(
                        $"Marke: {fz.Marke}, Modell: {fz.Modell}, Kilometerstand: {fz.Kilometerstand}, Verbrauchte Liter: {fz.VerbrauchteLiter}");
                }
            }
        }
    }
}
