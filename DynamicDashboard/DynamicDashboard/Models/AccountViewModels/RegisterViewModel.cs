using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicDashboard.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} باید حداقل دارای {2} حرف باشد.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تایید رمز عبور")]
        [Compare("Password", ErrorMessage = "رمز عبود و تایید رمز عبور برابر نمی باشد")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "شماره تماس")]
        public virtual string PhoneNumber { get; set; }

        [Display(Name = "شماره تلفن همراه")]
        public virtual string Mobile { get; set; }

        [Required]
        [Display(Name = "نام کاربری")]
        public virtual string UserName { get; set; }

        [Required]
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }


        [Display(Name = "تاریخ تولد")]
        public string BirthDate { get; set; }

        
        [Display(Name = "آدرس")]
        public string Adddress { get; set; }

        [Display(Name = "پست سازمانی")]
        public string OrganizationPosition { get; set; }
    }
}
