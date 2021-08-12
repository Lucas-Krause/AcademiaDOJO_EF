namespace AcademiaDOJO_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v011 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.Pessoa", "Telefone", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("public.Pessoa", "Telefone", c => c.String(maxLength: 14));
        }
    }
}
