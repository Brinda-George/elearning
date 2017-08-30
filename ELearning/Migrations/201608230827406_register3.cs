namespace ELearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class register3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaterialModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        technology = c.String(),
                        material1 = c.String(),
                        material2 = c.String(),
                        material3 = c.String(),
                        material4 = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MaterialModels");
        }
    }
}
