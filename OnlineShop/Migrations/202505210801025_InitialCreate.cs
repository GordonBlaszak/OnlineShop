namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderLineEntities",
                c => new
                    {
                        OrderLineId = c.Long(nullable: false, identity: true),
                        ProductCode = c.String(),
                        NetPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GrossPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        OrderId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.OrderLineId)
                .ForeignKey("dbo.OrderEntities", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.OrderEntities",
                c => new
                    {
                        OrderId = c.Long(nullable: false, identity: true),
                        StoreId = c.Long(nullable: false),
                        Street = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        PaymentMethod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.StoreEntities", t => t.StoreId, cascadeDelete: true)
                .Index(t => t.StoreId);
            
            CreateTable(
                "dbo.StoreEntities",
                c => new
                    {
                        StoreId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.StoreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLineEntities", "OrderId", "dbo.OrderEntities");
            DropForeignKey("dbo.OrderEntities", "StoreId", "dbo.StoreEntities");
            DropIndex("dbo.OrderEntities", new[] { "StoreId" });
            DropIndex("dbo.OrderLineEntities", new[] { "OrderId" });
            DropTable("dbo.StoreEntities");
            DropTable("dbo.OrderEntities");
            DropTable("dbo.OrderLineEntities");
        }
    }
}
