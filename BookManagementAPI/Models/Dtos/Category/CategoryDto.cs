using BookManagementAPI.Data;

namespace BookManagementAPI.Models.Dtos.Category
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookCategoryMap> BookCategoryMap { get; set; }
    }
}
