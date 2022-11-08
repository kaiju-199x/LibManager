namespace Backend.Models;

public class Loan
{
    public int Id { get; set; }
    public Book Book { get; set; }
    public User User { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime ReturnDate { get; set; }
}