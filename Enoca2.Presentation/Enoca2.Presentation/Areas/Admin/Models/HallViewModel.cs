using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Enoca2.Presentation.Areas.Admin.Models
{
    public class HallViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Hall Name")]
        public string HallName { get; set; }
    }
}
