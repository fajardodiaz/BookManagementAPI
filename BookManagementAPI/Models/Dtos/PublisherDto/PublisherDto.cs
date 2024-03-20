using BookManagementAPI.Data;

namespace BookManagementAPI.Models.Dtos.PublisherDto
{
    public class PublisherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Book> Books { get; set; }
    }
}
