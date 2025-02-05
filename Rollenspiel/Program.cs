using System;

namespace Resttage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Willkommen zum Fantasy Rollenspiel! \n" +
                                  "Gib einen Namen ein.");
                string name = Console.ReadLine();
                Console.WriteLine($"Hallo {name}, schön, dass du auf dieser Reise dabei bist!");
                Console.WriteLine("Du kannst gleich Punkte auf Stärke, Gesundheit und Glück verteilen. \n" +
                                  "Du hast maximal 15 Punkte zur Verfügung. Solltest du keine Punkte verteilen, \n" +
                                  "werden jedem Attribut automatisch 5 Punkte zugewiesen!");

               
                int maxPoints = 15;

                Console.WriteLine("Wie viele Punkte möchtest du der Stärke zuweisen?");
                int strength = GetValidPoints();
                Console.WriteLine("Wie viele Punkte möchtest du der Gesundheit zuweisen?");
                int health = GetValidPoints();

                
                int allocatedPoints = strength + health;
                int luck = Math.Max(0, maxPoints - allocatedPoints);

                
                if (allocatedPoints > maxPoints)
                {
                    Console.WriteLine("Du hast zu viele Punkte verteilt. Die Werte werden automatisch angepasst.");
                    strength = 5;
                    health = 5;
                    luck = 5;
                }
                else if (allocatedPoints < maxPoints)
                {
                    Console.WriteLine($"Deine restlichen {maxPoints - allocatedPoints} Punkte werden dem Glück zugewiesen.");
                }

               
                Console.WriteLine("\nDeine finalen Werte sind:");
                Console.WriteLine($"Stärke: {strength}");
                Console.WriteLine($"Gesundheit: {health}");
                Console.WriteLine($"Glück: {luck}");

                Console.WriteLine("\nViel Erfolg auf deiner Reise, Abenteurer!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Bitte gib eine gültige Zahl ein.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein unerwarteter Fehler ist aufgetreten: " + ex.Message);
            }
        }

        
        static int GetValidPoints()
        {
            int points;
            while (true)
            {
                try
                {
                    points = Convert.ToInt32(Console.ReadLine());
                    if (points < 0)
                    {
                        Console.WriteLine("Die Punkteanzahl darf nicht negativ sein. Versuche es erneut:");
                        continue;
                    }
                    return points;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein:");
                }
            }
        }
    }
}
