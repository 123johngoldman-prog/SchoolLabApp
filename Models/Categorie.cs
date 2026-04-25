using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Models
{
    public class Categorie
    {
        public int Id { get; set; }

        public string Name { get; set; } 

        public List<Asset> assets { get; set; } = new List<Asset>();
    }
}
