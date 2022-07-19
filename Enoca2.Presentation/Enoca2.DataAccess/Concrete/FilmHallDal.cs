﻿using Enoca2.Core;
using Enoca2.DataAccess.Abstract;
using Enoca2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.DataAccess.Concrete
{
    public class FilmHallDal : RepositoryBase<FilmHall, Enoca2Context>, IFilmHallDal
    {
    }
}
