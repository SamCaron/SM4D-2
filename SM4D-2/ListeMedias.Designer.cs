namespace SM4D_2
{
    partial class ListeMedias
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeMedias));
            dataGridViewMedias = new DataGridView();
            miniatureDataGridViewImageColumn = new DataGridViewImageColumn();
            Nom = new DataGridViewTextBoxColumn();
            CollectionSig = new DataGridViewTextBoxColumn();
            nomFichierSM4DDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datePriseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeFichierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            indicateurRecherchesDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            SiteSig = new DataGridViewTextBoxColumn();
            mediasBindingSource = new BindingSource(components);
            labelListeMedias = new Label();
            buttonVisionner = new Button();
            buttonFiltrer = new Button();
            labelNombreMedias = new Label();
            buttonDebut = new Button();
            buttonSuivant = new Button();
            buttonPrecedent = new Button();
            buttonDernierePage = new Button();
            toolTip1 = new ToolTip(components);
            linkLabelQuitter = new LinkLabel();
            buttonSupprimer = new Button();
            buttonAjouter = new Button();
            buttonModifier = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mediasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMedias
            // 
            dataGridViewMedias.AllowUserToOrderColumns = true;
            dataGridViewMedias.AutoGenerateColumns = false;
            dataGridViewMedias.BackgroundColor = Color.Gainsboro;
            dataGridViewMedias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedias.Columns.AddRange(new DataGridViewColumn[] { miniatureDataGridViewImageColumn, Nom, CollectionSig, nomFichierSM4DDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, datePriseDataGridViewTextBoxColumn, typeFichierDataGridViewTextBoxColumn, indicateurRecherchesDataGridViewCheckBoxColumn, SiteSig });
            dataGridViewMedias.DataSource = mediasBindingSource;
            dataGridViewMedias.Location = new Point(13, 42);
            dataGridViewMedias.Name = "dataGridViewMedias";
            dataGridViewMedias.ReadOnly = true;
            dataGridViewMedias.RowTemplate.Height = 50;
            dataGridViewMedias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMedias.Size = new Size(921, 509);
            dataGridViewMedias.TabIndex = 0;
            dataGridViewMedias.MultiSelectChanged += dataGridViewMedias_MultiSelectChanged;
            dataGridViewMedias.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewMedias.SelectionChanged += dataGridViewMedias_SelectionChanged;
            // 
            // miniatureDataGridViewImageColumn
            // 
            miniatureDataGridViewImageColumn.DataPropertyName = "Miniature";
            miniatureDataGridViewImageColumn.HeaderText = "";
            miniatureDataGridViewImageColumn.Name = "miniatureDataGridViewImageColumn";
            miniatureDataGridViewImageColumn.ReadOnly = true;
            miniatureDataGridViewImageColumn.Width = 50;
            // 
            // Nom
            // 
            Nom.DataPropertyName = "Nom";
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            Nom.Width = 175;
            // 
            // CollectionSig
            // 
            CollectionSig.DataPropertyName = "CollectionSig";
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CollectionSig.DefaultCellStyle = dataGridViewCellStyle1;
            CollectionSig.HeaderText = "Collection";
            CollectionSig.Name = "CollectionSig";
            CollectionSig.ReadOnly = true;
            CollectionSig.Width = 125;
            // 
            // nomFichierSM4DDataGridViewTextBoxColumn
            // 
            nomFichierSM4DDataGridViewTextBoxColumn.DataPropertyName = "NomFichierSM4D";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            nomFichierSM4DDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            nomFichierSM4DDataGridViewTextBoxColumn.HeaderText = "Nom du Fichier";
            nomFichierSM4DDataGridViewTextBoxColumn.Name = "nomFichierSM4DDataGridViewTextBoxColumn";
            nomFichierSM4DDataGridViewTextBoxColumn.ReadOnly = true;
            nomFichierSM4DDataGridViewTextBoxColumn.Width = 175;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 40;
            // 
            // datePriseDataGridViewTextBoxColumn
            // 
            datePriseDataGridViewTextBoxColumn.DataPropertyName = "DatePrise";
            datePriseDataGridViewTextBoxColumn.HeaderText = "Date Prise";
            datePriseDataGridViewTextBoxColumn.Name = "datePriseDataGridViewTextBoxColumn";
            datePriseDataGridViewTextBoxColumn.ReadOnly = true;
            datePriseDataGridViewTextBoxColumn.Width = 75;
            // 
            // typeFichierDataGridViewTextBoxColumn
            // 
            typeFichierDataGridViewTextBoxColumn.DataPropertyName = "TypeFichier";
            typeFichierDataGridViewTextBoxColumn.HeaderText = "Type";
            typeFichierDataGridViewTextBoxColumn.Name = "typeFichierDataGridViewTextBoxColumn";
            typeFichierDataGridViewTextBoxColumn.ReadOnly = true;
            typeFichierDataGridViewTextBoxColumn.Width = 40;
            // 
            // indicateurRecherchesDataGridViewCheckBoxColumn
            // 
            indicateurRecherchesDataGridViewCheckBoxColumn.DataPropertyName = "IndicateurRecherches";
            indicateurRecherchesDataGridViewCheckBoxColumn.HeaderText = "Rech?";
            indicateurRecherchesDataGridViewCheckBoxColumn.Name = "indicateurRecherchesDataGridViewCheckBoxColumn";
            indicateurRecherchesDataGridViewCheckBoxColumn.ReadOnly = true;
            indicateurRecherchesDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            indicateurRecherchesDataGridViewCheckBoxColumn.Width = 40;
            // 
            // SiteSig
            // 
            SiteSig.DataPropertyName = "SiteSig";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SiteSig.DefaultCellStyle = dataGridViewCellStyle3;
            SiteSig.HeaderText = "Site";
            SiteSig.Name = "SiteSig";
            SiteSig.ReadOnly = true;
            SiteSig.Width = 160;
            // 
            // mediasBindingSource
            // 
            mediasBindingSource.DataSource = typeof(SM4D2Librairie.Modeles.Medias);
            // 
            // labelListeMedias
            // 
            labelListeMedias.AutoSize = true;
            labelListeMedias.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelListeMedias.Location = new Point(13, 9);
            labelListeMedias.Margin = new Padding(4, 0, 4, 0);
            labelListeMedias.Name = "labelListeMedias";
            labelListeMedias.Size = new Size(152, 25);
            labelListeMedias.TabIndex = 9;
            labelListeMedias.Text = "Liste de Médias ";
            // 
            // buttonVisionner
            // 
            buttonVisionner.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVisionner.Location = new Point(952, 107);
            buttonVisionner.Name = "buttonVisionner";
            buttonVisionner.Size = new Size(147, 63);
            buttonVisionner.TabIndex = 10;
            buttonVisionner.Text = "Visionner la liste";
            buttonVisionner.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrer
            // 
            buttonFiltrer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFiltrer.Location = new Point(952, 186);
            buttonFiltrer.Name = "buttonFiltrer";
            buttonFiltrer.Size = new Size(147, 46);
            buttonFiltrer.TabIndex = 11;
            buttonFiltrer.Text = "Filtres";
            buttonFiltrer.UseVisualStyleBackColor = true;
            buttonFiltrer.Click += buttonFiltrer_Click;
            // 
            // labelNombreMedias
            // 
            labelNombreMedias.AutoSize = true;
            labelNombreMedias.Location = new Point(177, 16);
            labelNombreMedias.Name = "labelNombreMedias";
            labelNombreMedias.Size = new Size(108, 15);
            labelNombreMedias.TabIndex = 12;
            labelNombreMedias.Text = "Page <n> de <nn>";
            // 
            // buttonDebut
            // 
            buttonDebut.AccessibleName = "Première Page";
            buttonDebut.Image = Properties.Resources.Pagination_Premier;
            buttonDebut.Location = new Point(330, 3);
            buttonDebut.Name = "buttonDebut";
            buttonDebut.Size = new Size(41, 31);
            buttonDebut.TabIndex = 13;
            toolTip1.SetToolTip(buttonDebut, "Première page");
            buttonDebut.UseVisualStyleBackColor = true;
            buttonDebut.Click += buttonDebut_Click;
            // 
            // buttonSuivant
            // 
            buttonSuivant.Image = (Image)resources.GetObject("buttonSuivant.Image");
            buttonSuivant.Location = new Point(377, 3);
            buttonSuivant.Name = "buttonSuivant";
            buttonSuivant.Size = new Size(41, 31);
            buttonSuivant.TabIndex = 14;
            toolTip1.SetToolTip(buttonSuivant, "Page suivante");
            buttonSuivant.UseVisualStyleBackColor = true;
            buttonSuivant.Click += buttonSuivant_Click;
            // 
            // buttonPrecedent
            // 
            buttonPrecedent.Image = (Image)resources.GetObject("buttonPrecedent.Image");
            buttonPrecedent.Location = new Point(425, 3);
            buttonPrecedent.Name = "buttonPrecedent";
            buttonPrecedent.Size = new Size(41, 31);
            buttonPrecedent.TabIndex = 15;
            toolTip1.SetToolTip(buttonPrecedent, "Page précédente");
            buttonPrecedent.UseVisualStyleBackColor = true;
            buttonPrecedent.Click += buttonPrecedent_Click;
            // 
            // buttonDernierePage
            // 
            buttonDernierePage.Image = (Image)resources.GetObject("buttonDernierePage.Image");
            buttonDernierePage.Location = new Point(476, 3);
            buttonDernierePage.Name = "buttonDernierePage";
            buttonDernierePage.Size = new Size(41, 31);
            buttonDernierePage.TabIndex = 16;
            toolTip1.SetToolTip(buttonDernierePage, "Dernière page");
            buttonDernierePage.UseVisualStyleBackColor = true;
            buttonDernierePage.Click += buttonDernierePage_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // linkLabelQuitter
            // 
            linkLabelQuitter.AutoSize = true;
            linkLabelQuitter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelQuitter.Location = new Point(1028, 3);
            linkLabelQuitter.Name = "linkLabelQuitter";
            linkLabelQuitter.Size = new Size(58, 25);
            linkLabelQuitter.TabIndex = 17;
            linkLabelQuitter.TabStop = true;
            linkLabelQuitter.Text = "Sortir";
            linkLabelQuitter.LinkClicked += linkLabelQuitter_LinkClicked;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimer.Location = new Point(952, 490);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(147, 46);
            buttonSupprimer.TabIndex = 8;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouter.Location = new Point(952, 347);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(147, 46);
            buttonAjouter.TabIndex = 5;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifier.Location = new Point(952, 417);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(147, 46);
            buttonModifier.TabIndex = 7;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // ListeMedias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 596);
            Controls.Add(linkLabelQuitter);
            Controls.Add(buttonDernierePage);
            Controls.Add(buttonPrecedent);
            Controls.Add(buttonSuivant);
            Controls.Add(buttonDebut);
            Controls.Add(labelNombreMedias);
            Controls.Add(buttonFiltrer);
            Controls.Add(buttonVisionner);
            Controls.Add(labelListeMedias);
            Controls.Add(buttonSupprimer);
            Controls.Add(buttonModifier);
            Controls.Add(buttonAjouter);
            Controls.Add(dataGridViewMedias);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListeMedias";
            Text = "Liste de Medias";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedias).EndInit();
            ((System.ComponentModel.ISupportInitialize)mediasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMedias;
        private BindingSource mediasBindingSource;
        private Label labelListeMedias;
        private Button buttonVisionner;
        private Button buttonFiltrer;
        private Label labelNombreMedias;
        private Button buttonDebut;
        private Button buttonSuivant;
        private Button buttonPrecedent;
        private Button buttonDernierePage;
        private ToolTip toolTip1;
        private LinkLabel linkLabelQuitter;
        private DataGridViewImageColumn miniatureDataGridViewImageColumn;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn CollectionSig;
        private DataGridViewTextBoxColumn nomFichierSM4DDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datePriseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeFichierDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn indicateurRecherchesDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn SiteSig;
        private Button buttonSupprimer;
        private Button buttonAjouter;
        private Button buttonModifier;
    }
}