using EntityFramework.Config;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Options;

namespace EntityFramework.DbContexts
{
    public class BookContext : DbContext
    {
        private readonly string _connectionString;

        public BookContext(IOptions<ConnectionDataBase> connectionString)
        {
            _connectionString = connectionString.Value.DataBaseConnection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>().HasKey(c => new {c.AuthorId,c.BookId});
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Precie> Precie { get; set; }
        public DbSet<Comment> Comment { get; set; }

        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorBook> AuthorBook { get; set; }
    }
}
