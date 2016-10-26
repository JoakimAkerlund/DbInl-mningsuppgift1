namespace DbInlämningsuppgift1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Birthday", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
