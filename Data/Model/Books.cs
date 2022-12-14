namespace My_book_store.Data.Model
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime ? DateRead { get; set; }
        public int ? Rate { get; set; }
        public string CoverUrl { get; set; }
        public string Genre { get; set; }
        public DateTime DatedAdded { get; set; }

    }
}
