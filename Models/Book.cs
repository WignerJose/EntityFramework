namespace EntityFramework.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty ;
        public DateTime PublishDate { get; set; }
        public Precie PreciePromotion { get; set; }
        public List<Comment> Comments { get; set; }
        public List<AuthorBook> Authors { get; set; }
    }
}
