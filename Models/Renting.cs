namespace LibraryManagementSystemAPI.Models
{
    public class Renting
    {
        public int RentID { get; set; }
        public int BookID { get; set; }
        public string BookName { get; set; } = "WhitePages";
        public int RentPrice { get; set; }
    }
}
