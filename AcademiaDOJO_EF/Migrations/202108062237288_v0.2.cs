namespace AcademiaDOJO_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Modalidades",
                c => new
                    {
                        Nome = c.String(nullable: false, maxLength: 100),
                        VezesSemana = c.Int(nullable: false),
                        PrecoHora = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Nome);
            
        }
        
        public override void Down()
        {
            DropTable("public.Modalidades");
        }
    }
}
