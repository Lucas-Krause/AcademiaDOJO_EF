namespace AcademiaDOJO_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v05 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "public.Aluno", newName: "Pessoa");
            AddColumn("public.Pessoa", "Turno", c => c.String(maxLength: 20));
            AddColumn("public.Pessoa", "SalarioHora", c => c.Double());
            AddColumn("public.Pessoa", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropTable("public.Professor");
        }
        
        public override void Down()
        {
            CreateTable(
                "public.Professor",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 14),
                        Turno = c.String(maxLength: 20),
                        SalarioHora = c.Double(nullable: false),
                        Nome = c.String(maxLength: 100),
                        Telefone = c.String(maxLength: 14),
                    })
                .PrimaryKey(t => t.CPF);
            
            DropColumn("public.Pessoa", "Discriminator");
            DropColumn("public.Pessoa", "SalarioHora");
            DropColumn("public.Pessoa", "Turno");
            RenameTable(name: "public.Pessoa", newName: "Aluno");
        }
    }
}
