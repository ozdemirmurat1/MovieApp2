using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Enoca2.Presentation.Areas.Admin.Models
{
    public class FilmHallViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter FilmId")]
        public int FilmId { get; set; }
        [Required(ErrorMessage = "Please Enter HallId")]
        public int HallId { get; set; }
        [Required(ErrorMessage = "Please Enter Sort")]
        public int Sort { get; set; }
    }
}
