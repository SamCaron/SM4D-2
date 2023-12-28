namespace SM4D_2
{
    partial class GererCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GererCollection));
            labelGererCollection = new Label();
            labelId = new Label();
            labelIdValeur = new Label();
            textBoxNomCollection = new TextBox();
            labelNom = new Label();
            labelContributeur = new Label();
            textBoxContributeur = new TextBox();
            labelResponsable = new Label();
            textBoxReponsable = new TextBox();
            labelNotes = new Label();
            textBoxDescription = new TextBox();
            buttonAjouter = new Button();
            buttonAnnuler = new Button();
            buttonEnregistrer = new Button();
            listBoxMessages = new ListBox();
            checkBoxDeployee = new CheckBox();
            labelSymboleErreur = new Label();
            SuspendLayout();
            // 
            // labelGererCollection
            // 
            labelGererCollection.AutoSize = true;
            labelGererCollection.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelGererCollection.Location = new Point(13, 20);
            labelGererCollection.Margin = new Padding(4, 0, 4, 0);
            labelGererCollection.Name = "labelGererCollection";
            labelGererCollection.Size = new Size(192, 25);
            labelGererCollection.TabIndex = 14;
            labelGererCollection.Text = "Gérer une collection";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(21, 56);
            labelId.Margin = new Padding(4, 0, 4, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(28, 19);
            labelId.TabIndex = 19;
            labelId.Text = "Id :";
            // 
            // labelIdValeur
            // 
            labelIdValeur.AutoSize = true;
            labelIdValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdValeur.Location = new Point(52, 56);
            labelIdValeur.Margin = new Padding(4, 0, 4, 0);
            labelIdValeur.Name = "labelIdValeur";
            labelIdValeur.Size = new Size(45, 19);
            labelIdValeur.TabIndex = 20;
            labelIdValeur.Text = "<no>";
            // 
            // textBoxNomCollection
            // 
            textBoxNomCollection.Location = new Point(76, 91);
            textBoxNomCollection.Name = "textBoxNomCollection";
            textBoxNomCollection.Size = new Size(168, 23);
            textBoxNomCollection.TabIndex = 31;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNom.Location = new Point(21, 92);
            labelNom.Margin = new Padding(4, 0, 4, 0);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(46, 19);
            labelNom.TabIndex = 32;
            labelNom.Text = "Nom :";
            // 
            // labelContributeur
            // 
            labelContributeur.AutoSize = true;
            labelContributeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelContributeur.Location = new Point(21, 134);
            labelContributeur.Margin = new Padding(4, 0, 4, 0);
            labelContributeur.Name = "labelContributeur";
            labelContributeur.Size = new Size(95, 19);
            labelContributeur.TabIndex = 33;
            labelContributeur.Text = "Contributeur :";
            // 
            // textBoxContributeur
            // 
            textBoxContributeur.Location = new Point(123, 134);
            textBoxContributeur.Name = "textBoxContributeur";
            textBoxContributeur.Size = new Size(168, 23);
            textBoxContributeur.TabIndex = 34;
            // 
            // labelResponsable
            // 
            labelResponsable.AutoSize = true;
            labelResponsable.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelResponsable.Location = new Point(21, 183);
            labelResponsable.Margin = new Padding(4, 0, 4, 0);
            labelResponsable.Name = "labelResponsable";
            labelResponsable.Size = new Size(92, 19);
            labelResponsable.TabIndex = 35;
            labelResponsable.Text = "Responsable :";
            // 
            // textBoxReponsable
            // 
            textBoxReponsable.Location = new Point(123, 179);
            textBoxReponsable.Name = "textBoxReponsable";
            textBoxReponsable.Size = new Size(168, 23);
            textBoxReponsable.TabIndex = 36;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNotes.Location = new Point(24, 232);
            labelNotes.Margin = new Padding(4, 0, 4, 0);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(85, 19);
            labelNotes.TabIndex = 37;
            labelNotes.Text = "Description :";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(123, 232);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Description de la collection";
            textBoxDescription.Size = new Size(494, 101);
            textBoxDescription.TabIndex = 38;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouter.Location = new Point(52, 511);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(133, 52);
            buttonAjouter.TabIndex = 41;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAnnuler.Location = new Point(496, 511);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(121, 52);
            buttonAnnuler.TabIndex = 39;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEnregistrer.Location = new Point(39, 511);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Size = new Size(129, 52);
            buttonEnregistrer.TabIndex = 40;
            buttonEnregistrer.Text = "Enregistrer";
            buttonEnregistrer.UseVisualStyleBackColor = true;
            buttonEnregistrer.Click += buttonEnregistrer_Click;
            // 
            // listBoxMessages
            // 
            listBoxMessages.BackColor = SystemColors.Control;
            listBoxMessages.BorderStyle = BorderStyle.None;
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.ItemHeight = 15;
            listBoxMessages.Location = new Point(66, 375);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(525, 60);
            listBoxMessages.TabIndex = 42;
            // 
            // checkBoxDeployee
            // 
            checkBoxDeployee.AutoSize = true;
            checkBoxDeployee.Checked = true;
            checkBoxDeployee.CheckState = CheckState.Checked;
            checkBoxDeployee.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxDeployee.Location = new Point(346, 92);
            checkBoxDeployee.Name = "checkBoxDeployee";
            checkBoxDeployee.Size = new Size(85, 23);
            checkBoxDeployee.TabIndex = 44;
            checkBoxDeployee.Text = "Déployée";
            checkBoxDeployee.UseVisualStyleBackColor = true;
            // 
            // labelSymboleErreur
            // 
            labelSymboleErreur.AutoSize = true;
            labelSymboleErreur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSymboleErreur.ForeColor = Color.Red;
            labelSymboleErreur.Location = new Point(25, 375);
            labelSymboleErreur.Name = "labelSymboleErreur";
            labelSymboleErreur.Size = new Size(18, 21);
            labelSymboleErreur.TabIndex = 45;
            labelSymboleErreur.Text = "  ";
            // 
            // GererCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(labelSymboleErreur);
            Controls.Add(checkBoxDeployee);
            Controls.Add(listBoxMessages);
            Controls.Add(buttonAjouter);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonEnregistrer);
            Controls.Add(textBoxDescription);
            Controls.Add(labelNotes);
            Controls.Add(textBoxReponsable);
            Controls.Add(labelResponsable);
            Controls.Add(textBoxContributeur);
            Controls.Add(labelContributeur);
            Controls.Add(labelNom);
            Controls.Add(textBoxNomCollection);
            Controls.Add(labelId);
            Controls.Add(labelIdValeur);
            Controls.Add(labelGererCollection);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GererCollection";
            Text = "GererCollection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGererCollection;
        private Label labelId;
        private Label labelIdValeur;
        private TextBox textBoxNomCollection;
        private Label labelNom;
        private Label labelContributeur;
        private TextBox textBoxContributeur;
        private Label labelResponsable;
        private TextBox textBoxReponsable;
        private Label labelNotes;
        private TextBox textBoxDescription;
        private Button buttonAjouter;
        private Button buttonAnnuler;
        private Button buttonEnregistrer;
        private ListBox listBoxMessages;
        private CheckBox checkBoxDeployee;
        private Label labelSymboleErreur;
    }
}