namespace Graded_unit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGurard : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Members", new[] { "address_id" });
            CreateTable(
                "dbo.Guardians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "Guardian_Id", c => c.Int());
            CreateIndex("dbo.Members", "Address_id");
            CreateIndex("dbo.Members", "Guardian_Id");
            AddForeignKey("dbo.Members", "Guardian_Id", "dbo.Guardians", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Guardian_Id", "dbo.Guardians");
            DropIndex("dbo.Members", new[] { "Guardian_Id" });
            DropIndex("dbo.Members", new[] { "Address_id" });
            DropColumn("dbo.Members", "Guardian_Id");
            DropTable("dbo.Guardians");
            CreateIndex("dbo.Members", "address_id");
        }
    }
}
