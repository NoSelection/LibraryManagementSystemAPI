namespace LibraryManagementSystemAPI.Models
{
    public class Ordering
    {
        public int OrderID { get; set; }
        public int BookID { get; set; }
        public string BookName { get; set; } = "The Eye";
        public int BuyPrice { get; set; }
    }
}
