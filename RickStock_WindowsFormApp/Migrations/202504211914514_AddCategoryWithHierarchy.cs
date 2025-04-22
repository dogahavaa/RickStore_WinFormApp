namespace RickStock_WindowsFormApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryWithHierarchy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        UpCategoryID = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.UpCategoryID)
                .Index(t => t.UpCategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BarcodeNo = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        CategoryID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "UpCategoryID", "dbo.Categories");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.Categories", new[] { "UpCategoryID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
