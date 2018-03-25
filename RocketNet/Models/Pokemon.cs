using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RocketNet.Models
{
    public class Pokemon
    {
        public int ID { get; set; }
        public int DexNum { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public decimal Price { get; set; }

    }

    public class PokeDBContext : DbContext
    {
        public DbSet<Pokemon> Pokes { get; set; }
    }
}