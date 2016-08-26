namespace BitTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Permission = c.Byte(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        End_ID = c.Guid(),
                        Start_ID = c.Guid(),
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TemporalPoints", t => t.End_ID)
                .ForeignKey("dbo.TemporalPoints", t => t.Start_ID)
                .ForeignKey("dbo.People", t => t.Person_PersonId)
                .Index(t => t.End_ID)
                .Index(t => t.Start_ID)
                .Index(t => t.Person_PersonId);
            
            CreateTable(
                "dbo.TemporalPoints",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Day = c.Int(nullable: false),
                        MinutesPastMidnight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shifts", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.Shifts", "Start_ID", "dbo.TemporalPoints");
            DropForeignKey("dbo.Shifts", "End_ID", "dbo.TemporalPoints");
            DropIndex("dbo.Shifts", new[] { "Person_PersonId" });
            DropIndex("dbo.Shifts", new[] { "Start_ID" });
            DropIndex("dbo.Shifts", new[] { "End_ID" });
            DropTable("dbo.TemporalPoints");
            DropTable("dbo.Shifts");
            DropTable("dbo.People");
        }
    }
}
