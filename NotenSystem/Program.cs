namespace NotenSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Schule schule = new Schule();
            while (true)
            {
                Console.WriteLine($"Name des Schülers eingben (oder 'exit' zum beenden");
                string name = Console.ReadLine();
                if (name.ToLower() == "exit") break;

                Schueler schueler = new Schueler(name);

                while (true)
                {
                    Console.WriteLine("Gib eine Note ein oder 'x' zum Beenden:");
                    string eingabe = Console.ReadLine();

                    if (eingabe.ToLower() == "x") break;

                    if (double.TryParse(eingabe, out double note))
                    {
                        schueler.HinzufuegenNote(note);
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe, bitte eine Zahl eingeben.");
                    }
                }
                schule.SchuelerHinzufuegen(schueler);
                Console.WriteLine($"Durchschnittsnote von {schueler.Name}: {schueler.DurchschnittBerechnen()}");
            }
            Console.WriteLine($"Durchschnittsnote der gesamten Schule: {schule.DurchnittsnoteBerechnen()}");
        }
    }
    

    class Schueler
    {
        public string Name;
        private List<double> Noten = new List<double>();

        public Schueler(string name)
        {
            Name = name;
        }
        
        public void HinzufuegenNote(double note)
        {
            Noten.Add(note);
        }

        public double DurchschnittBerechnen()
        {
            if (Noten.Count == 0)
                return 0;
            return Noten.Average();
        }
    }

    class Schule
    {
        private List<Schueler> SchuelerListe = new List<Schueler>();
        
        public void SchuelerHinzufuegen(Schueler schueler)
        {
            SchuelerListe.Add(schueler);
        }

        public double DurchnittsnoteBerechnen()
        {
            if (SchuelerListe.Count == 0) return 0;
            return SchuelerListe.Average(s => s.DurchschnittBerechnen());
        }
    }
    
}