namespace SM4D_2
{
    partial class FiltresLieux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltresLieux));
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            textBoxIdValeur = new TextBox();
            labelId = new Label();
            comboBoxIndicateurRecherches = new ComboBox();
            labelIndicateurRecherches = new Label();
            dateTimePickerDateModificationA = new DateTimePicker();
            label2 = new Label();
            dateTimePickerDateModificationDe = new DateTimePicker();
            labelDateModification = new Label();
            dateTimePickerDateCreationA = new DateTimePicker();
            label1 = new Label();
            dateTimePickerDateCreationDe = new DateTimePicker();
            labelDateCreation = new Label();
            comboBoxSecteur = new ComboBox();
            labelSecteur = new Label();
            comboBoxRue = new ComboBox();
            labelRue = new Label();
            buttonSortir = new Button();
            buttonAppliquer = new Button();
            SuspendLayout();
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(178, 12);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Tout";
            textBoxDescription.Size = new Size(291, 23);
            textBoxDescription.TabIndex = 23;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(29, 20);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(129, 15);
            labelDescription.TabIndex = 22;
            labelDescription.Text = "Descriptions contenant";
            labelDescription.Click += labelDescription_Click;
            // 
            // textBoxIdValeur
            // 
            textBoxIdValeur.Location = new Point(55, 113);
            textBoxIdValeur.Name = "textBoxIdValeur";
            textBoxIdValeur.PlaceholderText = "Tous";
            textBoxIdValeur.Size = new Size(100, 23);
            textBoxIdValeur.TabIndex = 21;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(26, 121);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 15);
            labelId.TabIndex = 20;
            labelId.Text = "Id";
            // 
            // comboBoxIndicateurRecherches
            // 
            comboBoxIndicateurRecherches.FormattingEnabled = true;
            comboBoxIndicateurRecherches.Location = new Point(162, 142);
            comboBoxIndicateurRecherches.Name = "comboBoxIndicateurRecherches";
            comboBoxIndicateurRecherches.Size = new Size(121, 23);
            comboBoxIndicateurRecherches.TabIndex = 25;
            comboBoxIndicateurRecherches.Text = "Tout";
            // 
            // labelIndicateurRecherches
            // 
            labelIndicateurRecherches.AutoSize = true;
            labelIndicateurRecherches.Location = new Point(24, 150);
            labelIndicateurRecherches.Name = "labelIndicateurRecherches";
            labelIndicateurRecherches.Size = new Size(115, 15);
            labelIndicateurRecherches.TabIndex = 24;
            labelIndicateurRecherches.Text = "Indicateur d'analyse ";
            // 
            // dateTimePickerDateModificationA
            // 
            dateTimePickerDateModificationA.Location = new Point(358, 231);
            dateTimePickerDateModificationA.Name = "dateTimePickerDateModificationA";
            dateTimePickerDateModificationA.Size = new Size(139, 23);
            dateTimePickerDateModificationA.TabIndex = 33;
            dateTimePickerDateModificationA.Value = new DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 239);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 32;
            label2.Text = "et";
            // 
            // dateTimePickerDateModificationDe
            // 
            dateTimePickerDateModificationDe.Location = new Point(165, 231);
            dateTimePickerDateModificationDe.Name = "dateTimePickerDateModificationDe";
            dateTimePickerDateModificationDe.Size = new Size(139, 23);
            dateTimePickerDateModificationDe.TabIndex = 31;
            dateTimePickerDateModificationDe.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // labelDateModification
            // 
            labelDateModification.AutoSize = true;
            labelDateModification.Location = new Point(23, 239);
            labelDateModification.Name = "labelDateModification";
            labelDateModification.Size = new Size(127, 15);
            labelDateModification.TabIndex = 30;
            labelDateModification.Text = "Date de modif.  entre   ";
            // 
            // dateTimePickerDateCreationA
            // 
            dateTimePickerDateCreationA.Location = new Point(358, 189);
            dateTimePickerDateCreationA.Name = "dateTimePickerDateCreationA";
            dateTimePickerDateCreationA.Size = new Size(139, 23);
            dateTimePickerDateCreationA.TabIndex = 29;
            dateTimePickerDateCreationA.Value = new DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 197);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 28;
            label1.Text = "et";
            // 
            // dateTimePickerDateCreationDe
            // 
            dateTimePickerDateCreationDe.Location = new Point(165, 189);
            dateTimePickerDateCreationDe.Name = "dateTimePickerDateCreationDe";
            dateTimePickerDateCreationDe.Size = new Size(139, 23);
            dateTimePickerDateCreationDe.TabIndex = 27;
            dateTimePickerDateCreationDe.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // labelDateCreation
            // 
            labelDateCreation.AutoSize = true;
            labelDateCreation.Location = new Point(23, 197);
            labelDateCreation.Name = "labelDateCreation";
            labelDateCreation.Size = new Size(132, 15);
            labelDateCreation.TabIndex = 26;
            labelDateCreation.Text = "Date de création entre   ";
            // 
            // comboBoxSecteur
            // 
            comboBoxSecteur.FormattingEnabled = true;
            comboBoxSecteur.Location = new Point(100, 42);
            comboBoxSecteur.Name = "comboBoxSecteur";
            comboBoxSecteur.Size = new Size(240, 23);
            comboBoxSecteur.TabIndex = 35;
            comboBoxSecteur.Text = "Tout";
            // 
            // labelSecteur
            // 
            labelSecteur.AutoSize = true;
            labelSecteur.Location = new Point(29, 50);
            labelSecteur.Name = "labelSecteur";
            labelSecteur.Size = new Size(49, 15);
            labelSecteur.TabIndex = 34;
            labelSecteur.Text = "Secteur ";
            labelSecteur.Click += label3_Click;
            // 
            // comboBoxRue
            // 
            comboBoxRue.FormattingEnabled = true;
            comboBoxRue.Location = new Point(100, 71);
            comboBoxRue.Name = "comboBoxRue";
            comboBoxRue.Size = new Size(240, 23);
            comboBoxRue.TabIndex = 37;
            comboBoxRue.Text = "Tout";
            // 
            // labelRue
            // 
            labelRue.AutoSize = true;
            labelRue.Location = new Point(29, 79);
            labelRue.Name = "labelRue";
            labelRue.Size = new Size(27, 15);
            labelRue.TabIndex = 36;
            labelRue.Text = "Rue";
            // 
            // buttonSortir
            // 
            buttonSortir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSortir.Location = new Point(358, 280);
            buttonSortir.Name = "buttonSortir";
            buttonSortir.Size = new Size(139, 46);
            buttonSortir.TabIndex = 39;
            buttonSortir.Text = "Annuler et Sortir";
            buttonSortir.UseVisualStyleBackColor = true;
            buttonSortir.Click += buttonSortir_Click;
            // 
            // buttonAppliquer
            // 
            buttonAppliquer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAppliquer.Location = new Point(27, 282);
            buttonAppliquer.Name = "buttonAppliquer";
            buttonAppliquer.Size = new Size(242, 46);
            buttonAppliquer.TabIndex = 38;
            buttonAppliquer.Text = "Enregistrer et appliquer les filtres";
            buttonAppliquer.UseVisualStyleBackColor = true;
            buttonAppliquer.Click += buttonAppliquer_Click;
            // 
            // FiltresLieux
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 350);
            Controls.Add(buttonSortir);
            Controls.Add(buttonAppliquer);
            Controls.Add(comboBoxRue);
            Controls.Add(labelRue);
            Controls.Add(comboBoxSecteur);
            Controls.Add(labelSecteur);
            Controls.Add(dateTimePickerDateModificationA);
            Controls.Add(label2);
            Controls.Add(dateTimePickerDateModificationDe);
            Controls.Add(labelDateModification);
            Controls.Add(dateTimePickerDateCreationA);
            Controls.Add(label1);
            Controls.Add(dateTimePickerDateCreationDe);
            Controls.Add(labelDateCreation);
            Controls.Add(comboBoxIndicateurRecherches);
            Controls.Add(labelIndicateurRecherches);
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(textBoxIdValeur);
            Controls.Add(labelId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FiltresLieux";
            Text = "Filtres pour les Lieux";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDescription;
        private Label labelDescription;
        private TextBox textBoxIdValeur;
        private Label labelId;
        private ComboBox comboBoxIndicateurRecherches;
        private Label labelIndicateurRecherches;
        private DateTimePicker dateTimePickerDateModificationA;
        private Label label2;
        private DateTimePicker dateTimePickerDateModificationDe;
        private Label labelDateModification;
        private DateTimePicker dateTimePickerDateCreationA;
        private Label label1;
        private DateTimePicker dateTimePickerDateCreationDe;
        private Label labelDateCreation;
        private ComboBox comboBoxSecteur;
        private Label labelSecteur;
        private ComboBox comboBoxRue;
        private Label labelRue;
        private Button buttonSortir;
        private Button buttonAppliquer;
    }
}