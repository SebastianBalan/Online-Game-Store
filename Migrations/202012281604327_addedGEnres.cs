namespace Online_Game_store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedGEnres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.GenreGames",
                c => new
                    {
                        Genre_GenreId = c.Int(nullable: false),
                        Game_GameId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_GenreId, t.Game_GameId })
                .ForeignKey("dbo.Genres", t => t.Genre_GenreId, cascadeDelete: true)
                .ForeignKey("dbo.Games", t => t.Game_GameId, cascadeDelete: true)
                .Index(t => t.Genre_GenreId)
                .Index(t => t.Game_GameId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GenreGames", "Game_GameId", "dbo.Games");
            DropForeignKey("dbo.GenreGames", "Genre_GenreId", "dbo.Genres");
            DropIndex("dbo.GenreGames", new[] { "Game_GameId" });
            DropIndex("dbo.GenreGames", new[] { "Genre_GenreId" });
            DropTable("dbo.GenreGames");
            DropTable("dbo.Genres");
        }
    }
}
