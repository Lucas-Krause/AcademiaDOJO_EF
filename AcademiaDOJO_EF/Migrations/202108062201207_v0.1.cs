namespace AcademiaDOJO_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Professors",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 14),
                        Turno = c.String(maxLength: 20),
                        SalarioHora = c.Double(nullable: false),
                        Nome = c.String(maxLength: 100),
                        Telefone = c.String(maxLength: 14),
                    })
                .PrimaryKey(t => t.CPF);
            
        }
        
        public override void Down()
        {
            DropTable("public.Professors");
        }
    }
}
