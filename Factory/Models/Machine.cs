using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinTables = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string MachineName { get; set; }

    public ICollection<EngineerMachine> JoinTables { get; set; }
  }
}