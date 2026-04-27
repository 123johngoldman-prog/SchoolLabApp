using System;
using System.Collections.Generic;

namespace SchoolLabApp.Models
{
    public class Asset
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public string? InventoryNumber { get; set; }

        public string? Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public ICollection<Loan>? Loans { get; set; }

        public ICollection<Damage>? Damages { get; set; }
    }
}