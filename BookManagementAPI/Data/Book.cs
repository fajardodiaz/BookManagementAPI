namespace BookManagementAPI.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<BookAuthorMap> BookAuthorMap { get; set; }
        public List<BookCategoryMap> BookCategoryMap { get; set; }
    }
}
