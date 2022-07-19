using Enoca2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Business.Abstract
{
    public interface IFilmHallService
    {
        void Add(FilmHall filmHall);
        void Update(FilmHall filmHall);
        void Delete(FilmHall filmHall);
        FilmHall GetById(int filmHallId);
        List<FilmHall> List();
    }
}
