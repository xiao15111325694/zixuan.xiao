namespace Domin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2018123222 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NodeName = c.String(),
                        Description = c.String(),
                        CreateOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nodes");
        }
    }
}
