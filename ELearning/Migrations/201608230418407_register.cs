namespace ELearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class register : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisterModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        username = c.String(),
                        password = c.String(),
                        country = c.String(),
                        month = c.String(),
                        day = c.Int(nullable: false),
                        year = c.Int(nullable: false),
                        gender = c.String(),
                        phone = c.Double(nullable: false),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegisterModels");
        }
    }
}
