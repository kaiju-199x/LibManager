using Microsoft.EntityFrameworkCore;

namespace LibManager.Models;

public class DBLib : DbContext
{
    public DBLib (DbContextOptions<DBLib> options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Loan> Loans { get; set; }
}