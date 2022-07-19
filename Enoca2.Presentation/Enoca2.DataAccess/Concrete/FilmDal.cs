using Enoca2.Core;
using Enoca2.DataAccess.Abstract;
using Enoca2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.DataAccess.Concrete
{
    public class FilmDal : RepositoryBase<Film, Enoca2Context>, IFilmDal
    {
        public List<FilmHallCustomModel> GetFilmDetail(string filmName)
        {
            using (Enoca2Context context=new Enoca2Context())
            {
                var result = (from f in context.Films
                              join h in context.FilmHall
                              on f.Id equals h.FilmId
                              join ha in context.Halls
                              on h.HallId equals ha.Id
                              where f.FilmName==filmName || ha.HallName==filmName
                              select new FilmHallCustomModel 
                              {
                                HallId=h.HallId,
                                FilmName=f.FilmName,
                                FilmProductionYear=f.FilmProductionYear,
                                Id=f.Id,
                                HallName=ha.HallName
                              
                              }).ToList();
                return result;
            }
        }

        public List<FilmHallCustomModel> GetFilmDetailByYearAndName(int? minYear, int? maxYear)
        {
            using (Enoca2Context context = new Enoca2Context())
            {
                var result = (from f in context.Films
                              join h in context.FilmHall
                              on f.Id equals h.FilmId
                              join ha in context.Halls
                              on h.HallId equals ha.Id
                              where f.FilmProductionYear>=minYear && f.FilmProductionYear<=maxYear 
                              select new FilmHallCustomModel
                              {
                                  HallId = h.HallId,
                                  FilmName = f.FilmName,
                                  FilmProductionYear = f.FilmProductionYear,
                                  Id = f.Id,
                                  HallName = ha.HallName

                              }).ToList();
                return result;
            }
        }

        public List<FilmHallCustomModel> GetFilmDetail2()
        {
            using (Enoca2Context context=new Enoca2Context())
            {
                var result = (from f in context.Films
                              join h in context.FilmHall
                              on f.Id equals h.FilmId
                              join ha in context.Halls
                              on h.HallId equals ha.Id
                              select new FilmHallCustomModel
                              {
                                  HallId = h.HallId,
                                  FilmName = f.FilmName,
                                  FilmProductionYear = f.FilmProductionYear,
                                  Id = f.Id,
                                  HallName = ha.HallName

                              }).ToList();
                return result;
            }
        }
    }
}
