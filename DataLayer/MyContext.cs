using NET_Framework.DomainLayer;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataLayer
{
    public class MyContext : DbContext
    {
        public MyContext() : base("Data Source = CESAR-COREI5\\SQLEXPRESS; Initial Catalog = NET_Framework; Integrated Security = True")
        {
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder
				.Conventions
				.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
            
			modelBuilder.Entity<City>()
                .HasMany(f => f.Towns)
                .WithOptional()
				.WillCascadeOnDelete(false);
		}

		private void FixEfProviderServicesProblem()
		{
			// The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
			// for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
			// Make sure the provider assembly is available to the running application. 
			// See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
			var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
		}

		public DbSet<Adress> Adresses { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Company> Companys { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Sale> Sales { get; set; }
		public DbSet<SaleLine> SaleLines { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Town> Towns { get; set; }
	}    
}
