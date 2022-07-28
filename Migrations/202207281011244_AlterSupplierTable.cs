namespace Eclerx.Question3.Anshuman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterSupplierTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "CreatedDate", c => c.DateTime(nullable: false, defaultValueSql: "Getdate()"));
            DropColumn("dbo.Suppliers", "CreatDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Suppliers", "CreatDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Suppliers", "CreatedDate");
        }
    }
}
