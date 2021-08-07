namespace AcademiaDOJO_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v03 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Alunoes",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 14),
                        Nome = c.String(maxLength: 100),
                        Telefone = c.String(maxLength: 14),
                    })
                .PrimaryKey(t => t.CPF);
            
        }
        
        public override void Down()
        {
            DropTable("public.Alunoes");
        }
    }
}
