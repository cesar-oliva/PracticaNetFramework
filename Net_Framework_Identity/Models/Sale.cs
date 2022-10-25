using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Net_Framework_Identity.Models
{
    public class Sale
    {
        [Key]
        public Guid SaleId { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public string SaleNumber { get; set; }
        [Required]
        public bool IsClosed { get; set; }

        //constructor
        public Sale(Guid saleId, DateTime creationDate, string saleNumber, bool isClosed)
        {
            SaleId = saleId;
            CreationDate = creationDate;
            SaleNumber = saleNumber;
            IsClosed = isClosed;
        }

        //metodos
        public void CloseSale()
        {
            IsClosed = true;
        }
        



    }
}