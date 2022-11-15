using Microsoft.AspNetCore.Mvc;
using LibManager.Models;

namespace LibManager.Controllers;

[ApiController]
[Route("user")]
public class UserController: ControllerBase
{
    private DBLib db;

    public UserController(DBLib db)
    {
        this.db = db;
    }

    [HttpGet]
    public ActionResult Read()
    {        
        return Ok(db.Users.ToList());
    }

    [HttpPost]
    public ActionResult Create(User user)
    {
        // INSERT INTO Game VALUES (...)
        db.Users.Add(user);
        db.SaveChanges();

        // processar o que eu quiser.
        return Created(user.Id.ToString(), user);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id)
    {
        User? user = db.Users.Find(id);

        if(user == null)
            return NotFound();

        db.Users.Remove(user);
        db.SaveChanges();

        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult Update(int id, User user)
    {
        User? _user = db.Users.Find(id);
        if(_user == null)
            return NotFound();

        _user.Id = user.Id;
        _user.Username = user.Username;
        _user.Email = user.Email;
        _user.Password = user.Password;
        _user.Admin = user.Admin;

        db.SaveChanges();
        return Ok();
    }

}