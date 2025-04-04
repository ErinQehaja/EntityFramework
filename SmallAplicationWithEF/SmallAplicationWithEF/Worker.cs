using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SmallAplicationWithEF
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string PLZ { get; set; } = null!;
    }

    public class Workers
    {
        public List<Person> workers { get; set; }
    }
}