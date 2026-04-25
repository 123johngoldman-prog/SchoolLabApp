using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Models
{
    public class Loan
    {
        public int Id { get; set; }

        public int AssetId { get; set; }
        public Asset Asset { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public DateTime StartDate { get; set; }
        public int DurationDays { get; set; }

        public DateTime? ReturnedDate { get; set; }

        public string Status { get; set; }
    }
}
