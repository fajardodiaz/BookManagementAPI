namespace BookManagementAPI.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookAuthorMap> BookAuthorMap { get; set; }
    }
}
