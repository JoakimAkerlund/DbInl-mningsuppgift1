namespace DbInlämningsuppgift1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zipcode : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Zipcode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Zipcode", c => c.Int(nullable: false));
        }
    }
}
