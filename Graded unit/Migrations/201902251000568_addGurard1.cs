namespace Graded_unit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGurard1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "Address_id", "dbo.Addresses");
            DropIndex("dbo.Members", new[] { "Address_id" });
            DropColumn("dbo.Members", "Email");
            DropColumn("dbo.Members", "Phone");
            DropColumn("dbo.Members", "Mobile");
            DropColumn("dbo.Members", "Dob");
            DropColumn("dbo.Members", "Address_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "Address_id", c => c.Int());
            AddColumn("dbo.Members", "Dob", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "Mobile", c => c.String());
            AddColumn("dbo.Members", "Phone", c => c.String());
            AddColumn("dbo.Members", "Email", c => c.String());
            CreateIndex("dbo.Members", "Address_id");
            AddForeignKey("dbo.Members", "Address_id", "dbo.Addresses", "id");
        }
    }
}
