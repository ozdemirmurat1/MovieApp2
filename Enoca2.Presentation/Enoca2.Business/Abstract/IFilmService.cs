using Enoca2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Business.Abstract
{
    public interface IFilmService
    {
        void Add(Film film);
        void Update(Film film);
        void Delete(Film film);
        Film GetById(int filmId);
        List<Film> List();
        List<FilmHallCustomModel> GetFilmDetail(string filmName_or_hallName);

        List<Film> GetFilmsByFilters(int? MinYear = null, int? MaxYear = null);

        List<FilmHallCustomModel> GetFilmDetailByYear(int? minYear, int? maxYear);

        List<FilmHallCustomModel> GetFilmDetail2();
    }
}
