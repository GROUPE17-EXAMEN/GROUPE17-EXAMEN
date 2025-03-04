namespace ExamenProjetGestionEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finProjet : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cours", "classe_Id", "dbo.Classes");
            DropForeignKey("dbo.Matieres", "Cours_Id", "dbo.Cours");
            DropIndex("dbo.Cours", new[] { "classe_Id" });
            DropIndex("dbo.Matieres", new[] { "Cours_Id" });
            CreateTable(
                "dbo.CoursClasses",
                c => new
                    {
                        Cours_Id = c.Int(nullable: false),
                        Classe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cours_Id, t.Classe_Id })
                .ForeignKey("dbo.Cours", t => t.Cours_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Classe_Id, cascadeDelete: true)
                .Index(t => t.Cours_Id)
                .Index(t => t.Classe_Id);
            
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
            
            DropColumn("dbo.Cours", "IdClasse");
            DropColumn("dbo.Cours", "classe_Id");
            DropColumn("dbo.Matieres", "IdCours");
            DropColumn("dbo.Matieres", "Cours_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matieres", "Cours_Id", c => c.Int());
            AddColumn("dbo.Matieres", "IdCours", c => c.Int(nullable: false));
            AddColumn("dbo.Cours", "classe_Id", c => c.Int());
            AddColumn("dbo.Cours", "IdClasse", c => c.Int(nullable: false));
            DropForeignKey("dbo.MatiereCours", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.MatiereCours", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.CoursClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.CoursClasses", "Cours_Id", "dbo.Cours");
            DropIndex("dbo.MatiereCours", new[] { "Cours_Id" });
            DropIndex("dbo.MatiereCours", new[] { "Matiere_Id" });
            DropIndex("dbo.CoursClasses", new[] { "Classe_Id" });
            DropIndex("dbo.CoursClasses", new[] { "Cours_Id" });
            DropTable("dbo.MatiereCours");
            DropTable("dbo.CoursClasses");
            CreateIndex("dbo.Matieres", "Cours_Id");
            CreateIndex("dbo.Cours", "classe_Id");
            AddForeignKey("dbo.Matieres", "Cours_Id", "dbo.Cours", "Id");
            AddForeignKey("dbo.Cours", "classe_Id", "dbo.Classes", "Id");
        }
    }
}
