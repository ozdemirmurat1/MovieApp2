using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Enoca2.Presentation.Areas.Admin.Models
{
    public class FilmViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Film Name")]
        public string FilmName { get; set; }
        [Required(ErrorMessage = "Please Enter Film Production Year")]
        public int FilmProductionYear { get; set; }
    }
}
