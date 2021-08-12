namespace AcademiaDOJO_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v09 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Pessoa", "Modalidade_Nome", c => c.String(maxLength: 100));
            AddColumn("public.Modalidade", "Professor_CPF", c => c.String(maxLength: 14));
            CreateIndex("public.Pessoa", "Modalidade_Nome");
            CreateIndex("public.Modalidade", "Professor_CPF");
            AddForeignKey("public.Modalidade", "Professor_CPF", "public.Pessoa", "CPF");
            AddForeignKey("public.Pessoa", "Modalidade_Nome", "public.Modalidade", "Nome");
        }
        
        public override void Down()
        {
            DropForeignKey("public.Pessoa", "Modalidade_Nome", "public.Modalidade");
            DropForeignKey("public.Modalidade", "Professor_CPF", "public.Pessoa");
            DropIndex("public.Modalidade", new[] { "Professor_CPF" });
            DropIndex("public.Pessoa", new[] { "Modalidade_Nome" });
            DropColumn("public.Modalidade", "Professor_CPF");
            DropColumn("public.Pessoa", "Modalidade_Nome");
        }
    }
}
