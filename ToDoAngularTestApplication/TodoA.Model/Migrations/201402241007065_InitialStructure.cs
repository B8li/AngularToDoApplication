namespace TodoA.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialStructure : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Status = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        FinishBefore = c.DateTime(),
                        List_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TodoLists", t => t.List_Id)
                .Index(t => t.List_Id);
            
            CreateTable(
                "dbo.TodoLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TodoLists", "Owner_Id", "dbo.Users");
            DropForeignKey("dbo.TodoItems", "List_Id", "dbo.TodoLists");
            DropIndex("dbo.TodoLists", new[] { "Owner_Id" });
            DropIndex("dbo.TodoItems", new[] { "List_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.TodoLists");
            DropTable("dbo.TodoItems");
        }
    }
}
