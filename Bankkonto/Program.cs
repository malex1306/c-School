namespace Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            BankVerwaltung bank = new BankVerwaltung();
            
            while (true)
            {
                Console.WriteLine("\nWillkommen bei der MarcelBank! Was möchten Sie tun?");
                Console.WriteLine("E - Geld einzahlen");
                Console.WriteLine("A - Geld abheben");
                Console.WriteLine("D - Kontoauszug drucken");
                Console.WriteLine("S - Alle Kontostände anzeigen");
                Console.WriteLine("N - Neues Konto erstellen");
                Console.WriteLine("B - Beenden");
                Console.Write("Ihre Auswahl: ");
                
                string auswahl = Console.ReadLine().ToUpper();

                switch (auswahl)
                {
                    case "E":
                        Console.Write("Bitte geben Sie die Kontonummer ein: ");
                        int kontoNrE = int.Parse(Console.ReadLine());
                        Console.Write("Betrag eingeben: ");
                        decimal betragE = decimal.Parse(Console.ReadLine());
                        bank.GeldEinzahlen(kontoNrE, betragE);
                        break;

                    case "A":
                        Console.Write("Bitte geben Sie die Kontonummer ein: ");
                        int kontoNrA = int.Parse(Console.ReadLine());
                        Console.Write("Betrag eingeben: ");
                        decimal betragA = decimal.Parse(Console.ReadLine());
                        bank.GeldAbheben(kontoNrA, betragA);
                        break;

                    case "D":
                        Console.Write("Bitte geben Sie die Kontonummer ein: ");
                        int kontoNrD = int.Parse(Console.ReadLine());
                        Bankkonto konto = bank.BankkontoSuchen(kontoNrD);
                        if (konto != null)
                        {
                            konto.Kontoauszug();
                        }
                        else
                        {
                            Console.WriteLine("Konto nicht gefunden!");
                        }
                        break;

                    case "S":
                        bank.AlleKontostaendeAusgeben();
                        break;

                    case "N":
                        Console.Write("Neue Kontonummer eingeben: ");
                        int neueKontoNr = int.Parse(Console.ReadLine());
                        Console.Write("Startguthaben eingeben: ");
                        decimal startGuthaben = decimal.Parse(Console.ReadLine());
                        bank.BankkontoHinzufuegen(new Bankkonto(neueKontoNr, startGuthaben));
                        break;

                    case "B":
                        Console.WriteLine("Programm wird beendet...");
                        return;

                    default:
                        Console.WriteLine("Ungültige Auswahl! Bitte erneut versuchen.");
                        break;
                }
            }
        }
    }

    class Bankkonto
    {
        public int KontoNummer { get; } // Eindeutige Konto-ID
        public decimal Kontostand { get; private set; }

        public Bankkonto(int kontoNummer, decimal kontostand)
        {
            KontoNummer = kontoNummer;
            Kontostand = kontostand;
        }

        public void Einzahlen(decimal betrag)
        {
            if (betrag > 0)
            {
                Kontostand += betrag;
                Console.WriteLine($"Erfolgreich {betrag}€ eingezahlt. Neuer Kontostand: {Kontostand}€");
            }
            else
            {
                Console.WriteLine("Der Betrag muss positiv sein!");
            }
        }

        public void Abheben(decimal betrag)
        {
            if (betrag <= 0)
            {
                Console.WriteLine("Der Betrag muss positiv sein!");
                return;
            }

            if (betrag > Kontostand)
            {
                Console.WriteLine("Nicht genug Guthaben!");
                return;
            }

            Kontostand -= betrag;
            Console.WriteLine($"Erfolgreich {betrag}€ abgehoben. Neuer Kontostand: {Kontostand}€");
        }

        public void Kontoauszug()
        {
            Console.WriteLine($"Kontonummer: {KontoNummer}, Aktueller Kontostand: {Kontostand}€");
        }
    }

    class BankVerwaltung
    {
        private List<Bankkonto> Bankkontos = new List<Bankkonto>();

        public void BankkontoHinzufuegen(Bankkonto bankkonto)
        {
            Bankkontos.Add(bankkonto);
            Console.WriteLine($"Bankkonto mit Kontonummer {bankkonto.KontoNummer} wurde hinzugefügt.");
        }

        public Bankkonto BankkontoSuchen(int kontoNummer)
        {
            return Bankkontos.Find(konto => konto.KontoNummer == kontoNummer);
        }

        public void GeldEinzahlen(int kontoNummer, decimal betrag)
        {
            Bankkonto konto = BankkontoSuchen(kontoNummer);
            if (konto != null)
            {
                konto.Einzahlen(betrag);
            }
            else
            {
                Console.WriteLine($"Konto mit Nummer {kontoNummer} nicht gefunden!");
            }
        }

        public void GeldAbheben(int kontoNummer, decimal betrag)
        {
            Bankkonto konto = BankkontoSuchen(kontoNummer);
            if (konto != null)
            {
                konto.Abheben(betrag);
            }
            else
            {
                Console.WriteLine($"Konto mit Nummer {kontoNummer} nicht gefunden!");
            }
        }

        public void AlleKontostaendeAusgeben()
        {
            Console.WriteLine("\n--- Alle Kontostände ---");
            foreach (var konto in Bankkontos)
            {
                konto.Kontoauszug();
            }
        }
    }
}
