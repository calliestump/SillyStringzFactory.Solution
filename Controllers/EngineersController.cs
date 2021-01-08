using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db; // Defines Database as Factory
    public EngineersController(FactoryContext db) // constructor for Engineer Controller
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      //ViewBag.EngineerId = new SelectList(_db.Machines, "MachineId", "MachineName");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Engineer engineer) //, int MachineId
    {
      _db.Engineers.Add(engineer);
      // if (MachineId != 0)
      // {
      //   _db.EngineerMachine.Add(new EngineerMachine() { MachineId = MachineId, EngineerId = engineer.EngineerId });
      // }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisEngineer = _db.Engineers //returns name of Engineer & id
        .Include(engineer => engineer.JoinTables) //finds machines related to the engineer using "Join Tables"
        .ThenInclude(join => join.Machine) // adds the related machine 
        .FirstOrDefault(engineer => engineer.EngineerId == id); // finds engineer that matches the id
      return View(thisEngineer);
    }
    public ActionResult Edit(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id); // finds the match and assigns it to "thisEngineer"
      //ViewBag.EngineerId = new SelectList(_db.Machines, "MachineId", "MachineName"); // transfers data from controller to view
      return View(thisEngineer);
    }
    [HttpPost]
    public ActionResult Edit(Engineer engineer) //, int MachineId
    {
      // if (MachineId != 0)
      // {
      //   _db.EngineerMachine.Add(new EngineerMachine() { MachineId = MachineId, EngineerId = engineer.EngineerId });
      // }
      _db.Entry(engineer).State = EntityState.Modified; // Holds all information for engineer
      _db.SaveChanges(); // sends information for engineer to database
      return RedirectToAction("Index"); // returns to the index page of engineers.
    }
    public ActionResult AddMachine(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineers => engineers.EngineerId == id); 
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "MachineName");
      return View (thisEngineer);
    }
    [HttpPost]
    public ActionResult AddMachine(Engineer engineer, int MachineId)
    {
      if (MachineId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { MachineId = MachineId, EngineerId = engineer.EngineerId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


    public ActionResult Delete(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id); // finds the match and assigns it to "thisEngineer"
      return View(thisEngineer);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id); 
      _db.Engineers.Remove(thisEngineer); // removes all information regarding this specific engineer
      _db.SaveChanges(); // saves updated removal to database
      return RedirectToAction("Index");
    }
    [HttpPost]
    public ActionResult DeleteMachine(int joinId)
    {
      var joinEntry = _db.EngineerMachine.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
      _db.EngineerMachine.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}