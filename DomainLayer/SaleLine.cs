using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.DomainLayer
{
	public class SaleLine : EntityBase
	{
		public int Quantity { get; set; }
		[NotMapped]
		public decimal Total { get => Product.TotalPrice * Quantity; }
		public virtual Product Product { get; set; }
		public int ProductId { get; set; }
	}
}