using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using static IdentitySample.Models.ApplicationUser;

namespace IdentitySample.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "RoleName")]
        public string Name { get; set; }
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; } 
        public string State { get; set; }
        [Display(Name ="Postal Code")]
        public string PostalCode { get; set; }
        [Display(Name ="First Name")] 
        public string firstName { get; set; } 
        [Display(Name ="Last Name")] 
        public string lastName { get; set; } 
        [Display(Name ="Phone Number")]
        public string phoneNumber { get; set; }
        public Register register { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}