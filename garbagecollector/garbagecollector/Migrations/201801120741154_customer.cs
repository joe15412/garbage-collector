namespace garbagecollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        FirstName = c.String(nullable: false, maxLength: 128),
                        LastName = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100),
                        Address = c.String(maxLength: 100),
                        City = c.String(maxLength: 100),
                        State = c.String(maxLength: 100),
                        ZipCode = c.String(maxLength: 20),
                        PhoneNumer = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.FirstName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
