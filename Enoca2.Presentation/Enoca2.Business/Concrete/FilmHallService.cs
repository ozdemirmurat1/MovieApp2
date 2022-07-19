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
    public class FilmHallService : IFilmHallService
    {
        private readonly IFilmHallDal _filmHallDal;

        public FilmHallService(IFilmHallDal filmHallDal)
        {
            _filmHallDal = filmHallDal;
        }

        public void Add(FilmHall filmHall)
        {
            _filmHallDal.Add(filmHall);
        }

        public void Delete(FilmHall filmHall)
        {
            _filmHallDal.Delete(filmHall);
        }

        public FilmHall GetById(int filmHallId)
        {
            return _filmHallDal.Get(x => x.Id == filmHallId);
        }

        public List<FilmHall> List()
        {
            return _filmHallDal.List();
        }

        public void Update(FilmHall filmHall)
        {
            _filmHallDal.Update(filmHall);
        }
    }
}
