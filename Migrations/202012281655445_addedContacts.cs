namespace Online_Game_store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedContacts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        PublisherId = c.Int(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PublisherId)
                .ForeignKey("dbo.Publishers", t => t.PublisherId)
                .Index(t => t.PublisherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "PublisherId", "dbo.Publishers");
            DropIndex("dbo.Contacts", new[] { "PublisherId" });
            DropTable("dbo.Contacts");
        }
    }
}
