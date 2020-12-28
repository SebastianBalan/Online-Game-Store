namespace Online_Game_store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPublishers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        PublisherId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PublisherId);
            
            AddColumn("dbo.Games", "PublisherId", c => c.Int(nullable: false));
            CreateIndex("dbo.Games", "PublisherId");
            AddForeignKey("dbo.Games", "PublisherId", "dbo.Publishers", "PublisherId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "PublisherId", "dbo.Publishers");
            DropIndex("dbo.Games", new[] { "PublisherId" });
            DropColumn("dbo.Games", "PublisherId");
            DropTable("dbo.Publishers");
        }
    }
}
