using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Entities.Concrete
{
    public class FilmHallCustomModel:Film
    {
        public int HallId { get; set; }
        public string HallName { get; set; }
    }
}
