namespace EntityFramework.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }
        public byte Photo { get; set; }
        public List<AuthorBook> AuthorBooks { get; set; }
    }
}
