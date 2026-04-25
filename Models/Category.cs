using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } 

        public ICollection<Asset> Assets { get; set; }
    }
}
