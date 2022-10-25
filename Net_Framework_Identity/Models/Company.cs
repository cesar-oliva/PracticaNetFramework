using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Net_Framework_Identity.Models
{
    public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }
        [Required]
        [MaxLength(9, ErrorMessage= "The CUIT number must contain 9 characters"),MinLength(9)]
        public string CUIT { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }


    }
}