namespace LibraryManagementSystemAPI.Models
{
    public class Genre
    {
        public int Genre_Id { get; set; }
        public string Name { get; set; } = "Horror";
        public string Description { get; set; } = "ScarryBooks";
        public int AgeRecommended { get; set; }
    }
}
