namespace Graded_unit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        phone = c.String(),
                        address_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Addresses", t => t.address_id)
                .Index(t => t.address_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "address_id", "dbo.Addresses");
            DropIndex("dbo.Doctors", new[] { "address_id" });
            DropTable("dbo.Doctors");
            DropTable("dbo.Addresses");
        }
    }
}
