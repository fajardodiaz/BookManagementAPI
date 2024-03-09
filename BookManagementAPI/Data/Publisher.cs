﻿namespace BookManagementAPI.Data
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Book> Books { get; set; }
    }
}
