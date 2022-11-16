using Microsoft.AspNetCore.Mvc;
using LibManager.Models;
namespace LibManager.Controllers;

[ApiController]
[Route("loan")]
public class LoanController:ControllerBase
{
    private DBLib db;
    public LoanController(DBLib db)
    {
        this.db = db;
    }
    
    [HttpGet]
public ActionResult Read()
    {
        return Ok(db.Loans.ToList());
    }

    [HttpPost]
    public ActionResult Create(Loan loan)
    {
        db.Loans.Add(loan);
        db.SaveChanges();
        return Created(loan.Id.ToString(), loan);
    }

    
    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id)
    {
        Loan? loan = db.Loans.Find(id);

        if(loan == null)
            return NotFound();

        db.Loans.Remove(loan);
        db.SaveChanges();

        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult Update(int id, Loan loan)
    {
        Loan? _loan = db.Loans.Find(id);
        if(_loan == null)
            return NotFound();

        _loan.Id = loan.Id;
        _loan.Book = loan.Book;
        _loan.User = loan.User;
        _loan.LoanDate = loan.LoanDate;
        _loan.ReturnDate = loan.ReturnDate;

        db.SaveChanges();
        return Ok();
    }

}