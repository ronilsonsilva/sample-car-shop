using CarShop.Shared.DTOs;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Web.ViewModels
{
    public class NewOrderViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [MaxLength(255)]
        [MinLength(1)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(255)]
        [MinLength(1)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Age ")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Occupation")]
        [MaxLength(255)]
        [MinLength(1)]
        public string Occupation { get; set; }

        [Required]
        [Display(Name = "Martial Status")]
        public MartialStatusEnumDto MartialStatus { get; set; }

        public int CarId { get; set; }
    }
}
