using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public ICollection<Loan> Loans { get; set; }
    }
}
