using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db; // Defines Database as Factory
    public MachinesController(FactoryContext db) // constructor for Engineer Controller
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Machines.ToList());
    }
    public ActionResult Create()
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Machine machine, int EngineerId)
    {
      _db.Machines.Add(machine);
      if (EngineerId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { 
          EngineerId = EngineerId, MachineId = machine.MachineId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisMachine = _db.Machines //returns name of Engineer & id
        .Include(machine => machine.JoinTables) //finds machines related to the engineer using "Join Tables"
        .ThenInclude(join => join.Engineer) // adds the related machine 
        .FirstOrDefault(machine => machine.MachineId == id); // finds engineer that matches the id
      return View(thisMachine);
    }
    public ActionResult Edit(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id); // finds the match and assigns it to "thisEngineer"
      ViewBag.MachineId = new SelectList(_db.Engineers, "EngineerId", "EngineerName"); // transfers data from controller to view
      return View(thisMachine);
    }
    [HttpPost]
    public ActionResult Edit(Machine machine, int EngineerId)
    {
      if (EngineerId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
      }
      _db.Entry(machine).State = EntityState.Modified; // Holds all information for engineer
      _db.SaveChanges(); // sends information for engineer to database
      return RedirectToAction("Index"); // returns to the index page of Machines.
    }
    public ActionResult AddEngineer(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machines => machines.MachineId == id); 
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      return View (thisMachine);
    }
    [HttpPost]
    public ActionResult AddEngineer(Machine machine, int EngineerId)
    {
      if (EngineerId != 0)
      {
        //var returnedJoin = _db.EngineerMachine.Any(join => join.MachineId == machine.MachineId && join.EngineerId == EngineerId);
        _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machines => machines.MachineId == id); // finds the match and assigns it to "thisEngineer"
      return View(thisMachine);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machines => machines.MachineId == id); // finds the match and assigns it to "thisEngineer"
      _db.Machines.Remove(thisMachine); // removes all information regarding this specific engineer
      _db.SaveChanges(); // saves updated removal to database
      return RedirectToAction("Index");
    }
    [HttpPost]
    public ActionResult DeleteEngineer(int joinId)
    {
      var joinEntry = _db.EngineerMachine.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
      _db.EngineerMachine.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}