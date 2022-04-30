namespace EntityFramework.Models
{
    public class Precie
    {
        public int PrecieId { get; set; }
        public decimal CurrentPrecie { get; set; }
        public decimal Promotion { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
