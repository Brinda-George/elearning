namespace ELearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class register1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BirthdateModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        month = c.String(),
                        day = c.Int(nullable: false),
                        year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CountryModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        country = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CountryModels");
            DropTable("dbo.BirthdateModels");
        }
    }
}
