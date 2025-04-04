using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SmallAplicationWithEF
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string PLZ { get; set; } = null!;
    }
}