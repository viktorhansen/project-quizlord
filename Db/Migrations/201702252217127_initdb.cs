namespace Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Difficulty = c.Int(nullable: false),
                        Subject = c.String(),
                        Body = c.String(),
                        Points = c.Int(nullable: false),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        CreatedById = c.Guid(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedById = c.Guid(),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Quiz",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        QuizCategory = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        CreatedById = c.Guid(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedById = c.Guid(),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quiz");
            DropTable("dbo.Questions");
        }
    }
}
