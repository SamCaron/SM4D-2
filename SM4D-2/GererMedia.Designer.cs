namespace SM4D_2
{
    partial class GererMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GererMedia));
            labelGererMedia = new Label();
            labelDateModification = new Label();
            labelDateCreation = new Label();
            pictureBoxMiniature128 = new PictureBox();
            labelNomFichierSM4DValeur = new Label();
            groupBoxDatePrise = new GroupBox();
            label4 = new Label();
            labelEvenementPrise = new Label();
            label3 = new Label();
            buttonSelectionLieuPrise = new Button();
            buttonSelectionEvenement = new Button();
            labelLieuPrise = new Label();
            label2 = new Label();
            labelA = new Label();
            labelPres = new Label();
            dateTimePickerDatePrise = new DateTimePicker();
            textBoxNombreAnsValeur = new TextBox();
            labelParModificationValeur = new Label();
            labelParCreationValeur = new Label();
            textBoxDescriptionRecherches = new TextBox();
            checkBoxAnalyseRequise = new CheckBox();
            labelAjouteLe = new Label();
            buttonChoisirFichier = new Button();
            label1 = new Label();
            labelId = new Label();
            labelIdValeur = new Label();
            labelCollection = new Label();
            labelTypeFichierValeur = new Label();
            comboBoxCollection = new ComboBox();
            labelTypeMediaValeur = new Label();
            labelTypeMedia = new Label();
            groupBoxSujets = new GroupBox();
            listBoxSujets = new ListBox();
            buttonRetraitSujet = new Button();
            buttonAjoutSujet = new Button();
            groupBoxPresences = new GroupBox();
            listBoxPresences = new ListBox();
            buttonRetraitPresence = new Button();
            buttonAjoutPresence = new Button();
            textBoxDescriptionMedia = new TextBox();
            buttonAjouterRester = new Button();
            buttonEnregistrer = new Button();
            buttonAjouterSortir = new Button();
            listBoxMessages = new ListBox();
            labelSymboleErreur = new Label();
            labelFichierOriginalValeur = new Label();
            labelNomMedia = new Label();
            textBoxNomMedia = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiniature128).BeginInit();
            groupBoxDatePrise.SuspendLayout();
            groupBoxSujets.SuspendLayout();
            groupBoxPresences.SuspendLayout();
            SuspendLayout();
            // 
            // labelGererMedia
            // 
            labelGererMedia.AutoSize = true;
            labelGererMedia.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelGererMedia.Location = new Point(13, 9);
            labelGererMedia.Margin = new Padding(4, 0, 4, 0);
            labelGererMedia.Name = "labelGererMedia";
            labelGererMedia.Size = new Size(156, 25);
            labelGererMedia.TabIndex = 5;
            labelGererMedia.Text = "Gérer un Média ";
            labelGererMedia.Click += labelNombreMedias_Click;
            // 
            // labelDateModification
            // 
            labelDateModification.AutoSize = true;
            labelDateModification.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateModification.Location = new Point(698, 446);
            labelDateModification.Margin = new Padding(4, 0, 4, 0);
            labelDateModification.Name = "labelDateModification";
            labelDateModification.Size = new Size(95, 19);
            labelDateModification.TabIndex = 26;
            labelDateModification.Text = "<date modif>";
            // 
            // labelDateCreation
            // 
            labelDateCreation.AutoSize = true;
            labelDateCreation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateCreation.Location = new Point(698, 417);
            labelDateCreation.Margin = new Padding(4, 0, 4, 0);
            labelDateCreation.Name = "labelDateCreation";
            labelDateCreation.Size = new Size(109, 19);
            labelDateCreation.TabIndex = 25;
            labelDateCreation.Text = "<date création>";
            // 
            // pictureBoxMiniature128
            // 
            pictureBoxMiniature128.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMiniature128.Location = new Point(22, 99);
            pictureBoxMiniature128.Name = "pictureBoxMiniature128";
            pictureBoxMiniature128.Size = new Size(128, 128);
            pictureBoxMiniature128.TabIndex = 24;
            pictureBoxMiniature128.TabStop = false;
            // 
            // labelNomFichierSM4DValeur
            // 
            labelNomFichierSM4DValeur.AutoSize = true;
            labelNomFichierSM4DValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomFichierSM4DValeur.Location = new Point(214, 53);
            labelNomFichierSM4DValeur.Margin = new Padding(4, 0, 4, 0);
            labelNomFichierSM4DValeur.Name = "labelNomFichierSM4DValeur";
            labelNomFichierSM4DValeur.Size = new Size(139, 19);
            labelNomFichierSM4DValeur.TabIndex = 23;
            labelNomFichierSM4DValeur.Text = "<nom fichier SM4D>";
            // 
            // groupBoxDatePrise
            // 
            groupBoxDatePrise.Controls.Add(label4);
            groupBoxDatePrise.Controls.Add(labelEvenementPrise);
            groupBoxDatePrise.Controls.Add(label3);
            groupBoxDatePrise.Controls.Add(buttonSelectionLieuPrise);
            groupBoxDatePrise.Controls.Add(buttonSelectionEvenement);
            groupBoxDatePrise.Controls.Add(labelLieuPrise);
            groupBoxDatePrise.Controls.Add(label2);
            groupBoxDatePrise.Controls.Add(labelA);
            groupBoxDatePrise.Controls.Add(labelPres);
            groupBoxDatePrise.Controls.Add(dateTimePickerDatePrise);
            groupBoxDatePrise.Controls.Add(textBoxNombreAnsValeur);
            groupBoxDatePrise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxDatePrise.Location = new Point(168, 100);
            groupBoxDatePrise.Name = "groupBoxDatePrise";
            groupBoxDatePrise.Size = new Size(449, 132);
            groupBoxDatePrise.TabIndex = 22;
            groupBoxDatePrise.TabStop = false;
            groupBoxDatePrise.Text = "Prise";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(4, 100);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 8;
            label4.Text = "Lors de:";
            label4.UseWaitCursor = true;
            // 
            // labelEvenementPrise
            // 
            labelEvenementPrise.AutoSize = true;
            labelEvenementPrise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelEvenementPrise.Location = new Point(58, 100);
            labelEvenementPrise.Margin = new Padding(4, 0, 4, 0);
            labelEvenementPrise.Name = "labelEvenementPrise";
            labelEvenementPrise.Size = new Size(74, 19);
            labelEvenementPrise.TabIndex = 1;
            labelEvenementPrise.Text = "< aucun >";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 70);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 19);
            label3.TabIndex = 7;
            label3.Text = "Où:";
            label3.UseWaitCursor = true;
            // 
            // buttonSelectionLieuPrise
            // 
            buttonSelectionLieuPrise.AccessibleDescription = "";
            buttonSelectionLieuPrise.Cursor = Cursors.Cross;
            buttonSelectionLieuPrise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelectionLieuPrise.Location = new Point(389, 61);
            buttonSelectionLieuPrise.Name = "buttonSelectionLieuPrise";
            buttonSelectionLieuPrise.Size = new Size(52, 28);
            buttonSelectionLieuPrise.TabIndex = 2;
            buttonSelectionLieuPrise.Text = "Lieu";
            buttonSelectionLieuPrise.UseVisualStyleBackColor = true;
            buttonSelectionLieuPrise.Click += buttonSelectionLieuPrise_Click;
            // 
            // buttonSelectionEvenement
            // 
            buttonSelectionEvenement.Cursor = Cursors.Cross;
            buttonSelectionEvenement.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelectionEvenement.Location = new Point(389, 96);
            buttonSelectionEvenement.Name = "buttonSelectionEvenement";
            buttonSelectionEvenement.Size = new Size(54, 29);
            buttonSelectionEvenement.TabIndex = 0;
            buttonSelectionEvenement.Text = "Évén.";
            buttonSelectionEvenement.UseVisualStyleBackColor = true;
            buttonSelectionEvenement.Click += buttonChoixEvenement_Click;
            // 
            // labelLieuPrise
            // 
            labelLieuPrise.AutoSize = true;
            labelLieuPrise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelLieuPrise.Location = new Point(34, 70);
            labelLieuPrise.Margin = new Padding(4, 0, 4, 0);
            labelLieuPrise.Name = "labelLieuPrise";
            labelLieuPrise.Size = new Size(74, 19);
            labelLieuPrise.TabIndex = 2;
            labelLieuPrise.Text = "< aucun >";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 19);
            label2.TabIndex = 6;
            label2.Text = "Le";
            label2.UseWaitCursor = true;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelA.Location = new Point(218, 30);
            labelA.Margin = new Padding(4, 0, 4, 0);
            labelA.Name = "labelA";
            labelA.Size = new Size(16, 19);
            labelA.TabIndex = 5;
            labelA.Text = "à";
            labelA.UseWaitCursor = true;
            // 
            // labelPres
            // 
            labelPres.AutoSize = true;
            labelPres.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPres.Location = new Point(302, 33);
            labelPres.Margin = new Padding(4, 0, 4, 0);
            labelPres.Name = "labelPres";
            labelPres.Size = new Size(60, 19);
            labelPres.TabIndex = 3;
            labelPres.Text = "ans près";
            // 
            // dateTimePickerDatePrise
            // 
            dateTimePickerDatePrise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDatePrise.ImeMode = ImeMode.On;
            dateTimePickerDatePrise.Location = new Point(48, 30);
            dateTimePickerDatePrise.Name = "dateTimePickerDatePrise";
            dateTimePickerDatePrise.Size = new Size(153, 25);
            dateTimePickerDatePrise.TabIndex = 4;
            // 
            // textBoxNombreAnsValeur
            // 
            textBoxNombreAnsValeur.Location = new Point(243, 30);
            textBoxNombreAnsValeur.Name = "textBoxNombreAnsValeur";
            textBoxNombreAnsValeur.PlaceholderText = "nb ";
            textBoxNombreAnsValeur.Size = new Size(41, 25);
            textBoxNombreAnsValeur.TabIndex = 2;
            // 
            // labelParModificationValeur
            // 
            labelParModificationValeur.AutoSize = true;
            labelParModificationValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelParModificationValeur.Location = new Point(801, 446);
            labelParModificationValeur.Margin = new Padding(4, 0, 4, 0);
            labelParModificationValeur.Name = "labelParModificationValeur";
            labelParModificationValeur.Size = new Size(136, 19);
            labelParModificationValeur.TabIndex = 21;
            labelParModificationValeur.Text = "< utilisateur modif >";
            // 
            // labelParCreationValeur
            // 
            labelParCreationValeur.AutoSize = true;
            labelParCreationValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelParCreationValeur.Location = new Point(801, 417);
            labelParCreationValeur.Margin = new Padding(4, 0, 4, 0);
            labelParCreationValeur.Name = "labelParCreationValeur";
            labelParCreationValeur.Size = new Size(146, 19);
            labelParCreationValeur.TabIndex = 17;
            labelParCreationValeur.Text = "< utilisateur creation>";
            // 
            // textBoxDescriptionRecherches
            // 
            textBoxDescriptionRecherches.Location = new Point(168, 433);
            textBoxDescriptionRecherches.Multiline = true;
            textBoxDescriptionRecherches.Name = "textBoxDescriptionRecherches";
            textBoxDescriptionRecherches.PlaceholderText = "Identifier les lacunes à analyser";
            textBoxDescriptionRecherches.Size = new Size(441, 33);
            textBoxDescriptionRecherches.TabIndex = 2;
            textBoxDescriptionRecherches.TextChanged += textBox2_TextChanged;
            // 
            // checkBoxAnalyseRequise
            // 
            checkBoxAnalyseRequise.AutoSize = true;
            checkBoxAnalyseRequise.Checked = true;
            checkBoxAnalyseRequise.CheckState = CheckState.Checked;
            checkBoxAnalyseRequise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAnalyseRequise.Location = new Point(30, 439);
            checkBoxAnalyseRequise.Name = "checkBoxAnalyseRequise";
            checkBoxAnalyseRequise.Size = new Size(123, 23);
            checkBoxAnalyseRequise.TabIndex = 1;
            checkBoxAnalyseRequise.Text = "Analyse requise";
            checkBoxAnalyseRequise.UseVisualStyleBackColor = true;
            // 
            // labelAjouteLe
            // 
            labelAjouteLe.AutoSize = true;
            labelAjouteLe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAjouteLe.Location = new Point(619, 417);
            labelAjouteLe.Margin = new Padding(4, 0, 4, 0);
            labelAjouteLe.Name = "labelAjouteLe";
            labelAjouteLe.Size = new Size(74, 19);
            labelAjouteLe.TabIndex = 14;
            labelAjouteLe.Text = "Ajouté le  :";
            labelAjouteLe.Click += label1_Click_5;
            // 
            // buttonChoisirFichier
            // 
            buttonChoisirFichier.Cursor = Cursors.Cross;
            buttonChoisirFichier.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChoisirFichier.Location = new Point(22, 46);
            buttonChoisirFichier.Name = "buttonChoisirFichier";
            buttonChoisirFichier.Size = new Size(82, 47);
            buttonChoisirFichier.TabIndex = 0;
            buttonChoisirFichier.Text = "Choisir Fichier";
            buttonChoisirFichier.UseVisualStyleBackColor = true;
            buttonChoisirFichier.Click += buttonChoisirFichier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(619, 446);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 18;
            label1.Text = "Modifié le  :";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(111, 48);
            labelId.Margin = new Padding(4, 0, 4, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(28, 19);
            labelId.TabIndex = 3;
            labelId.Text = "Id :";
            // 
            // labelIdValeur
            // 
            labelIdValeur.AutoSize = true;
            labelIdValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdValeur.Location = new Point(108, 67);
            labelIdValeur.Margin = new Padding(4, 0, 4, 0);
            labelIdValeur.Name = "labelIdValeur";
            labelIdValeur.Size = new Size(45, 19);
            labelIdValeur.TabIndex = 18;
            labelIdValeur.Text = "<no>";
            // 
            // labelCollection
            // 
            labelCollection.AutoSize = true;
            labelCollection.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCollection.Location = new Point(23, 278);
            labelCollection.Margin = new Padding(4, 0, 4, 0);
            labelCollection.Name = "labelCollection";
            labelCollection.Size = new Size(76, 19);
            labelCollection.TabIndex = 4;
            labelCollection.Text = "Collection :";
            // 
            // labelTypeFichierValeur
            // 
            labelTypeFichierValeur.AutoSize = true;
            labelTypeFichierValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTypeFichierValeur.Location = new Point(410, 77);
            labelTypeFichierValeur.Margin = new Padding(4, 0, 4, 0);
            labelTypeFichierValeur.Name = "labelTypeFichierValeur";
            labelTypeFichierValeur.Size = new Size(115, 19);
            labelTypeFichierValeur.TabIndex = 11;
            labelTypeFichierValeur.Text = "<type de fichier>";
            // 
            // comboBoxCollection
            // 
            comboBoxCollection.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCollection.FormattingEnabled = true;
            comboBoxCollection.Location = new Point(108, 278);
            comboBoxCollection.Name = "comboBoxCollection";
            comboBoxCollection.Size = new Size(217, 25);
            comboBoxCollection.TabIndex = 5;
            comboBoxCollection.Text = "<nom collection>";
            comboBoxCollection.SelectedIndexChanged += comboBoxCollection_SelectedIndexChanged;
            // 
            // labelTypeMediaValeur
            // 
            labelTypeMediaValeur.AutoSize = true;
            labelTypeMediaValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTypeMediaValeur.Location = new Point(286, 77);
            labelTypeMediaValeur.Margin = new Padding(4, 0, 4, 0);
            labelTypeMediaValeur.Name = "labelTypeMediaValeur";
            labelTypeMediaValeur.Size = new Size(116, 19);
            labelTypeMediaValeur.TabIndex = 9;
            labelTypeMediaValeur.Text = "<type de media>";
            labelTypeMediaValeur.Click += labelTypeMediaValeur_Click;
            // 
            // labelTypeMedia
            // 
            labelTypeMedia.AutoSize = true;
            labelTypeMedia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTypeMedia.Location = new Point(214, 77);
            labelTypeMedia.Margin = new Padding(4, 0, 4, 0);
            labelTypeMedia.Name = "labelTypeMedia";
            labelTypeMedia.Size = new Size(50, 19);
            labelTypeMedia.TabIndex = 8;
            labelTypeMedia.Text = "Types :";
            labelTypeMedia.Click += label1_Click;
            // 
            // groupBoxSujets
            // 
            groupBoxSujets.Controls.Add(listBoxSujets);
            groupBoxSujets.Controls.Add(buttonRetraitSujet);
            groupBoxSujets.Controls.Add(buttonAjoutSujet);
            groupBoxSujets.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxSujets.Location = new Point(623, 240);
            groupBoxSujets.Name = "groupBoxSujets";
            groupBoxSujets.Size = new Size(300, 171);
            groupBoxSujets.TabIndex = 5;
            groupBoxSujets.TabStop = false;
            groupBoxSujets.Text = "Sujets touchés";
            // 
            // listBoxSujets
            // 
            listBoxSujets.FormattingEnabled = true;
            listBoxSujets.ItemHeight = 17;
            listBoxSujets.Location = new Point(20, 23);
            listBoxSujets.Name = "listBoxSujets";
            listBoxSujets.SelectionMode = SelectionMode.MultiSimple;
            listBoxSujets.Size = new Size(212, 140);
            listBoxSujets.TabIndex = 2;
            listBoxSujets.SelectedIndexChanged += listBoxSujets_SelectedIndexChanged;
            // 
            // buttonRetraitSujet
            // 
            buttonRetraitSujet.Cursor = Cursors.Cross;
            buttonRetraitSujet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRetraitSujet.Location = new Point(244, 115);
            buttonRetraitSujet.Name = "buttonRetraitSujet";
            buttonRetraitSujet.Size = new Size(46, 34);
            buttonRetraitSujet.TabIndex = 1;
            buttonRetraitSujet.Text = "-";
            buttonRetraitSujet.UseVisualStyleBackColor = true;
            buttonRetraitSujet.Click += buttonRetraitSujet_Click;
            // 
            // buttonAjoutSujet
            // 
            buttonAjoutSujet.Cursor = Cursors.Cross;
            buttonAjoutSujet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjoutSujet.Location = new Point(244, 52);
            buttonAjoutSujet.Name = "buttonAjoutSujet";
            buttonAjoutSujet.Size = new Size(46, 34);
            buttonAjoutSujet.TabIndex = 0;
            buttonAjoutSujet.Text = "+";
            buttonAjoutSujet.UseVisualStyleBackColor = true;
            buttonAjoutSujet.Click += button2_Click;
            // 
            // groupBoxPresences
            // 
            groupBoxPresences.Controls.Add(listBoxPresences);
            groupBoxPresences.Controls.Add(buttonRetraitPresence);
            groupBoxPresences.Controls.Add(buttonAjoutPresence);
            groupBoxPresences.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxPresences.Location = new Point(623, 48);
            groupBoxPresences.Name = "groupBoxPresences";
            groupBoxPresences.Size = new Size(300, 184);
            groupBoxPresences.TabIndex = 4;
            groupBoxPresences.TabStop = false;
            groupBoxPresences.Text = "Personnes présentes";
            // 
            // listBoxPresences
            // 
            listBoxPresences.FormattingEnabled = true;
            listBoxPresences.ItemHeight = 17;
            listBoxPresences.Location = new Point(19, 29);
            listBoxPresences.Name = "listBoxPresences";
            listBoxPresences.SelectionMode = SelectionMode.MultiSimple;
            listBoxPresences.Size = new Size(212, 140);
            listBoxPresences.TabIndex = 2;
            // 
            // buttonRetraitPresence
            // 
            buttonRetraitPresence.Cursor = Cursors.Cross;
            buttonRetraitPresence.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRetraitPresence.Location = new Point(240, 112);
            buttonRetraitPresence.Name = "buttonRetraitPresence";
            buttonRetraitPresence.Size = new Size(46, 34);
            buttonRetraitPresence.TabIndex = 1;
            buttonRetraitPresence.Text = "-";
            buttonRetraitPresence.UseVisualStyleBackColor = true;
            buttonRetraitPresence.Click += buttonRetraitPresence_Click;
            // 
            // buttonAjoutPresence
            // 
            buttonAjoutPresence.Cursor = Cursors.Cross;
            buttonAjoutPresence.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjoutPresence.Location = new Point(240, 47);
            buttonAjoutPresence.Name = "buttonAjoutPresence";
            buttonAjoutPresence.Size = new Size(46, 34);
            buttonAjoutPresence.TabIndex = 0;
            buttonAjoutPresence.Text = "+";
            buttonAjoutPresence.UseVisualStyleBackColor = true;
            buttonAjoutPresence.Click += buttonAjoutPresence_Click;
            // 
            // textBoxDescriptionMedia
            // 
            textBoxDescriptionMedia.Location = new Point(22, 309);
            textBoxDescriptionMedia.Multiline = true;
            textBoxDescriptionMedia.Name = "textBoxDescriptionMedia";
            textBoxDescriptionMedia.PlaceholderText = "Description du média";
            textBoxDescriptionMedia.Size = new Size(587, 118);
            textBoxDescriptionMedia.TabIndex = 2;
            // 
            // buttonAjouterRester
            // 
            buttonAjouterRester.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouterRester.Location = new Point(14, 569);
            buttonAjouterRester.Name = "buttonAjouterRester";
            buttonAjouterRester.Size = new Size(218, 46);
            buttonAjouterRester.TabIndex = 3;
            buttonAjouterRester.Text = "Ajouter et Continuer";
            buttonAjouterRester.UseVisualStyleBackColor = true;
            buttonAjouterRester.Click += buttonAjouterRester_Click;
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEnregistrer.Location = new Point(18, 569);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Size = new Size(273, 46);
            buttonEnregistrer.TabIndex = 2;
            buttonEnregistrer.Text = "Enregistrer les modifications";
            buttonEnregistrer.UseVisualStyleBackColor = true;
            buttonEnregistrer.Click += buttonEnregistrer_Click;
            // 
            // buttonAjouterSortir
            // 
            buttonAjouterSortir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouterSortir.Location = new Point(251, 569);
            buttonAjouterSortir.Name = "buttonAjouterSortir";
            buttonAjouterSortir.Size = new Size(174, 46);
            buttonAjouterSortir.TabIndex = 1;
            buttonAjouterSortir.Text = "Ajouter et Sortir";
            buttonAjouterSortir.UseVisualStyleBackColor = true;
            buttonAjouterSortir.Click += buttonAjouterSortir_Click;
            // 
            // listBoxMessages
            // 
            listBoxMessages.BackColor = SystemColors.Control;
            listBoxMessages.BorderStyle = BorderStyle.None;
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.ItemHeight = 21;
            listBoxMessages.Location = new Point(37, 477);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(886, 63);
            listBoxMessages.TabIndex = 6;
            // 
            // labelSymboleErreur
            // 
            labelSymboleErreur.AutoSize = true;
            labelSymboleErreur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSymboleErreur.ForeColor = Color.Red;
            labelSymboleErreur.Location = new Point(12, 477);
            labelSymboleErreur.Name = "labelSymboleErreur";
            labelSymboleErreur.Size = new Size(18, 21);
            labelSymboleErreur.TabIndex = 7;
            labelSymboleErreur.Text = "  ";
            // 
            // labelFichierOriginalValeur
            // 
            labelFichierOriginalValeur.AutoSize = true;
            labelFichierOriginalValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelFichierOriginalValeur.Location = new Point(214, 30);
            labelFichierOriginalValeur.Margin = new Padding(4, 0, 4, 0);
            labelFichierOriginalValeur.Name = "labelFichierOriginalValeur";
            labelFichierOriginalValeur.Size = new Size(97, 19);
            labelFichierOriginalValeur.TabIndex = 27;
            labelFichierOriginalValeur.Text = "<nom fichier>";
            // 
            // labelNomMedia
            // 
            labelNomMedia.AutoSize = true;
            labelNomMedia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomMedia.Location = new Point(23, 249);
            labelNomMedia.Margin = new Padding(4, 0, 4, 0);
            labelNomMedia.Name = "labelNomMedia";
            labelNomMedia.Size = new Size(46, 19);
            labelNomMedia.TabIndex = 28;
            labelNomMedia.Text = "Nom :";
            // 
            // textBoxNomMedia
            // 
            textBoxNomMedia.Location = new Point(109, 243);
            textBoxNomMedia.Name = "textBoxNomMedia";
            textBoxNomMedia.PlaceholderText = "Nom du média (utile pour la recherche)";
            textBoxNomMedia.Size = new Size(460, 29);
            textBoxNomMedia.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(735, 569);
            button1.Name = "button1";
            button1.Size = new Size(174, 46);
            button1.TabIndex = 29;
            button1.Text = "Sortir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GererMedia
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 655);
            Controls.Add(button1);
            Controls.Add(textBoxNomMedia);
            Controls.Add(labelNomMedia);
            Controls.Add(labelFichierOriginalValeur);
            Controls.Add(groupBoxPresences);
            Controls.Add(labelDateModification);
            Controls.Add(groupBoxSujets);
            Controls.Add(textBoxDescriptionMedia);
            Controls.Add(labelDateCreation);
            Controls.Add(pictureBoxMiniature128);
            Controls.Add(labelSymboleErreur);
            Controls.Add(labelNomFichierSM4DValeur);
            Controls.Add(listBoxMessages);
            Controls.Add(labelTypeMediaValeur);
            Controls.Add(labelTypeMedia);
            Controls.Add(groupBoxDatePrise);
            Controls.Add(labelTypeFichierValeur);
            Controls.Add(textBoxDescriptionRecherches);
            Controls.Add(buttonAjouterRester);
            Controls.Add(checkBoxAnalyseRequise);
            Controls.Add(labelParModificationValeur);
            Controls.Add(buttonChoisirFichier);
            Controls.Add(labelId);
            Controls.Add(buttonAjouterSortir);
            Controls.Add(labelIdValeur);
            Controls.Add(labelParCreationValeur);
            Controls.Add(labelCollection);
            Controls.Add(buttonEnregistrer);
            Controls.Add(labelGererMedia);
            Controls.Add(comboBoxCollection);
            Controls.Add(label1);
            Controls.Add(labelAjouteLe);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "GererMedia";
            Text = "Gérer un Media";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiniature128).EndInit();
            groupBoxDatePrise.ResumeLayout(false);
            groupBoxDatePrise.PerformLayout();
            groupBoxSujets.ResumeLayout(false);
            groupBoxPresences.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelGererMedia;
        private Label labelAjouteLe;
        private Button buttonChoisirFichier;
        private Label label1;
        private Label labelId;
        private Label labelFichierArchivesValeur;
        private Label labelIdValeur;
        private Label labelFichierArchives;
        private Label labelCollection;
        private Label labelTypeFichierValeur;
        private ComboBox comboBoxCollection;
        private Label labelTypeMediaValeur;
        private Label labelTypeMedia;
        private Button buttonAjouterRester;
        private Button buttonEnregistrer;
        private Button buttonAjouterSortir;
        private TextBox textBoxDescriptionMedia;
        private Label labelEvenementPrise;
        private Button buttonSelectionEvenement;
        private GroupBox groupBoxPresences;
        private ListBox listBoxPresences;
        private Button buttonRetraitPresence;
        private Button buttonAjoutPresence;
        private GroupBox groupBoxSujets;
        private ListBox listBoxSujets;
        private Button buttonRetraitSujet;
        private Button buttonAjoutSujet;
        private TextBox textBoxDescriptionRecherches;
        private CheckBox checkBoxAnalyseRequise;
        private Label labelParModificationValeur;
        private Label labelParCreationValeur;
        private ListBox listBoxMessages;
        private Label labelSymboleErreur;
        private GroupBox groupBoxDatePrise;
        private Label labelA;
        private Label labelPres;
        private DateTimePicker dateTimePickerDatePrise;
        private TextBox textBoxNombreAnsValeur;
        private Label labelNomFichierSM4DValeur;
        private Label labelDateModification;
        private Label labelDateCreation;
        private PictureBox pictureBoxMiniature128;
        private Label label4;
        private Label label3;
        private Button buttonSelectionLieuPrise;
        private Label labelLieuPrise;
        private Label label2;
        private Label labelFichierOriginalValeur;
        private Label labelNomMedia;
        private TextBox textBoxNomMedia;
        private Button button1;
    }
}