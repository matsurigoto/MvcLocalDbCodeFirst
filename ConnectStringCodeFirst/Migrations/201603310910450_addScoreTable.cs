namespace ConnectStringCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addScoreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Score",
                c => new
                    {
                        guid = c.Guid(nullable: false),
                        English = c.String(),
                        Chinese = c.String(),
                        Math = c.String(),
                    })
                .PrimaryKey(t => t.guid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Score");
        }
    }
}
