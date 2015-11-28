using System.ComponentModel.DataAnnotations;

namespace TMC.Web.Shared.Models
{
    public class RegisterViewModel
    {
       
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [RegularExpression( "^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$" , ErrorMessage = "Invalid email format." )]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Mobile No")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid mobile number.")]
        public string MobileNo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
