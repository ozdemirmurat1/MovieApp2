using Enoca2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Entities.Concrete
{
    public class Hall:IEntity
    {
        public int Id { get; set; }
        public string HallName { get; set; }
    }
}
