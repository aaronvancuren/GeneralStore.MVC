namespace GeneralStore.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Transactions");
            DropColumn("dbo.Transactions", "Id");
            AddColumn("dbo.Transactions", "TransactionId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Transactions", "TransactionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Transactions");
            DropColumn("dbo.Transactions", "TransactionId");
            AddPrimaryKey("dbo.Transactions", "Id");
        }
    }
}
