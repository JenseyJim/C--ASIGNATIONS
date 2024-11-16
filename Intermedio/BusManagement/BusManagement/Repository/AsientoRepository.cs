using BusManagement.Base;
using BusManagement.Context;
using BusManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagement.Repository
{
    public class AsientoRepository : BaseRepository<Asiento>
    {
        public AsientoRepository(DataContext context) : base(context)
        {
        }
    }
}
