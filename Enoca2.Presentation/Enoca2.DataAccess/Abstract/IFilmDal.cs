using Enoca2.Core;
using Enoca2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.DataAccess.Abstract
{
    public interface IFilmDal:IRepository<Film>
    {
        List<FilmHallCustomModel> GetFilmDetail(string filmName);
        List<FilmHallCustomModel> GetFilmDetail2();

        List<FilmHallCustomModel> GetFilmDetailByYearAndName(int? minYear,int? maxYear);
    }
}
