namespace ExamenProjetGestionEtudiant
{
    partial class CoursForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCours = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomCours = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAtribCoursClasse = new System.Windows.Forms.Button();
            this.btnListeClasse = new System.Windows.Forms.Button();
            this.btnAddMat = new System.Windows.Forms.Button();
            this.btnListMat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
=======
<<<<<<< Updated upstream
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomCours = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cmbMatiere = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Cours";
=======
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListMat = new System.Windows.Forms.Button();
            this.btnAddMat = new System.Windows.Forms.Button();
            this.btnListeClasse = new System.Windows.Forms.Button();
            this.btnAtribCoursClasse = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNomCours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCours = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
>>>>>>> e723c0f18207e7896ffd1d18551a1c83d0fe6cb6
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCours);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(414, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 450);
            this.panel2.TabIndex = 1;
            // 
=======
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 577);
            this.panel1.TabIndex = 0;
            // 
>>>>>>> e723c0f18207e7896ffd1d18551a1c83d0fe6cb6
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnListMat);
            this.groupBox1.Controls.Add(this.btnAddMat);
            this.groupBox1.Controls.Add(this.btnListeClasse);
            this.groupBox1.Controls.Add(this.btnAtribCoursClasse);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtNomCours);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulaire";
=======
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(446, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulaire";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnListMat
            // 
            this.btnListMat.Location = new System.Drawing.Point(231, 481);
            this.btnListMat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListMat.Name = "btnListMat";
            this.btnListMat.Size = new System.Drawing.Size(188, 46);
            this.btnListMat.TabIndex = 10;
            this.btnListMat.Text = "Liste matières";
            this.btnListMat.UseVisualStyleBackColor = true;
            this.btnListMat.Click += new System.EventHandler(this.btnListMat_Click);
            // 
            // btnAddMat
            // 
            this.btnAddMat.Location = new System.Drawing.Point(96, 355);
            this.btnAddMat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMat.Name = "btnAddMat";
            this.btnAddMat.Size = new System.Drawing.Size(232, 46);
            this.btnAddMat.TabIndex = 9;
            this.btnAddMat.Text = "Ajouter une matière";
            this.btnAddMat.UseVisualStyleBackColor = true;
            this.btnAddMat.Click += new System.EventHandler(this.btnAddMat_Click);
            // 
            // btnListeClasse
            // 
            this.btnListeClasse.Location = new System.Drawing.Point(13, 481);
            this.btnListeClasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListeClasse.Name = "btnListeClasse";
            this.btnListeClasse.Size = new System.Drawing.Size(188, 46);
            this.btnListeClasse.TabIndex = 8;
            this.btnListeClasse.Text = "Liste des classes";
            this.btnListeClasse.UseVisualStyleBackColor = true;
            this.btnListeClasse.Click += new System.EventHandler(this.btnListeClasse_Click);
            // 
            // btnAtribCoursClasse
            // 
            this.btnAtribCoursClasse.Location = new System.Drawing.Point(12, 409);
            this.btnAtribCoursClasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtribCoursClasse.Name = "btnAtribCoursClasse";
            this.btnAtribCoursClasse.Size = new System.Drawing.Size(426, 46);
            this.btnAtribCoursClasse.TabIndex = 7;
            this.btnAtribCoursClasse.Text = "Attribuer ce cours à une classe";
            this.btnAtribCoursClasse.UseVisualStyleBackColor = true;
            this.btnAtribCoursClasse.Click += new System.EventHandler(this.btnAtribCoursClasse_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 301);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 46);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 301);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 200);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(407, 78);
            this.txtDescription.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(285, 90);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(134, 42);
            this.txtId.TabIndex = 3;
            this.txtId.Visible = false;
            // 
            // txtNomCours
            // 
            this.txtNomCours.Location = new System.Drawing.Point(12, 90);
            this.txtNomCours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomCours.Multiline = true;
            this.txtNomCours.Name = "txtNomCours";
            this.txtNomCours.Size = new System.Drawing.Size(252, 42);
            this.txtNomCours.TabIndex = 2;
>>>>>>> Stashed changes
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< Updated upstream
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // txtNomCours
            // 
            this.txtNomCours.Location = new System.Drawing.Point(120, 34);
            this.txtNomCours.Name = "txtNomCours";
            this.txtNomCours.Size = new System.Drawing.Size(194, 26);
            this.txtNomCours.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 89);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(194, 26);
            this.txtDescription.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(374, 217);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(231, 238);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(83, 46);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cmbMatiere
            // 
            this.cmbMatiere.FormattingEnabled = true;
            this.cmbMatiere.Location = new System.Drawing.Point(120, 146);
            this.cmbMatiere.Name = "cmbMatiere";
            this.cmbMatiere.Size = new System.Drawing.Size(194, 28);
            this.cmbMatiere.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Matiere";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Associer des matiers au classe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(427, 280);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 41);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(593, 280);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(115, 41);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
=======
            this.label2.Location = new System.Drawing.Point(8, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du cours";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCours);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(466, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 577);
            this.panel2.TabIndex = 1;
>>>>>>> e723c0f18207e7896ffd1d18551a1c83d0fe6cb6
            // 
            // dataGridViewCours
            // 
            this.dataGridViewCours.AllowUserToAddRows = false;
            this.dataGridViewCours.AllowUserToDeleteRows = false;
            this.dataGridViewCours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dataGridViewCours.Location = new System.Drawing.Point(6, 12);
=======
            this.dataGridViewCours.Location = new System.Drawing.Point(7, 15);
            this.dataGridViewCours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
>>>>>>> e723c0f18207e7896ffd1d18551a1c83d0fe6cb6
            this.dataGridViewCours.Name = "dataGridViewCours";
            this.dataGridViewCours.ReadOnly = true;
            this.dataGridViewCours.RowHeadersWidth = 51;
            this.dataGridViewCours.RowTemplate.Height = 24;
<<<<<<< HEAD
            this.dataGridViewCours.Size = new System.Drawing.Size(377, 426);
            this.dataGridViewCours.TabIndex = 0;
            this.dataGridViewCours.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCours_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du cours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // txtNomCours
            // 
            this.txtNomCours.Location = new System.Drawing.Point(11, 72);
            this.txtNomCours.Multiline = true;
            this.txtNomCours.Name = "txtNomCours";
            this.txtNomCours.Size = new System.Drawing.Size(224, 34);
            this.txtNomCours.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(253, 72);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 34);
            this.txtId.TabIndex = 3;
            this.txtId.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(11, 160);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(362, 103);
            this.txtDescription.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 37);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAtribCoursClasse
            // 
            this.btnAtribCoursClasse.Location = new System.Drawing.Point(11, 333);
            this.btnAtribCoursClasse.Name = "btnAtribCoursClasse";
            this.btnAtribCoursClasse.Size = new System.Drawing.Size(379, 37);
            this.btnAtribCoursClasse.TabIndex = 7;
            this.btnAtribCoursClasse.Text = "Attribuer ce cours à une classe";
            this.btnAtribCoursClasse.UseVisualStyleBackColor = true;
            this.btnAtribCoursClasse.Click += new System.EventHandler(this.btnAtribCoursClasse_Click);
            // 
            // btnListeClasse
            // 
            this.btnListeClasse.Location = new System.Drawing.Point(223, 290);
            this.btnListeClasse.Name = "btnListeClasse";
            this.btnListeClasse.Size = new System.Drawing.Size(167, 37);
            this.btnListeClasse.TabIndex = 8;
            this.btnListeClasse.Text = "Liste des classes";
            this.btnListeClasse.UseVisualStyleBackColor = true;
            this.btnListeClasse.Click += new System.EventHandler(this.btnListeClasse_Click);
            // 
            // btnAddMat
            // 
            this.btnAddMat.Location = new System.Drawing.Point(11, 376);
            this.btnAddMat.Name = "btnAddMat";
            this.btnAddMat.Size = new System.Drawing.Size(206, 37);
            this.btnAddMat.TabIndex = 9;
            this.btnAddMat.Text = "Ajouter une matière";
            this.btnAddMat.UseVisualStyleBackColor = true;
            // 
            // btnListMat
            // 
            this.btnListMat.Location = new System.Drawing.Point(223, 376);
            this.btnListMat.Name = "btnListMat";
            this.btnListMat.Size = new System.Drawing.Size(167, 37);
            this.btnListMat.TabIndex = 10;
            this.btnListMat.Text = "Liste matières";
            this.btnListMat.UseVisualStyleBackColor = true;
            // 
            // CoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CoursForm";
            this.Text = "Gestion des cours";
            this.Load += new System.EventHandler(this.CoursForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCours)).EndInit();
            this.ResumeLayout(false);
=======
            this.dataGridViewCours.Size = new System.Drawing.Size(581, 547);
            this.dataGridViewCours.TabIndex = 0;
            this.dataGridViewCours.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCours_RowHeaderMouseDoubleClick);
>>>>>>> Stashed changes
            // 
            // CoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMatiere);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNomCours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
=======
            this.ClientSize = new System.Drawing.Size(1057, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
            this.Name = "CoursForm";
            this.Text = "CoursForm";
            this.Load += new System.EventHandler(this.CoursForm_Load);
<<<<<<< Updated upstream
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
=======
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCours)).EndInit();
>>>>>>> Stashed changes
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> e723c0f18207e7896ffd1d18551a1c83d0fe6cb6

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewCours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomCours;
        private System.Windows.Forms.Button btnListMat;
        private System.Windows.Forms.Button btnAddMat;
        private System.Windows.Forms.Button btnListeClasse;
        private System.Windows.Forms.Button btnAtribCoursClasse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
=======
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomCours;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cmbMatiere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
>>>>>>> e723c0f18207e7896ffd1d18551a1c83d0fe6cb6
    }
}