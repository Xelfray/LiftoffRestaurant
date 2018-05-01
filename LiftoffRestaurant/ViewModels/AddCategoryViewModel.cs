using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiftoffRestaurant.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required]
        [Display(Name ="Category")]
        public string Name { get; set; }
    }
}
