using System;
using Microsoft.EntityFrameworkCore;

namespace SmallAplicationWithEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var workers = context.Workers.Include(w => w.Persons).FirstOrDefault();
                if (workers == null)
                {
                    workers = new Workers();
                    context.Workers.Add(workers);
                    context.SaveChanges();
                }

                Console.WriteLine("Gespeicherte Personen in der Workers-Liste:");
                if (workers.Persons.Any())
                {
                    foreach (var person in workers.Persons)
                    {
                        Console.WriteLine($"  - ID: {person.Id}, Name: {person.Name}, PLZ: {person.PLZ}");
                    }
                }
                else
                {
                    Console.WriteLine("  - Keine Personen vorhanden.");
                }

                Console.WriteLine("\nNeue Person hinzufügen (Name eingeben, 'exit' zum Beenden):");
                string? name = Console.ReadLine();

                while (name?.ToLower() != "exit")
                {
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Fehler: Name darf nicht leer sein.");
                        name = Console.ReadLine();
                        continue;
                    }

                    string? plz = null;
                    bool validPlz = false;
                    while (!validPlz)
                    {
                        Console.WriteLine("Postleitzahl eingeben:");
                        plz = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(plz))
                        {
                            Console.WriteLine("Fehler: PLZ darf nicht leer sein.");
                        }
                        else
                        {
                            validPlz = true;
                        }
                    }

                    var newPerson = new Person
                    {
                        Name = name,
                        PLZ = plz,
                        Workers = workers 
                    };
                    workers.Persons.Add(newPerson);

                    context.SaveChanges();
                    Console.WriteLine("Person gespeichert! Nächste Person (oder 'exit'):");
                    name = Console.ReadLine();
                }
            }
            Console.WriteLine("Programm beendet.");
        }
    }
}