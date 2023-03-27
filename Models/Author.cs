namespace LibraryManagementSystemAPI.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; } = "William";
        public string Email { get; set; } = "spaceman@example.com";
        public string Country { get; set; } = "USA";
        public int Age { get; set; }
    }
}
