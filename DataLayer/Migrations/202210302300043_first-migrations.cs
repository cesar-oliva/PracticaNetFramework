namespace AccDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigrations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Client", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Client", "DNI", c => c.String(nullable: false, maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Client", "DNI", c => c.String(nullable: false));
            AlterColumn("dbo.Client", "Name", c => c.String(nullable: false));
        }
    }
}
