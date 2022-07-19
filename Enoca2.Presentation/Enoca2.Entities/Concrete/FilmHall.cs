using Enoca2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Entities.Concrete
{
    public class FilmHall:IEntity
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int HallId { get; set; }
        public int Sort { get; set; }
    }
}
