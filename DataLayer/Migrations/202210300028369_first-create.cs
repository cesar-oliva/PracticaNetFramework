namespace AccDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adress",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdressName = c.String(nullable: false),
                        Number = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        ClientId = c.Int(nullable: false),
                        TownId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Town", t => t.TownId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.TownId);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DNI = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Town",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CP = c.Int(nullable: false),
                        NewCP = c.String(),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BussinesName = c.String(nullable: false, maxLength: 50),
                        CUIT = c.String(nullable: false, maxLength: 11),
                        FantasyName = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Adress = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CompanyId = c.Int(nullable: false),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Company", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Sale",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        SN = c.Int(nullable: false),
                        IsClosed = c.Boolean(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Company", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.SaleLine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Sale_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sale", t => t.Sale_Id)
                .Index(t => t.ProductId)
                .Index(t => t.Sale_Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Password = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Client_Id = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.Client_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Role", "User_Id", "dbo.User");
            DropForeignKey("dbo.User", "Client_Id", "dbo.Client");
            DropForeignKey("dbo.SaleLine", "Sale_Id", "dbo.Sale");
            DropForeignKey("dbo.SaleLine", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Sale", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.Product", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.Town", "City_Id", "dbo.City");
            DropForeignKey("dbo.Adress", "TownId", "dbo.Town");
            DropForeignKey("dbo.Adress", "ClientId", "dbo.Client");
            DropIndex("dbo.Role", new[] { "User_Id" });
            DropIndex("dbo.User", new[] { "Company_Id" });
            DropIndex("dbo.User", new[] { "Client_Id" });
            DropIndex("dbo.SaleLine", new[] { "Sale_Id" });
            DropIndex("dbo.SaleLine", new[] { "ProductId" });
            DropIndex("dbo.Sale", new[] { "CompanyId" });
            DropIndex("dbo.Product", new[] { "CompanyId" });
            DropIndex("dbo.Town", new[] { "City_Id" });
            DropIndex("dbo.Adress", new[] { "TownId" });
            DropIndex("dbo.Adress", new[] { "ClientId" });
            DropTable("dbo.Role");
            DropTable("dbo.User");
            DropTable("dbo.SaleLine");
            DropTable("dbo.Sale");
            DropTable("dbo.Product");
            DropTable("dbo.Company");
            DropTable("dbo.City");
            DropTable("dbo.Town");
            DropTable("dbo.Client");
            DropTable("dbo.Adress");
        }
    }
}
