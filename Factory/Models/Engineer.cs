using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinTables = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }

    public ICollection<EngineerMachine> JoinTables { get; set; }
  }
}