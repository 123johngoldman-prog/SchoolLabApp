using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Models
{
    public class Damage
    {
        public int Id { get; set; }

        public int AssetId { get; set; }
        public Asset Asset { get; set; }

        public string Description { get; set; }

        public DateTime DateReported { get; set; }
    }
}
