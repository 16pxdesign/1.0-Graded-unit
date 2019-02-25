namespace Graded_unit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editmember1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "memberType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "memberType");
        }
    }
}
