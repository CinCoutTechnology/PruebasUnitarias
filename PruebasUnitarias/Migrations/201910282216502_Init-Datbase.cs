namespace PruebasUnitarias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatbase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Libro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Autor = c.String(),
                        FechaPublicaion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Libro");
        }
    }
}
