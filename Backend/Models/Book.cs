using Microsoft.EntityFrameworkCore;
namespace LibManager.Models;

public class Book
{
    public int Id { get; set; }
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Genre { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string Session { get; set; }
    public bool Loaned { get; set; }
}

