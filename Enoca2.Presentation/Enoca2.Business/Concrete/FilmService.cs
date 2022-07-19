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
    public class FilmService : IFilmService
    {
        private readonly IFilmDal _filmDal;

        public FilmService(IFilmDal filmDal)
        {
            _filmDal = filmDal;
        }

        public void Add(Film film)
        {
            _filmDal.Add(film);
        }

        public void Delete(Film film)
        {
            _filmDal.Delete(film);
        }

        public Film GetById(int filmId)
        {
            return _filmDal.Get(x => x.Id == filmId);
        }

        public List<FilmHallCustomModel> GetFilmDetail(string filmName)
        {
            if (filmName!=null)
            {
                return _filmDal.GetFilmDetail(filmName);
            }
            return _filmDal.GetFilmDetail2();
        }

        public List<FilmHallCustomModel> GetFilmDetailByYear(int? minYear, int? maxYear)
        {
            if (minYear!=null && maxYear!=null)
            {
                return _filmDal.GetFilmDetailByYearAndName(minYear, maxYear);
            }
            return _filmDal.GetFilmDetail2();
        }

        public List<FilmHallCustomModel> GetFilmDetail2()
        {
            return _filmDal.GetFilmDetail2();
        }

        public List<Film> GetFilmsByFilters(int? MinYear = null, int? MaxYear = null)
        {           
            if (MinYear!=null && MaxYear!=null)
            {
                return _filmDal.List(x => x.FilmProductionYear >= MinYear && x.FilmProductionYear <= MaxYear);
            }
            return _filmDal.List();                      
        }

        public List<Film> List()
        {
            return _filmDal.List();
        }

        public void Update(Film film)
        {
            _filmDal.Update(film);
        }
    }
}
