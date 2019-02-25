namespace Graded_unit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGurard2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "Name", c => c.String());
        }
    }
}
