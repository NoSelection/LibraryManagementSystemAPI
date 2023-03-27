namespace LibraryManagementSystemAPI.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string First_Name { get; set; } = "John";
        public string Last_Name { get; set; } = "Doe";
        public int Phone { get; set; }
        public string Email { get; set; } = "example@email.com";
        public string Password { get; set; } = "12345";
        public int Age { get; set; }


    }
}
