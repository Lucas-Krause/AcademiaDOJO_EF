namespace AcademiaDOJO_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v07 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "public.Aluno", newName: "Pessoa");
            DropForeignKey("public.Aluno", "Nome", "public.Modalidade");
            DropIndex("public.Pessoa", new[] { "Nome" });
            AddColumn("public.Pessoa", "Turno", c => c.String(maxLength: 20));
            AddColumn("public.Pessoa", "SalarioHora", c => c.Double());
            AddColumn("public.Pessoa", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("public.Pessoa", "Modalidade_Nome", c => c.String(maxLength: 100));
            CreateIndex("public.Pessoa", "Modalidade_Nome");
            AddForeignKey("public.Pessoa", "Modalidade_Nome", "public.Modalidade", "Nome");
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
            
            DropForeignKey("public.Pessoa", "Modalidade_Nome", "public.Modalidade");
            DropIndex("public.Pessoa", new[] { "Modalidade_Nome" });
            DropColumn("public.Pessoa", "Modalidade_Nome");
            DropColumn("public.Pessoa", "Discriminator");
            DropColumn("public.Pessoa", "SalarioHora");
            DropColumn("public.Pessoa", "Turno");
            CreateIndex("public.Pessoa", "Nome");
            AddForeignKey("public.Aluno", "Nome", "public.Modalidade", "Nome");
            RenameTable(name: "public.Pessoa", newName: "Aluno");
        }
    }
}
