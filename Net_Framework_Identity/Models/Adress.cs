using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Net_Framework_Identity.Models
{
    public class Adress
    {
        [Key]
        public Guid AdressId { get; set; }
        [Required]
        [MaxLength(50)]
        public string DescriptionAdress { get; set; }
    }

}