using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallAplicationWithEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                context.Database.EnsureCreated();

                Console.WriteLine("Gespeicherte Items:");
                foreach (var item in context.Items)
                {
                    Console.WriteLine($"ID: {item.Id}, Name: {item.Name}");
                }

                Console.WriteLine("\nNeues Item eingeben (oder 'exit' zum Beenden):");
                string? input = Console.ReadLine();

                while (input?.ToLower() != "exit")
                {
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Fehler: Der Name darf nicht leer sein. Bitte geben Sie einen gültigen Namen ein.");
                    }
                    else
                    {
                        var newItem = new Item { Name = input };
                        context.Items.Add(newItem);
                        context.SaveChanges();
                        Console.WriteLine("Gespeichert! Nächstes Item (oder 'exit'):");
                    }

                    input = Console.ReadLine();
                }
            }
            Console.WriteLine("Programm beendet.");
        }
    }
}