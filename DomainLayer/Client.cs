using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NET_Framework.DomainLayer
{
	public class Client : EntityBase
	{
		[Required(ErrorMessage = "El cliente debe tener un nomber.")]
        [StringLength(100)]
		public string Name { get; set; }
		[Required(ErrorMessage = "El DNI no puede estar vacio.")]
		[StringLength(8)]
		public string DNI { get; set; }
		public ICollection<Adress> Adress { get; set; }
	}
}