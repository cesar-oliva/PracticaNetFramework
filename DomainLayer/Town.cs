using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.DomainLayer
{
	public class Town : EntityBase
	{
		public string Name { get; set; }
		public int CP { get; set; }
		public string NewCP { get; set; }
	}
}