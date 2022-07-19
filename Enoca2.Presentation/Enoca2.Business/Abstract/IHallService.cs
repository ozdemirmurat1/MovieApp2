using Enoca2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Business.Abstract
{
    public interface IHallService
    {
        void Add(Hall hall);
        void Update(Hall hall);
        void Delete(Hall hall);
        Hall GetById(int hallId);
        List<Hall> List();
    }
}
