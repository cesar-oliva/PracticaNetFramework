using System.ComponentModel.DataAnnotations;

namespace NET_Framework.DomainLayer
{
	public class Role : EntityBase
	{
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
	}
}