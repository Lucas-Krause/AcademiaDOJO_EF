namespace AcademiaDOJO_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v04 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "public.Alunoes", newName: "Aluno");
            RenameTable(name: "public.Modalidades", newName: "Modalidade");
            RenameTable(name: "public.Professors", newName: "Professor");
        }
        
        public override void Down()
        {
            RenameTable(name: "public.Professor", newName: "Professors");
            RenameTable(name: "public.Modalidade", newName: "Modalidades");
            RenameTable(name: "public.Aluno", newName: "Alunoes");
        }
    }
}
