using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SmallAplicationWithEF
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string PLZ { get; set; } = null!;

        public int? WorkersId { get; set; }

        public Workers? Workers { get; set; }
    }

    public class Workers
    {
        public int Id { get; set; }

        public List<Person> Persons { get; set; } = new List<Person>();
    }
}