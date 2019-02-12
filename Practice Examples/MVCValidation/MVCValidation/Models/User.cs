using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCValidation.Models
{
    [Table("UserTbl")]
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} character long but no longer than {1} character",MinimumLength = 2)]
        [Display(Name = " First Name")]
        [RegularExpression(@"^([A-Z][a-z]+)\s([A-Z][a-zA-Z-]+)$", ErrorMessage = "Please enter a valid name")]
        public string FirsName { get; set; }

        [Required(ErrorMessage = "Please enter your {0}")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} character long but no longer than {1} character", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your {0} address")]
        [EmailAddress(ErrorMessage = "Email Address is not valid")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Range(10000, 100000, ErrorMessage = "The range mus between 10000 and 100000")]
        public decimal Salary { get; set; }
    }
}