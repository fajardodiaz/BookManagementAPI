namespace BookManagementAPI.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookCategoryMap> BookCategoryMap { get; set; }
    }
}
