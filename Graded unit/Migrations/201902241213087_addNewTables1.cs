namespace Graded_unit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewTables1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        email = c.String(),
                        phone = c.String(),
                        mobile = c.String(),
                        DOB = c.DateTime(nullable: false),
                        memberType = c.Int(nullable: false),
                        address_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Addresses", t => t.address_id)
                .Index(t => t.address_id);
            
            AddColumn("dbo.Addresses", "street", c => c.String());
            AddColumn("dbo.Addresses", "flat", c => c.String());
            AddColumn("dbo.Addresses", "city", c => c.String());
            AddColumn("dbo.Addresses", "postcode", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "address_id", "dbo.Addresses");
            DropIndex("dbo.Members", new[] { "address_id" });
            DropColumn("dbo.Addresses", "postcode");
            DropColumn("dbo.Addresses", "city");
            DropColumn("dbo.Addresses", "flat");
            DropColumn("dbo.Addresses", "street");
            DropTable("dbo.Members");
        }
    }
}
