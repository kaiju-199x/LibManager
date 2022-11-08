using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

public class LibDB : DbContext
{
    public LibDB (DbContextOptions<LibDB> options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Loan> Loans { get; set; }
}