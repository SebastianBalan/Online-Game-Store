namespace Online_Game_store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedGames : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Creator = c.String(),
                        DateCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GameId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
