namespace ExamenProjetGestionEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NomClasse, unique: true);
            
            CreateTable(
                "dbo.ClassesCours",
                c => new
                    {
                        IdClasse = c.Int(nullable: false),
                        IdCours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdClasse, t.IdCours })
                .ForeignKey("dbo.Classes", t => t.IdClasse, cascadeDelete: true)
                .ForeignKey("dbo.Cours", t => t.IdCours, cascadeDelete: true)
                .Index(t => t.IdClasse)
                .Index(t => t.IdCours);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(maxLength: 255),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NomCours, unique: true);
            
            CreateTable(
                "dbo.CoursMatieres",
                c => new
                    {
                        IdCours = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdCours, t.IdMatiere })
                .ForeignKey("dbo.Cours", t => t.IdCours, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.IdMatiere, cascadeDelete: true)
                .Index(t => t.IdCours)
                .Index(t => t.IdMatiere);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatiere = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NomMatiere, unique: true);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(maxLength: 255),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Sexe = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 255),
                        IdClasse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.IdClasse, cascadeDelete: true)
                .Index(t => t.Matricule, unique: true)
                .Index(t => t.Telephone, unique: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.IdClasse);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEtudiant = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        Note = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.IdEtudiant, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.IdMatiere, cascadeDelete: true)
                .Index(t => t.IdEtudiant)
                .Index(t => t.IdMatiere);
            
            CreateTable(
                "dbo.OTPCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUtilisateur = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        DateExpiration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.IdUtilisateur, cascadeDelete: true)
                .Index(t => t.IdUtilisateur)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(maxLength: 50),
                        MotDePasse = c.String(),
                        Role = c.String(),
                        Telephone = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NomUtilisateur, unique: true)
                .Index(t => t.Telephone, unique: true);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Telephone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Telephone, unique: true)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.ProfesseursClasses",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false),
                        IdClasse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdProfesseur, t.IdClasse })
                .ForeignKey("dbo.Classes", t => t.IdClasse, cascadeDelete: true)
                .ForeignKey("dbo.Professeurs", t => t.IdProfesseur, cascadeDelete: true)
                .Index(t => t.IdProfesseur)
                .Index(t => t.IdClasse);
            
            CreateTable(
                "dbo.ProfesseursMatieres",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdProfesseur, t.IdMatiere })
                .ForeignKey("dbo.Matieres", t => t.IdMatiere, cascadeDelete: true)
                .ForeignKey("dbo.Professeurs", t => t.IdProfesseur, cascadeDelete: true)
                .Index(t => t.IdProfesseur)
                .Index(t => t.IdMatiere);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfesseursMatieres", "IdProfesseur", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursMatieres", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.ProfesseursClasses", "IdProfesseur", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursClasses", "IdClasse", "dbo.Classes");
            DropForeignKey("dbo.OTPCodes", "IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Notes", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "IdEtudiant", "dbo.Etudiants");
            DropForeignKey("dbo.Etudiants", "IdClasse", "dbo.Classes");
            DropForeignKey("dbo.CoursMatieres", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.CoursMatieres", "IdCours", "dbo.Cours");
            DropForeignKey("dbo.ClassesCours", "IdCours", "dbo.Cours");
            DropForeignKey("dbo.ClassesCours", "IdClasse", "dbo.Classes");
            DropIndex("dbo.ProfesseursMatieres", new[] { "IdMatiere" });
            DropIndex("dbo.ProfesseursMatieres", new[] { "IdProfesseur" });
            DropIndex("dbo.ProfesseursClasses", new[] { "IdClasse" });
            DropIndex("dbo.ProfesseursClasses", new[] { "IdProfesseur" });
            DropIndex("dbo.Professeurs", new[] { "Email" });
            DropIndex("dbo.Professeurs", new[] { "Telephone" });
            DropIndex("dbo.Utilisateurs", new[] { "Telephone" });
            DropIndex("dbo.Utilisateurs", new[] { "NomUtilisateur" });
            DropIndex("dbo.OTPCodes", new[] { "Code" });
            DropIndex("dbo.OTPCodes", new[] { "IdUtilisateur" });
            DropIndex("dbo.Notes", new[] { "IdMatiere" });
            DropIndex("dbo.Notes", new[] { "IdEtudiant" });
            DropIndex("dbo.Etudiants", new[] { "IdClasse" });
            DropIndex("dbo.Etudiants", new[] { "Email" });
            DropIndex("dbo.Etudiants", new[] { "Telephone" });
            DropIndex("dbo.Etudiants", new[] { "Matricule" });
            DropIndex("dbo.Matieres", new[] { "NomMatiere" });
            DropIndex("dbo.CoursMatieres", new[] { "IdMatiere" });
            DropIndex("dbo.CoursMatieres", new[] { "IdCours" });
            DropIndex("dbo.Cours", new[] { "NomCours" });
            DropIndex("dbo.ClassesCours", new[] { "IdCours" });
            DropIndex("dbo.ClassesCours", new[] { "IdClasse" });
            DropIndex("dbo.Classes", new[] { "NomClasse" });
            DropTable("dbo.ProfesseursMatieres");
            DropTable("dbo.ProfesseursClasses");
            DropTable("dbo.Professeurs");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.OTPCodes");
            DropTable("dbo.Notes");
            DropTable("dbo.Etudiants");
            DropTable("dbo.Matieres");
            DropTable("dbo.CoursMatieres");
            DropTable("dbo.Cours");
            DropTable("dbo.ClassesCours");
            DropTable("dbo.Classes");
        }
    }
}
