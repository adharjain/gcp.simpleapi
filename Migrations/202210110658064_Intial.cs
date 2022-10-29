namespace gcp.simpleapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        UserProfileId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        EmailId = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.UserProfileId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserProfiles");
        }
    }
}
