using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Net_Framework_Identity.Models
{
    public class Client
    {
        [Key]
        public Guid ClientId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(8, ErrorMessage = "The DNI number must contain 8 characters"), MinLength(8)]
        public string Dni { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public Guid AdressId { get; set; }


        public virtual Adress Adress { get; set; }
    }
}