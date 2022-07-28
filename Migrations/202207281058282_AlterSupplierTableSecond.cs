namespace Eclerx.Question3.Anshuman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterSupplierTableSecond : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "Pincode", c => c.String(maxLength: 6, fixedLength: true, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suppliers", "Pincode");
        }
    }
}
