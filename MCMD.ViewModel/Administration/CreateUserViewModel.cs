using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MCMD.ViewModel.Administration
{
    public class CreateUserViewModel
    {

        //public int UserId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [Display(Name = "User First Name")]
        public string UserFirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [Display(Name = "User Last Name")]
        public string UserLastName { get; set; }

        [Required]
        [Display(Name = "Employee Id")]
        public int EmpID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "User Email")]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength =4 )]
        [DataType(DataType.Password)]
        [Display(Name = "User Password")]
        public string UserPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("UserPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [Display(Name = "User Role")]
        public string UserRole { get; set; }


        [Required]
        [Display(Name = "User Status")]
        public Boolean Status { get; set; }


       
        //[Display(Name = "Created Date")]
        //public DateTime? CreateOnDate { get; set; }

        //[Display(Name = "Created By")]
        //public int? CreateById { get; set; }

        //[Display(Name = "Modify Date")]
        //public DateTime? ModifyOnDate { get; set; }

        //[Display(Name = "Modify By")]
        //public int? ModifyById { get; set; }

    }
}
