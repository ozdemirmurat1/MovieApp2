using Enoca2.Business.Abstract;
using Enoca2.DataAccess.Abstract;
using Enoca2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Business.Concrete
{
    public class HallService : IHallService
    {
        private readonly IHallDal _hallDal;

        public HallService(IHallDal hallDal)
        {
            _hallDal = hallDal;
        }

        public void Add(Hall hall)
        {
            _hallDal.Add(hall);
        }

        public void Delete(Hall hall)
        {
            _hallDal.Delete(hall);
        }

        public Hall GetById(int hallId)
        {
            return _hallDal.Get(x => x.Id == hallId);
        }

        public List<Hall> List()
        {
            return _hallDal.List();
        }

        public void Update(Hall hall)
        {
            _hallDal.Update(hall);
        }
    }
}
