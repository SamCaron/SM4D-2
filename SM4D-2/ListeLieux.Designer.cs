namespace SM4D_2
{
    partial class ListeLieux
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeLieux));
            buttonDernierePage = new Button();
            buttonPrecedent = new Button();
            buttonSuivant = new Button();
            buttonDebut = new Button();
            labelNombreLieux = new Label();
            buttonVisionner = new Button();
            labelListeLieux = new Label();
            buttonSupprimer = new Button();
            buttonModifier = new Button();
            buttonAjouter = new Button();
            toolTip1 = new ToolTip(components);
            dataGridViewLieux = new DataGridView();
            lieuxBindingSource = new BindingSource(components);
            buttonFiltrer = new Button();
            linkLabelQuitter = new LinkLabel();
            photoLieuDataGridViewTextBoxColumn = new DataGridViewImageColumn();
            noCiviqueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CodeRue = new DataGridViewTextBoxColumn();
            CodeSecteur = new DataGridViewTextBoxColumn();
            indicateurRecherchesDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AnneeConstruction = new DataGridViewTextBoxColumn();
            Longitude = new DataGridViewTextBoxColumn();
            Latitude = new DataGridViewTextBoxColumn();
            dateHeureCreationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLieux).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lieuxBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonDernierePage
            // 
            buttonDernierePage.Image = (Image)resources.GetObject("buttonDernierePage.Image");
            buttonDernierePage.Location = new Point(475, 11);
            buttonDernierePage.Name = "buttonDernierePage";
            buttonDernierePage.Size = new Size(41, 31);
            buttonDernierePage.TabIndex = 29;
            toolTip1.SetToolTip(buttonDernierePage, "Dernière page");
            buttonDernierePage.UseVisualStyleBackColor = true;
            buttonDernierePage.Click += buttonDernierePage_Click;
            // 
            // buttonPrecedent
            // 
            buttonPrecedent.Image = (Image)resources.GetObject("buttonPrecedent.Image");
            buttonPrecedent.Location = new Point(424, 11);
            buttonPrecedent.Name = "buttonPrecedent";
            buttonPrecedent.Size = new Size(41, 31);
            buttonPrecedent.TabIndex = 28;
            toolTip1.SetToolTip(buttonPrecedent, "Page précédente");
            buttonPrecedent.UseVisualStyleBackColor = true;
            buttonPrecedent.Click += buttonPrecedent_Click;
            // 
            // buttonSuivant
            // 
            buttonSuivant.Image = (Image)resources.GetObject("buttonSuivant.Image");
            buttonSuivant.Location = new Point(376, 11);
            buttonSuivant.Name = "buttonSuivant";
            buttonSuivant.Size = new Size(41, 31);
            buttonSuivant.TabIndex = 27;
            toolTip1.SetToolTip(buttonSuivant, "Page suivante");
            buttonSuivant.UseVisualStyleBackColor = true;
            buttonSuivant.Click += buttonSuivant_Click;
            // 
            // buttonDebut
            // 
            buttonDebut.AccessibleName = "Première Page";
            buttonDebut.Image = Properties.Resources.Pagination_Premier;
            buttonDebut.Location = new Point(329, 11);
            buttonDebut.Name = "buttonDebut";
            buttonDebut.Size = new Size(41, 31);
            buttonDebut.TabIndex = 26;
            toolTip1.SetToolTip(buttonDebut, "Première page");
            buttonDebut.UseVisualStyleBackColor = true;
            buttonDebut.Click += buttonDebut_Click;
            // 
            // labelNombreLieux
            // 
            labelNombreLieux.AutoSize = true;
            labelNombreLieux.Location = new Point(176, 24);
            labelNombreLieux.Name = "labelNombreLieux";
            labelNombreLieux.Size = new Size(108, 15);
            labelNombreLieux.TabIndex = 25;
            labelNombreLieux.Text = "Page <n> de <nn>";
            // 
            // buttonVisionner
            // 
            buttonVisionner.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVisionner.Location = new Point(951, 115);
            buttonVisionner.Name = "buttonVisionner";
            buttonVisionner.Size = new Size(147, 63);
            buttonVisionner.TabIndex = 23;
            buttonVisionner.Text = "Visionner la liste";
            buttonVisionner.UseVisualStyleBackColor = true;
            // 
            // labelListeLieux
            // 
            labelListeLieux.AutoSize = true;
            labelListeLieux.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelListeLieux.Location = new Point(12, 17);
            labelListeLieux.Margin = new Padding(4, 0, 4, 0);
            labelListeLieux.Name = "labelListeLieux";
            labelListeLieux.Size = new Size(140, 25);
            labelListeLieux.TabIndex = 22;
            labelListeLieux.Text = "Liste des Lieux";
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimer.Location = new Point(951, 498);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(147, 46);
            buttonSupprimer.TabIndex = 21;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifier.Location = new Point(951, 425);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(147, 46);
            buttonModifier.TabIndex = 20;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouter.Location = new Point(951, 355);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(147, 46);
            buttonAjouter.TabIndex = 18;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // dataGridViewLieux
            // 
            dataGridViewLieux.AutoGenerateColumns = false;
            dataGridViewLieux.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLieux.Columns.AddRange(new DataGridViewColumn[] { photoLieuDataGridViewTextBoxColumn, noCiviqueDataGridViewTextBoxColumn, CodeRue, CodeSecteur, indicateurRecherchesDataGridViewCheckBoxColumn, idDataGridViewTextBoxColumn, AnneeConstruction, Longitude, Latitude, dateHeureCreationDataGridViewTextBoxColumn });
            dataGridViewLieux.DataSource = lieuxBindingSource;
            dataGridViewLieux.Location = new Point(23, 50);
            dataGridViewLieux.Name = "dataGridViewLieux";
            dataGridViewLieux.RowTemplate.Height = 50;
            dataGridViewLieux.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLieux.Size = new Size(922, 503);
            dataGridViewLieux.TabIndex = 30;
            dataGridViewLieux.MultiSelectChanged += dataGridViewLieux_MultiSelectChanged;
            dataGridViewLieux.CellContentClick += dataGridViewLieux_CellContentClick;
            dataGridViewLieux.SelectionChanged += dataGridViewLieux_SelectionChanged;
            // 
            // lieuxBindingSource
            // 
            lieuxBindingSource.DataSource = typeof(SM4D2Librairie.Modeles.Lieux);
            // 
            // buttonFiltrer
            // 
            buttonFiltrer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFiltrer.Location = new Point(951, 202);
            buttonFiltrer.Name = "buttonFiltrer";
            buttonFiltrer.Size = new Size(147, 46);
            buttonFiltrer.TabIndex = 31;
            buttonFiltrer.Text = "Filtres";
            buttonFiltrer.UseVisualStyleBackColor = true;
            buttonFiltrer.Click += buttonFiltrer_Click;
            // 
            // linkLabelQuitter
            // 
            linkLabelQuitter.AutoSize = true;
            linkLabelQuitter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelQuitter.Location = new Point(1039, 9);
            linkLabelQuitter.Name = "linkLabelQuitter";
            linkLabelQuitter.Size = new Size(58, 25);
            linkLabelQuitter.TabIndex = 32;
            linkLabelQuitter.TabStop = true;
            linkLabelQuitter.Text = "Sortir";
            linkLabelQuitter.LinkClicked += linkLabelQuitter_LinkClicked;
            // 
            // photoLieuDataGridViewTextBoxColumn
            // 
            photoLieuDataGridViewTextBoxColumn.DataPropertyName = "Miniature50";
            photoLieuDataGridViewTextBoxColumn.HeaderText = "Profil";
            photoLieuDataGridViewTextBoxColumn.Name = "photoLieuDataGridViewTextBoxColumn";
            photoLieuDataGridViewTextBoxColumn.ReadOnly = true;
            photoLieuDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            photoLieuDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            photoLieuDataGridViewTextBoxColumn.Width = 50;
            // 
            // noCiviqueDataGridViewTextBoxColumn
            // 
            noCiviqueDataGridViewTextBoxColumn.DataPropertyName = "NoCivique";
            noCiviqueDataGridViewTextBoxColumn.HeaderText = "No Civ.";
            noCiviqueDataGridViewTextBoxColumn.Name = "noCiviqueDataGridViewTextBoxColumn";
            noCiviqueDataGridViewTextBoxColumn.Width = 70;
            // 
            // CodeRue
            // 
            CodeRue.DataPropertyName = "Rue";
            CodeRue.HeaderText = "Rue";
            CodeRue.Name = "CodeRue";
            CodeRue.ReadOnly = true;
            CodeRue.Width = 160;
            // 
            // CodeSecteur
            // 
            CodeSecteur.DataPropertyName = "Secteur";
            CodeSecteur.HeaderText = "Secteur";
            CodeSecteur.Name = "CodeSecteur";
            CodeSecteur.ReadOnly = true;
            CodeSecteur.Width = 160;
            // 
            // indicateurRecherchesDataGridViewCheckBoxColumn
            // 
            indicateurRecherchesDataGridViewCheckBoxColumn.DataPropertyName = "indicateurRecherches";
            indicateurRecherchesDataGridViewCheckBoxColumn.HeaderText = "Rech?";
            indicateurRecherchesDataGridViewCheckBoxColumn.Name = "indicateurRecherchesDataGridViewCheckBoxColumn";
            indicateurRecherchesDataGridViewCheckBoxColumn.Width = 50;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 40;
            // 
            // AnneeConstruction
            // 
            AnneeConstruction.DataPropertyName = "AnneeConstruction";
            AnneeConstruction.HeaderText = "Constr.";
            AnneeConstruction.Name = "AnneeConstruction";
            // 
            // Longitude
            // 
            Longitude.DataPropertyName = "Longitude";
            Longitude.HeaderText = "Long.";
            Longitude.Name = "Longitude";
            Longitude.Width = 75;
            // 
            // Latitude
            // 
            Latitude.DataPropertyName = "Latitude";
            Latitude.HeaderText = "Lat.";
            Latitude.Name = "Latitude";
            Latitude.Width = 75;
            // 
            // dateHeureCreationDataGridViewTextBoxColumn
            // 
            dateHeureCreationDataGridViewTextBoxColumn.DataPropertyName = "DateHeureCreation";
            dateHeureCreationDataGridViewTextBoxColumn.HeaderText = "Création";
            dateHeureCreationDataGridViewTextBoxColumn.Name = "dateHeureCreationDataGridViewTextBoxColumn";
            // 
            // ListeLieux
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 565);
            Controls.Add(linkLabelQuitter);
            Controls.Add(buttonFiltrer);
            Controls.Add(dataGridViewLieux);
            Controls.Add(buttonDernierePage);
            Controls.Add(buttonPrecedent);
            Controls.Add(buttonSuivant);
            Controls.Add(buttonDebut);
            Controls.Add(labelNombreLieux);
            Controls.Add(buttonVisionner);
            Controls.Add(labelListeLieux);
            Controls.Add(buttonSupprimer);
            Controls.Add(buttonModifier);
            Controls.Add(buttonAjouter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListeLieux";
            Text = "Liste des Lieux";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLieux).EndInit();
            ((System.ComponentModel.ISupportInitialize)lieuxBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDernierePage;
        private Button buttonPrecedent;
        private Button buttonSuivant;
        private Button buttonDebut;
        private Label labelNombreLieux;
        private Button buttonVisionner;
        private Label labelListeLieux;
        private Button buttonSupprimer;
        private Button buttonModifier;
        private Button buttonAjouter;
        private ToolTip toolTip1;
        private DataGridView dataGridViewLieux;
        private BindingSource lieuxBindingSource;
        private DataGridViewTextBoxColumn codeSecteurDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeRueDataGridViewTextBoxColumn;
        private Button buttonFiltrer;
        private LinkLabel linkLabelQuitter;
        private DataGridViewImageColumn photoLieuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noCiviqueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CodeRue;
        private DataGridViewTextBoxColumn CodeSecteur;
        private DataGridViewCheckBoxColumn indicateurRecherchesDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AnneeConstruction;
        private DataGridViewTextBoxColumn Longitude;
        private DataGridViewTextBoxColumn Latitude;
        private DataGridViewTextBoxColumn dateHeureCreationDataGridViewTextBoxColumn;
    }
}