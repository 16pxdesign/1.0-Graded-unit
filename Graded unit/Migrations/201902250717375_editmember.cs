namespace Graded_unit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editmember : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Members", "memberType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "memberType", c => c.Int(nullable: false));
        }
    }
}
