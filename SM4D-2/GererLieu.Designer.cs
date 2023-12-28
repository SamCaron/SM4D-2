namespace SM4D_2
{
    partial class GererLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GererLieu));
            labelSymboleErreur = new Label();
            listBoxMessages = new ListBox();
            textBoxDescriptionRecherches = new TextBox();
            checkBoxAnalyseRequise = new CheckBox();
            pictureBoxMiniature256 = new PictureBox();
            buttonChoisirFichier = new Button();
            labelId = new Label();
            labelIdValeur = new Label();
            buttonAjouterRester = new Button();
            buttonAjouterSortir = new Button();
            buttonEnregistrer = new Button();
            labelGererLieu = new Label();
            labelArtere = new Label();
            comboBoxArtere = new ComboBox();
            labelNoCivique = new Label();
            textBoxNoCivique = new TextBox();
            textBoxAppValeur = new TextBox();
            labelApp = new Label();
            textBoxDescriptionAilleurs = new TextBox();
            textBoxDescription = new TextBox();
            labelLongitude = new Label();
            labelLatitude = new Label();
            labelModification = new Label();
            dateTimePickerModification = new DateTimePicker();
            labelCreation = new Label();
            dateTimePickerCreation = new DateTimePicker();
            labelParCreation = new Label();
            labelUtilisateurCreationValeur = new Label();
            labelParModification = new Label();
            labelUtilisateurModificationValeur = new Label();
            textBoxAnneeConstructionValeur = new TextBox();
            labelAnneeConstruction = new Label();
            textBoxLongitudeValeur = new TextBox();
            textBoxLatitudeValeur = new TextBox();
            labelSecteur = new Label();
            labelSecteurValeur = new Label();
            labelAdresseComplete = new Label();
            linkLabelQuitter = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiniature256).BeginInit();
            SuspendLayout();
            // 
            // labelSymboleErreur
            // 
            labelSymboleErreur.AutoSize = true;
            labelSymboleErreur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSymboleErreur.ForeColor = Color.Red;
            labelSymboleErreur.Location = new Point(2, 496);
            labelSymboleErreur.Name = "labelSymboleErreur";
            labelSymboleErreur.Size = new Size(18, 21);
            labelSymboleErreur.TabIndex = 15;
            labelSymboleErreur.Text = "  ";
            // 
            // listBoxMessages
            // 
            listBoxMessages.BackColor = SystemColors.Control;
            listBoxMessages.BorderStyle = BorderStyle.None;
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.ItemHeight = 17;
            listBoxMessages.Location = new Point(26, 496);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(525, 68);
            listBoxMessages.TabIndex = 14;
            // 
            // textBoxDescriptionRecherches
            // 
            textBoxDescriptionRecherches.Location = new Point(676, 360);
            textBoxDescriptionRecherches.Multiline = true;
            textBoxDescriptionRecherches.Name = "textBoxDescriptionRecherches";
            textBoxDescriptionRecherches.PlaceholderText = "Identifier les lacunes à analyser";
            textBoxDescriptionRecherches.Size = new Size(275, 74);
            textBoxDescriptionRecherches.TabIndex = 2;
            // 
            // checkBoxAnalyseRequise
            // 
            checkBoxAnalyseRequise.AutoSize = true;
            checkBoxAnalyseRequise.Checked = true;
            checkBoxAnalyseRequise.CheckState = CheckState.Checked;
            checkBoxAnalyseRequise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAnalyseRequise.Location = new Point(541, 367);
            checkBoxAnalyseRequise.Name = "checkBoxAnalyseRequise";
            checkBoxAnalyseRequise.Size = new Size(123, 23);
            checkBoxAnalyseRequise.TabIndex = 1;
            checkBoxAnalyseRequise.Text = "Analyse requise";
            checkBoxAnalyseRequise.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMiniature256
            // 
            pictureBoxMiniature256.Location = new Point(697, 72);
            pictureBoxMiniature256.Name = "pictureBoxMiniature256";
            pictureBoxMiniature256.Size = new Size(150, 150);
            pictureBoxMiniature256.TabIndex = 17;
            pictureBoxMiniature256.TabStop = false;
            // 
            // buttonChoisirFichier
            // 
            buttonChoisirFichier.Cursor = Cursors.Cross;
            buttonChoisirFichier.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChoisirFichier.Location = new Point(860, 121);
            buttonChoisirFichier.Name = "buttonChoisirFichier";
            buttonChoisirFichier.Size = new Size(82, 88);
            buttonChoisirFichier.TabIndex = 0;
            buttonChoisirFichier.Text = "Choisir Image Profil";
            buttonChoisirFichier.UseVisualStyleBackColor = true;
            buttonChoisirFichier.Click += buttonChoisirFichier_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(23, 46);
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
            labelIdValeur.Location = new Point(54, 46);
            labelIdValeur.Margin = new Padding(4, 0, 4, 0);
            labelIdValeur.Name = "labelIdValeur";
            labelIdValeur.Size = new Size(45, 19);
            labelIdValeur.TabIndex = 18;
            labelIdValeur.Text = "<no>";
            // 
            // buttonAjouterRester
            // 
            buttonAjouterRester.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouterRester.Location = new Point(23, 580);
            buttonAjouterRester.Name = "buttonAjouterRester";
            buttonAjouterRester.Size = new Size(218, 52);
            buttonAjouterRester.TabIndex = 11;
            buttonAjouterRester.Text = "Ajouter et Continuer";
            buttonAjouterRester.UseVisualStyleBackColor = true;
            buttonAjouterRester.Click += buttonAjouterRester_Click;
            // 
            // buttonAjouterSortir
            // 
            buttonAjouterSortir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouterSortir.Location = new Point(260, 580);
            buttonAjouterSortir.Name = "buttonAjouterSortir";
            buttonAjouterSortir.Size = new Size(174, 52);
            buttonAjouterSortir.TabIndex = 9;
            buttonAjouterSortir.Text = "Ajouter et Sortir";
            buttonAjouterSortir.UseVisualStyleBackColor = true;
            buttonAjouterSortir.Click += buttonAjouterSortir_Click;
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEnregistrer.Location = new Point(27, 580);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Size = new Size(273, 52);
            buttonEnregistrer.TabIndex = 10;
            buttonEnregistrer.Text = "Enregistrer les modifications";
            buttonEnregistrer.UseVisualStyleBackColor = true;
            buttonEnregistrer.Click += buttonEnregistrer_Click;
            // 
            // labelGererLieu
            // 
            labelGererLieu.AutoSize = true;
            labelGererLieu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelGererLieu.Location = new Point(13, 11);
            labelGererLieu.Margin = new Padding(4, 0, 4, 0);
            labelGererLieu.Name = "labelGererLieu";
            labelGererLieu.Size = new Size(133, 25);
            labelGererLieu.TabIndex = 13;
            labelGererLieu.Text = "Gérer un Lieu";
            // 
            // labelArtere
            // 
            labelArtere.AutoSize = true;
            labelArtere.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelArtere.Location = new Point(23, 78);
            labelArtere.Margin = new Padding(4, 0, 4, 0);
            labelArtere.Name = "labelArtere";
            labelArtere.Size = new Size(54, 19);
            labelArtere.TabIndex = 26;
            labelArtere.Text = "Artère :";
            // 
            // comboBoxArtere
            // 
            comboBoxArtere.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxArtere.FormattingEnabled = true;
            comboBoxArtere.Location = new Point(105, 78);
            comboBoxArtere.Name = "comboBoxArtere";
            comboBoxArtere.Size = new Size(248, 25);
            comboBoxArtere.TabIndex = 28;
            comboBoxArtere.Text = "<Artère>";
            comboBoxArtere.SelectedIndexChanged += comboBoxArtere_SelectedIndexChanged;
            // 
            // labelNoCivique
            // 
            labelNoCivique.AutoSize = true;
            labelNoCivique.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoCivique.Location = new Point(23, 109);
            labelNoCivique.Margin = new Padding(4, 0, 4, 0);
            labelNoCivique.Name = "labelNoCivique";
            labelNoCivique.Size = new Size(80, 19);
            labelNoCivique.TabIndex = 29;
            labelNoCivique.Text = "No civique :";
            // 
            // textBoxNoCivique
            // 
            textBoxNoCivique.Location = new Point(105, 109);
            textBoxNoCivique.Name = "textBoxNoCivique";
            textBoxNoCivique.Size = new Size(76, 25);
            textBoxNoCivique.TabIndex = 30;
            textBoxNoCivique.TextChanged += comboBoxArtere_SelectedIndexChanged;
            // 
            // textBoxAppValeur
            // 
            textBoxAppValeur.Location = new Point(105, 142);
            textBoxAppValeur.Name = "textBoxAppValeur";
            textBoxAppValeur.Size = new Size(76, 25);
            textBoxAppValeur.TabIndex = 32;
            textBoxAppValeur.TextChanged += comboBoxArtere_SelectedIndexChanged;
            // 
            // labelApp
            // 
            labelApp.AutoSize = true;
            labelApp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelApp.Location = new Point(23, 142);
            labelApp.Margin = new Padding(4, 0, 4, 0);
            labelApp.Name = "labelApp";
            labelApp.Size = new Size(44, 19);
            labelApp.TabIndex = 31;
            labelApp.Text = "App. :";
            // 
            // textBoxDescriptionAilleurs
            // 
            textBoxDescriptionAilleurs.Location = new Point(386, 71);
            textBoxDescriptionAilleurs.Multiline = true;
            textBoxDescriptionAilleurs.Name = "textBoxDescriptionAilleurs";
            textBoxDescriptionAilleurs.PlaceholderText = "Description si Ailleurs";
            textBoxDescriptionAilleurs.Size = new Size(275, 74);
            textBoxDescriptionAilleurs.TabIndex = 33;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(23, 314);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Description du lieu";
            textBoxDescription.Size = new Size(509, 151);
            textBoxDescription.TabIndex = 34;
            // 
            // labelLongitude
            // 
            labelLongitude.AutoSize = true;
            labelLongitude.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelLongitude.Location = new Point(23, 264);
            labelLongitude.Margin = new Padding(4, 0, 4, 0);
            labelLongitude.Name = "labelLongitude";
            labelLongitude.Size = new Size(78, 19);
            labelLongitude.TabIndex = 37;
            labelLongitude.Text = "Longitude :";
            labelLongitude.Click += labelLongitude_Click;
            // 
            // labelLatitude
            // 
            labelLatitude.AutoSize = true;
            labelLatitude.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelLatitude.Location = new Point(196, 263);
            labelLatitude.Margin = new Padding(4, 0, 4, 0);
            labelLatitude.Name = "labelLatitude";
            labelLatitude.Size = new Size(66, 19);
            labelLatitude.TabIndex = 39;
            labelLatitude.Text = "Latitude :";
            labelLatitude.Click += labelLatitude_Click;
            // 
            // labelModification
            // 
            labelModification.AutoSize = true;
            labelModification.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelModification.Location = new Point(555, 511);
            labelModification.Margin = new Padding(4, 0, 4, 0);
            labelModification.Name = "labelModification";
            labelModification.Size = new Size(80, 19);
            labelModification.TabIndex = 18;
            labelModification.Text = "Modifié le  :";
            // 
            // dateTimePickerModification
            // 
            dateTimePickerModification.Enabled = false;
            dateTimePickerModification.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerModification.Location = new Point(676, 508);
            dateTimePickerModification.Name = "dateTimePickerModification";
            dateTimePickerModification.Size = new Size(165, 25);
            dateTimePickerModification.TabIndex = 19;
            // 
            // labelCreation
            // 
            labelCreation.AutoSize = true;
            labelCreation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCreation.Location = new Point(556, 459);
            labelCreation.Margin = new Padding(4, 0, 4, 0);
            labelCreation.Name = "labelCreation";
            labelCreation.Size = new Size(74, 19);
            labelCreation.TabIndex = 14;
            labelCreation.Text = "Ajouté le  :";
            // 
            // dateTimePickerCreation
            // 
            dateTimePickerCreation.Enabled = false;
            dateTimePickerCreation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCreation.Location = new Point(675, 451);
            dateTimePickerCreation.Name = "dateTimePickerCreation";
            dateTimePickerCreation.Size = new Size(166, 25);
            dateTimePickerCreation.TabIndex = 15;
            // 
            // labelParCreation
            // 
            labelParCreation.AutoSize = true;
            labelParCreation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelParCreation.Location = new Point(555, 488);
            labelParCreation.Margin = new Padding(4, 0, 4, 0);
            labelParCreation.Name = "labelParCreation";
            labelParCreation.Size = new Size(36, 19);
            labelParCreation.TabIndex = 16;
            labelParCreation.Text = "Par :";
            // 
            // labelUtilisateurCreationValeur
            // 
            labelUtilisateurCreationValeur.AutoSize = true;
            labelUtilisateurCreationValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelUtilisateurCreationValeur.Location = new Point(675, 483);
            labelUtilisateurCreationValeur.Margin = new Padding(4, 0, 4, 0);
            labelUtilisateurCreationValeur.Name = "labelUtilisateurCreationValeur";
            labelUtilisateurCreationValeur.Size = new Size(178, 19);
            labelUtilisateurCreationValeur.TabIndex = 17;
            labelUtilisateurCreationValeur.Text = "< nom utilisateur creation>";
            // 
            // labelParModification
            // 
            labelParModification.AutoSize = true;
            labelParModification.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelParModification.Location = new Point(556, 541);
            labelParModification.Margin = new Padding(4, 0, 4, 0);
            labelParModification.Name = "labelParModification";
            labelParModification.Size = new Size(36, 19);
            labelParModification.TabIndex = 20;
            labelParModification.Text = "Par :";
            // 
            // labelUtilisateurModificationValeur
            // 
            labelUtilisateurModificationValeur.AutoSize = true;
            labelUtilisateurModificationValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelUtilisateurModificationValeur.Location = new Point(676, 544);
            labelUtilisateurModificationValeur.Margin = new Padding(4, 0, 4, 0);
            labelUtilisateurModificationValeur.Name = "labelUtilisateurModificationValeur";
            labelUtilisateurModificationValeur.Size = new Size(208, 19);
            labelUtilisateurModificationValeur.TabIndex = 21;
            labelUtilisateurModificationValeur.Text = "< nom utilisateur modification >";
            // 
            // textBoxAnneeConstructionValeur
            // 
            textBoxAnneeConstructionValeur.Location = new Point(170, 173);
            textBoxAnneeConstructionValeur.Name = "textBoxAnneeConstructionValeur";
            textBoxAnneeConstructionValeur.Size = new Size(76, 25);
            textBoxAnneeConstructionValeur.TabIndex = 42;
            // 
            // labelAnneeConstruction
            // 
            labelAnneeConstruction.AutoSize = true;
            labelAnneeConstruction.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnneeConstruction.Location = new Point(23, 176);
            labelAnneeConstruction.Margin = new Padding(4, 0, 4, 0);
            labelAnneeConstruction.Name = "labelAnneeConstruction";
            labelAnneeConstruction.Size = new Size(138, 19);
            labelAnneeConstruction.TabIndex = 41;
            labelAnneeConstruction.Text = "Année Construction :";
            // 
            // textBoxLongitudeValeur
            // 
            textBoxLongitudeValeur.Location = new Point(111, 258);
            textBoxLongitudeValeur.Name = "textBoxLongitudeValeur";
            textBoxLongitudeValeur.Size = new Size(76, 25);
            textBoxLongitudeValeur.TabIndex = 43;
            // 
            // textBoxLatitudeValeur
            // 
            textBoxLatitudeValeur.Location = new Point(260, 258);
            textBoxLatitudeValeur.Name = "textBoxLatitudeValeur";
            textBoxLatitudeValeur.Size = new Size(76, 25);
            textBoxLatitudeValeur.TabIndex = 44;
            textBoxLatitudeValeur.TextChanged += textBoxLatitudeValeur_TextChanged;
            // 
            // labelSecteur
            // 
            labelSecteur.AutoSize = true;
            labelSecteur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSecteur.Location = new Point(24, 236);
            labelSecteur.Margin = new Padding(4, 0, 4, 0);
            labelSecteur.Name = "labelSecteur";
            labelSecteur.Size = new Size(61, 19);
            labelSecteur.TabIndex = 45;
            labelSecteur.Text = "Secteur :";
            // 
            // labelSecteurValeur
            // 
            labelSecteurValeur.AutoSize = true;
            labelSecteurValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSecteurValeur.Location = new Point(105, 236);
            labelSecteurValeur.Margin = new Padding(4, 0, 4, 0);
            labelSecteurValeur.Name = "labelSecteurValeur";
            labelSecteurValeur.Size = new Size(82, 19);
            labelSecteurValeur.TabIndex = 46;
            labelSecteurValeur.Text = "< Secteur >";
            // 
            // labelAdresseComplete
            // 
            labelAdresseComplete.AutoSize = true;
            labelAdresseComplete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdresseComplete.Location = new Point(24, 203);
            labelAdresseComplete.Margin = new Padding(4, 0, 4, 0);
            labelAdresseComplete.Name = "labelAdresseComplete";
            labelAdresseComplete.Size = new Size(77, 19);
            labelAdresseComplete.TabIndex = 47;
            labelAdresseComplete.Text = "<Adresse>";
            // 
            // linkLabelQuitter
            // 
            linkLabelQuitter.AutoSize = true;
            linkLabelQuitter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelQuitter.Location = new Point(915, 9);
            linkLabelQuitter.Name = "linkLabelQuitter";
            linkLabelQuitter.Size = new Size(58, 25);
            linkLabelQuitter.TabIndex = 48;
            linkLabelQuitter.TabStop = true;
            linkLabelQuitter.Text = "Sortir";
            linkLabelQuitter.LinkClicked += linkLabelQuitter_LinkClicked;
            // 
            // GererLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 641);
            Controls.Add(linkLabelQuitter);
            Controls.Add(labelAdresseComplete);
            Controls.Add(labelSecteur);
            Controls.Add(labelSecteurValeur);
            Controls.Add(textBoxLatitudeValeur);
            Controls.Add(textBoxLongitudeValeur);
            Controls.Add(textBoxAnneeConstructionValeur);
            Controls.Add(labelAnneeConstruction);
            Controls.Add(labelLatitude);
            Controls.Add(labelLongitude);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxDescriptionAilleurs);
            Controls.Add(textBoxAppValeur);
            Controls.Add(labelApp);
            Controls.Add(textBoxNoCivique);
            Controls.Add(labelNoCivique);
            Controls.Add(comboBoxArtere);
            Controls.Add(labelArtere);
            Controls.Add(labelUtilisateurModificationValeur);
            Controls.Add(labelParModification);
            Controls.Add(labelSymboleErreur);
            Controls.Add(labelUtilisateurCreationValeur);
            Controls.Add(listBoxMessages);
            Controls.Add(labelParCreation);
            Controls.Add(dateTimePickerCreation);
            Controls.Add(labelCreation);
            Controls.Add(dateTimePickerModification);
            Controls.Add(textBoxDescriptionRecherches);
            Controls.Add(labelModification);
            Controls.Add(checkBoxAnalyseRequise);
            Controls.Add(buttonAjouterRester);
            Controls.Add(buttonAjouterSortir);
            Controls.Add(labelId);
            Controls.Add(buttonEnregistrer);
            Controls.Add(labelIdValeur);
            Controls.Add(labelGererLieu);
            Controls.Add(buttonChoisirFichier);
            Controls.Add(pictureBoxMiniature256);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GererLieu";
            Text = "Gérer un Lieu";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiniature256).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSymboleErreur;
        private ListBox listBoxMessages;
        private TextBox textBoxDescriptionRecherches;
        private CheckBox checkBoxAnalyseRequise;
        private PictureBox pictureBoxMiniature256;
        private Button buttonChoisirFichier;
        private Label labelId;
        private Label labelIdValeur;
        private Button buttonAjouterRester;
        private Button buttonAjouterSortir;
        private Button buttonEnregistrer;
        private Label labelGererLieu;
        private Label labelArtere;
        private ComboBox comboBoxArtere;
        private Label labelNoCivique;
        private TextBox textBoxNoCivique;
        private TextBox textBoxAppValeur;
        private Label labelApp;
        private TextBox textBoxDescriptionAilleurs;
        private TextBox textBoxDescription;
        private Label labelLongitude;
        private Label labelLatitude;
        private Label labelModification;
        private DateTimePicker dateTimePickerModification;
        private Label labelCreation;
        private DateTimePicker dateTimePickerCreation;
        private Label labelParCreation;
        private Label labelUtilisateurCreationValeur;
        private Label labelParModification;
        private Label labelUtilisateurModificationValeur;
        private TextBox textBoxAnneeConstructionValeur;
        private Label labelAnneeConstruction;
        private TextBox textBoxLongitudeValeur;
        private TextBox textBoxLatitudeValeur;
        private Label labelSecteur;
        private Label labelSecteurValeur;
        private Label labelAdresseComplete;
        private LinkLabel linkLabelQuitter;
    }
}