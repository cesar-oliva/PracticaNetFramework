using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace NET_Framework.DomainLayer
{
	public class City: EntityBase
	{
		public string Name { get; set; }
		public virtual ICollection<Town> Towns { get; set; }
	}
}