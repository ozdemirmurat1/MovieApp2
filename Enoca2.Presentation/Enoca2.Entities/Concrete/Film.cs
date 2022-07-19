﻿using Enoca2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Enoca2.Entities.Concrete
{
    public class Film : IEntity 
    {
        public int Id { get; set; }
        public string FilmName { get; set; }
        public int FilmProductionYear { get; set; }
    }
}
