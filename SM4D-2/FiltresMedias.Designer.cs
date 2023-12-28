namespace SM4D_2
{
    partial class FiltresMedias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltresMedias));
            labelId = new Label();
            textBoxIdValeur = new TextBox();
            labelCollection = new Label();
            comboBoxCollectionValeur = new ComboBox();
            labelDatePrise = new Label();
            dateTimePickerDe = new DateTimePicker();
            labelEt = new Label();
            dateTimePickerA = new DateTimePicker();
            dateTimePickerDateCreationA = new DateTimePicker();
            label1 = new Label();
            dateTimePickerDateCreationDe = new DateTimePicker();
            labelDateCreation = new Label();
            dateTimePickerDateModificationA = new DateTimePicker();
            label2 = new Label();
            dateTimePickerDateModificationDe = new DateTimePicker();
            labelDateModification = new Label();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            labelIndicateurRecherches = new Label();
            comboBoxIndicateurRecherches = new ComboBox();
            comboBoxEvenement = new ComboBox();
            labelEvenement = new Label();
            buttonSortir = new Button();
            buttonAppliquer = new Button();
            listBoxMessages = new ListBox();
            labelSymboleErreur = new Label();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(31, 72);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 15);
            labelId.TabIndex = 0;
            labelId.Text = "Id";
            // 
            // textBoxIdValeur
            // 
            textBoxIdValeur.Location = new Point(171, 64);
            textBoxIdValeur.Name = "textBoxIdValeur";
            textBoxIdValeur.PlaceholderText = "Tous";
            textBoxIdValeur.Size = new Size(100, 23);
            textBoxIdValeur.TabIndex = 1;
            // 
            // labelCollection
            // 
            labelCollection.AutoSize = true;
            labelCollection.Location = new Point(29, 102);
            labelCollection.Name = "labelCollection";
            labelCollection.Size = new Size(64, 15);
            labelCollection.TabIndex = 2;
            labelCollection.Text = "Collection ";
            // 
            // comboBoxCollectionValeur
            // 
            comboBoxCollectionValeur.FormattingEnabled = true;
            comboBoxCollectionValeur.Location = new Point(170, 94);
            comboBoxCollectionValeur.Name = "comboBoxCollectionValeur";
            comboBoxCollectionValeur.Size = new Size(121, 23);
            comboBoxCollectionValeur.TabIndex = 3;
            comboBoxCollectionValeur.Text = "Toutes";
            comboBoxCollectionValeur.SelectedIndexChanged += comboBoxCollectionValeur_SelectedIndexChanged;
            // 
            // labelDatePrise
            // 
            labelDatePrise.AutoSize = true;
            labelDatePrise.Location = new Point(29, 41);
            labelDatePrise.Name = "labelDatePrise";
            labelDatePrise.Size = new Size(114, 15);
            labelDatePrise.TabIndex = 6;
            labelDatePrise.Text = "Date de prise entre   ";
            // 
            // dateTimePickerDe
            // 
            dateTimePickerDe.Location = new Point(170, 35);
            dateTimePickerDe.Name = "dateTimePickerDe";
            dateTimePickerDe.Size = new Size(139, 23);
            dateTimePickerDe.TabIndex = 7;
            dateTimePickerDe.Value = new DateTime(1800, 1, 1, 0, 0, 0, 0);
            // 
            // labelEt
            // 
            labelEt.AutoSize = true;
            labelEt.Location = new Point(328, 43);
            labelEt.Name = "labelEt";
            labelEt.Size = new Size(17, 15);
            labelEt.TabIndex = 8;
            labelEt.Text = "et";
            // 
            // dateTimePickerA
            // 
            dateTimePickerA.Location = new Point(363, 35);
            dateTimePickerA.Name = "dateTimePickerA";
            dateTimePickerA.Size = new Size(139, 23);
            dateTimePickerA.TabIndex = 9;
            dateTimePickerA.Value = new DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // dateTimePickerDateCreationA
            // 
            dateTimePickerDateCreationA.Location = new Point(363, 199);
            dateTimePickerDateCreationA.Name = "dateTimePickerDateCreationA";
            dateTimePickerDateCreationA.Size = new Size(139, 23);
            dateTimePickerDateCreationA.TabIndex = 13;
            dateTimePickerDateCreationA.Value = new DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 207);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 12;
            label1.Text = "et";
            // 
            // dateTimePickerDateCreationDe
            // 
            dateTimePickerDateCreationDe.Location = new Point(170, 199);
            dateTimePickerDateCreationDe.Name = "dateTimePickerDateCreationDe";
            dateTimePickerDateCreationDe.Size = new Size(139, 23);
            dateTimePickerDateCreationDe.TabIndex = 11;
            dateTimePickerDateCreationDe.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // labelDateCreation
            // 
            labelDateCreation.AutoSize = true;
            labelDateCreation.Location = new Point(28, 207);
            labelDateCreation.Name = "labelDateCreation";
            labelDateCreation.Size = new Size(132, 15);
            labelDateCreation.TabIndex = 10;
            labelDateCreation.Text = "Date de création entre   ";
            // 
            // dateTimePickerDateModificationA
            // 
            dateTimePickerDateModificationA.Location = new Point(363, 241);
            dateTimePickerDateModificationA.Name = "dateTimePickerDateModificationA";
            dateTimePickerDateModificationA.Size = new Size(139, 23);
            dateTimePickerDateModificationA.TabIndex = 17;
            dateTimePickerDateModificationA.Value = new DateTime(2023, 3, 2, 0, 0, 0, 0);
            dateTimePickerDateModificationA.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 249);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 16;
            label2.Text = "et";
            label2.Click += label2_Click;
            // 
            // dateTimePickerDateModificationDe
            // 
            dateTimePickerDateModificationDe.Location = new Point(170, 241);
            dateTimePickerDateModificationDe.Name = "dateTimePickerDateModificationDe";
            dateTimePickerDateModificationDe.Size = new Size(139, 23);
            dateTimePickerDateModificationDe.TabIndex = 15;
            dateTimePickerDateModificationDe.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePickerDateModificationDe.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // labelDateModification
            // 
            labelDateModification.AutoSize = true;
            labelDateModification.Location = new Point(28, 249);
            labelDateModification.Name = "labelDateModification";
            labelDateModification.Size = new Size(127, 15);
            labelDateModification.TabIndex = 14;
            labelDateModification.Text = "Date de modif.  entre   ";
            labelDateModification.Click += label3_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(208, 6);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "<texte>";
            textBoxDescription.Size = new Size(296, 23);
            textBoxDescription.TabIndex = 19;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(29, 11);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(167, 15);
            labelDescription.TabIndex = 18;
            labelDescription.Text = "Nom/Descriptions contenant  ";
            // 
            // labelIndicateurRecherches
            // 
            labelIndicateurRecherches.AutoSize = true;
            labelIndicateurRecherches.Location = new Point(31, 160);
            labelIndicateurRecherches.Name = "labelIndicateurRecherches";
            labelIndicateurRecherches.Size = new Size(115, 15);
            labelIndicateurRecherches.TabIndex = 20;
            labelIndicateurRecherches.Text = "Indicateur d'analyse ";
            // 
            // comboBoxIndicateurRecherches
            // 
            comboBoxIndicateurRecherches.FormattingEnabled = true;
            comboBoxIndicateurRecherches.Location = new Point(170, 157);
            comboBoxIndicateurRecherches.Name = "comboBoxIndicateurRecherches";
            comboBoxIndicateurRecherches.Size = new Size(121, 23);
            comboBoxIndicateurRecherches.TabIndex = 21;
            comboBoxIndicateurRecherches.Text = "Tout";
            // 
            // comboBoxEvenement
            // 
            comboBoxEvenement.FormattingEnabled = true;
            comboBoxEvenement.Location = new Point(170, 123);
            comboBoxEvenement.Name = "comboBoxEvenement";
            comboBoxEvenement.Size = new Size(121, 23);
            comboBoxEvenement.TabIndex = 25;
            comboBoxEvenement.Text = "Tous";
            // 
            // labelEvenement
            // 
            labelEvenement.AutoSize = true;
            labelEvenement.Location = new Point(30, 131);
            labelEvenement.Name = "labelEvenement";
            labelEvenement.Size = new Size(110, 15);
            labelEvenement.TabIndex = 24;
            labelEvenement.Text = "Événement associé ";
            // 
            // buttonSortir
            // 
            buttonSortir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSortir.Location = new Point(302, 349);
            buttonSortir.Name = "buttonSortir";
            buttonSortir.Size = new Size(218, 46);
            buttonSortir.TabIndex = 27;
            buttonSortir.Text = "Annuler et Sortir";
            buttonSortir.UseVisualStyleBackColor = true;
            buttonSortir.Click += buttonSortir_Click;
            // 
            // buttonAppliquer
            // 
            buttonAppliquer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAppliquer.Location = new Point(12, 349);
            buttonAppliquer.Name = "buttonAppliquer";
            buttonAppliquer.Size = new Size(259, 46);
            buttonAppliquer.TabIndex = 26;
            buttonAppliquer.Text = "Enregistrer et appliquer";
            buttonAppliquer.UseVisualStyleBackColor = true;
            buttonAppliquer.Click += buttonAppliquer_Click;
            // 
            // listBoxMessages
            // 
            listBoxMessages.BackColor = SystemColors.Control;
            listBoxMessages.BorderStyle = BorderStyle.None;
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.ItemHeight = 15;
            listBoxMessages.Location = new Point(67, 283);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(475, 60);
            listBoxMessages.TabIndex = 30;
            // 
            // labelSymboleErreur
            // 
            labelSymboleErreur.AutoSize = true;
            labelSymboleErreur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSymboleErreur.ForeColor = Color.Red;
            labelSymboleErreur.Location = new Point(30, 283);
            labelSymboleErreur.Name = "labelSymboleErreur";
            labelSymboleErreur.Size = new Size(18, 21);
            labelSymboleErreur.TabIndex = 31;
            labelSymboleErreur.Text = "  ";
            // 
            // FiltresMedias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 412);
            Controls.Add(labelSymboleErreur);
            Controls.Add(listBoxMessages);
            Controls.Add(buttonSortir);
            Controls.Add(buttonAppliquer);
            Controls.Add(comboBoxEvenement);
            Controls.Add(labelEvenement);
            Controls.Add(comboBoxIndicateurRecherches);
            Controls.Add(labelIndicateurRecherches);
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(dateTimePickerDateModificationA);
            Controls.Add(label2);
            Controls.Add(dateTimePickerDateModificationDe);
            Controls.Add(labelDateModification);
            Controls.Add(dateTimePickerDateCreationA);
            Controls.Add(label1);
            Controls.Add(dateTimePickerDateCreationDe);
            Controls.Add(labelDateCreation);
            Controls.Add(dateTimePickerA);
            Controls.Add(labelEt);
            Controls.Add(dateTimePickerDe);
            Controls.Add(labelDatePrise);
            Controls.Add(comboBoxCollectionValeur);
            Controls.Add(labelCollection);
            Controls.Add(textBoxIdValeur);
            Controls.Add(labelId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FiltresMedias";
            Text = "Filtres pour liste de Medias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private TextBox textBoxIdValeur;
        private Label labelCollection;
        private ComboBox comboBoxCollectionValeur;
        private Label labelDatePrise;
        private DateTimePicker dateTimePickerDe;
        private Label labelEt;
        private DateTimePicker dateTimePickerA;
        private DateTimePicker dateTimePickerDateCreationA;
        private Label label1;
        private DateTimePicker dateTimePickerDateCreationDe;
        private Label labelDateCreation;
        private DateTimePicker dateTimePickerDateModificationA;
        private Label label2;
        private DateTimePicker dateTimePickerDateModificationDe;
        private Label labelDateModification;
        private TextBox textBoxDescription;
        private Label labelDescription;
        private Label labelIndicateurRecherches;
        private ComboBox comboBoxIndicateurRecherches;
        private ComboBox comboBoxEvenement;
        private Label labelEvenement;
        private Button buttonSortir;
        private Button buttonAppliquer;
        private ListBox listBoxMessages;
        private Label labelSymboleErreur;
    }
}