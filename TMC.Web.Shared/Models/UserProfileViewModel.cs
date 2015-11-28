using System.ComponentModel.DataAnnotations;

namespace TMC.Web.Shared.Models
{
    public class UserProfileViewModel
    {

        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Mobile No")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid mobile number.")]
        public string MobileNo { get; set; }
    } 
}
