namespace LibraryManagementSystemAPI.Models
{
    public class Books
    {
        public int BookID { get; set; }
        public string BookName { get; set; } = "WhitePage";
        public string Genre { get; set; } = "Drama";
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
    }
}
