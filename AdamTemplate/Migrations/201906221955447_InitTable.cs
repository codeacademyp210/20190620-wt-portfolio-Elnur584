namespace AdamTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AmazingFeatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CardBody",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MainTitle = c.String(),
                        Title = c.String(),
                        Content = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IconArea",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IconName = c.String(),
                        Title = c.Int(nullable: false),
                        Content = c.Int(nullable: false),
                        MyProperty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HeaderContent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        NavItem = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MainContent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Date = c.Int(nullable: false),
                        BigContent = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PhotoArea",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhotoArea");
            DropTable("dbo.MainContent");
            DropTable("dbo.HeaderContent");
            DropTable("dbo.IconArea");
            DropTable("dbo.CardBody");
            DropTable("dbo.AmazingFeatures");
        }
    }
}
