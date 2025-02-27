namespace ExamenProjetGestionEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstDataBaseMigrations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Matieres", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.Matieres", "Cours_Id", "dbo.Cours");
            DropIndex("dbo.Matieres", new[] { "Matiere_Id" });
            DropIndex("dbo.Matieres", new[] { "Cours_Id" });
            CreateTable(
                "dbo.MatiereCours",
                c => new
                    {
                        Matiere_Id = c.Int(nullable: false),
                        Cours_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Matiere_Id, t.Cours_Id })
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cours", t => t.Cours_Id, cascadeDelete: true)
                .Index(t => t.Matiere_Id)
                .Index(t => t.Cours_Id);
            
            DropColumn("dbo.Matieres", "Matiere_Id");
            DropColumn("dbo.Matieres", "Cours_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matieres", "Cours_Id", c => c.Int());
            AddColumn("dbo.Matieres", "Matiere_Id", c => c.Int());
            DropForeignKey("dbo.MatiereCours", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.MatiereCours", "Matiere_Id", "dbo.Matieres");
            DropIndex("dbo.MatiereCours", new[] { "Cours_Id" });
            DropIndex("dbo.MatiereCours", new[] { "Matiere_Id" });
            DropTable("dbo.MatiereCours");
            CreateIndex("dbo.Matieres", "Cours_Id");
            CreateIndex("dbo.Matieres", "Matiere_Id");
            AddForeignKey("dbo.Matieres", "Cours_Id", "dbo.Cours", "Id");
            AddForeignKey("dbo.Matieres", "Matiere_Id", "dbo.Matieres", "Id");
        }
    }
}
