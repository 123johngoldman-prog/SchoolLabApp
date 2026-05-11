namespace SchoolLabApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int RoleId { get; set; }
        public Role? Role { get; set; }          // no = new Role() — was causing blank-row inserts
        public int? PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
