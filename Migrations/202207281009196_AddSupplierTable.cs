namespace Eclerx.Question3.Anshuman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupplierTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "CreatDate", c => c.DateTime(nullable: false, defaultValueSql: "Getdate()"));
            DropColumn("dbo.Suppliers", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Suppliers", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Suppliers", "CreatDate");
        }
    }
}
