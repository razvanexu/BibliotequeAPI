using BibliotequeAPI.Model;
using Microsoft.EntityFrameworkCore;


namespace BibliotequeAPI.Data.Context
{
    public class BibliotequeContext : DbContext
    {
        public BibliotequeContext(DbContextOptions<BibliotequeContext> opt) : base(opt)
        {

        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<BookModel> Books { get; set; }
    }
}
