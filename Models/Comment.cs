namespace EntityFramework.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Student { get; set; } = String.Empty;
        public int Score { get; set; }
        public string Commentary { get; set; } = String.Empty;
        public int BookId { get; set; }
        public virtual Book Book { get; set; } 

    }
}
