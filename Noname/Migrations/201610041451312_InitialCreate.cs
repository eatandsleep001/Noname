namespace Noname.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EMPLOYEE_MST",
                c => new
                    {
                        EMP_CODE = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        EMP_PASSWORD = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.EMP_CODE);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EMPLOYEE_MST");
        }
    }
}
