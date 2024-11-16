using BusManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagement.Context
{
    public class DataContext
    {
        public List<Asiento> Asientos { get; set; } = new List<Asiento>();
    }
}
