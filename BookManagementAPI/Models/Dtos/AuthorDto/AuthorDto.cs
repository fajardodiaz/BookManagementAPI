using BookManagementAPI.Data;

namespace BookManagementAPI.Models.Dtos.AuthorDto
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookAuthorMap> BookAuthorMap { get; set; }
    }
}
