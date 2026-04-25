using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<User> users { get; set; } = new List<User>();
    }
}
