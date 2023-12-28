namespace SM4D_2
{
    partial class BorneMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorneMedia));
            pictureBoxMiniature500 = new PictureBox();
            textBoxDescriptionMedia = new TextBox();
            labelFichierOriginalValeur = new Label();
            labelNomCollection = new Label();
            labelNomMedia = new Label();
            labelA = new Label();
            labelPres = new Label();
            labelDatePrise = new Label();
            labelPrise = new Label();
            labelNbAnsPres = new Label();
            buttonPrecedent = new Button();
            buttonSuivant = new Button();
            buttonSupprimer = new Button();
            buttonModifier = new Button();
            buttonRetourListe = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiniature500).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMiniature500
            // 
            pictureBoxMiniature500.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMiniature500.Location = new Point(7, 12);
            pictureBoxMiniature500.Name = "pictureBoxMiniature500";
            pictureBoxMiniature500.Size = new Size(600, 600);
            pictureBoxMiniature500.TabIndex = 25;
            pictureBoxMiniature500.TabStop = false;
            // 
            // textBoxDescriptionMedia
            // 
            textBoxDescriptionMedia.Location = new Point(615, 109);
            textBoxDescriptionMedia.Multiline = true;
            textBoxDescriptionMedia.Name = "textBoxDescriptionMedia";
            textBoxDescriptionMedia.PlaceholderText = "Description du média";
            textBoxDescriptionMedia.ReadOnly = true;
            textBoxDescriptionMedia.Size = new Size(273, 135);
            textBoxDescriptionMedia.TabIndex = 26;
            // 
            // labelFichierOriginalValeur
            // 
            labelFichierOriginalValeur.AutoSize = true;
            labelFichierOriginalValeur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFichierOriginalValeur.Location = new Point(65, 625);
            labelFichierOriginalValeur.Margin = new Padding(4, 0, 4, 0);
            labelFichierOriginalValeur.Name = "labelFichierOriginalValeur";
            labelFichierOriginalValeur.Size = new Size(84, 15);
            labelFichierOriginalValeur.TabIndex = 28;
            labelFichierOriginalValeur.Text = "<nom fichier>";
            // 
            // labelNomCollection
            // 
            labelNomCollection.AutoSize = true;
            labelNomCollection.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomCollection.Location = new Point(613, 12);
            labelNomCollection.Margin = new Padding(4, 0, 4, 0);
            labelNomCollection.Name = "labelNomCollection";
            labelNomCollection.Size = new Size(118, 19);
            labelNomCollection.TabIndex = 29;
            labelNomCollection.Text = "<nom collection>";
            // 
            // labelNomMedia
            // 
            labelNomMedia.AutoSize = true;
            labelNomMedia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomMedia.Location = new Point(615, 43);
            labelNomMedia.Margin = new Padding(4, 0, 4, 0);
            labelNomMedia.Name = "labelNomMedia";
            labelNomMedia.Size = new Size(84, 15);
            labelNomMedia.TabIndex = 30;
            labelNomMedia.Text = "<nom média>";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelA.Location = new Point(764, 77);
            labelA.Margin = new Padding(4, 0, 4, 0);
            labelA.Name = "labelA";
            labelA.Size = new Size(17, 15);
            labelA.TabIndex = 34;
            labelA.Text = "(à";
            labelA.UseWaitCursor = true;
            // 
            // labelPres
            // 
            labelPres.AutoSize = true;
            labelPres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPres.Location = new Point(818, 77);
            labelPres.Margin = new Padding(4, 0, 4, 0);
            labelPres.Name = "labelPres";
            labelPres.Size = new Size(54, 15);
            labelPres.TabIndex = 32;
            labelPres.Text = "ans près)";
            // 
            // labelDatePrise
            // 
            labelDatePrise.AutoSize = true;
            labelDatePrise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDatePrise.Location = new Point(655, 74);
            labelDatePrise.Margin = new Padding(4, 0, 4, 0);
            labelDatePrise.Name = "labelDatePrise";
            labelDatePrise.Size = new Size(108, 19);
            labelDatePrise.TabIndex = 35;
            labelDatePrise.Text = "<date de prise>";
            // 
            // labelPrise
            // 
            labelPrise.AutoSize = true;
            labelPrise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrise.Location = new Point(615, 74);
            labelPrise.Margin = new Padding(4, 0, 4, 0);
            labelPrise.Name = "labelPrise";
            labelPrise.Size = new Size(45, 19);
            labelPrise.TabIndex = 36;
            labelPrise.Text = "Prise: ";
            labelPrise.Click += label1_Click;
            // 
            // labelNbAnsPres
            // 
            labelNbAnsPres.AutoSize = true;
            labelNbAnsPres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelNbAnsPres.Location = new Point(779, 77);
            labelNbAnsPres.Margin = new Padding(4, 0, 4, 0);
            labelNbAnsPres.Name = "labelNbAnsPres";
            labelNbAnsPres.Size = new Size(41, 15);
            labelNbAnsPres.TabIndex = 37;
            labelNbAnsPres.Text = "<ans>";
            // 
            // buttonPrecedent
            // 
            buttonPrecedent.Image = (Image)resources.GetObject("buttonPrecedent.Image");
            buttonPrecedent.Location = new Point(7, 619);
            buttonPrecedent.Name = "buttonPrecedent";
            buttonPrecedent.Size = new Size(41, 31);
            buttonPrecedent.TabIndex = 57;
            buttonPrecedent.UseVisualStyleBackColor = true;
            buttonPrecedent.Click += buttonPrecedent_Click;
            // 
            // buttonSuivant
            // 
            buttonSuivant.Image = (Image)resources.GetObject("buttonSuivant.Image");
            buttonSuivant.Location = new Point(566, 619);
            buttonSuivant.Name = "buttonSuivant";
            buttonSuivant.Size = new Size(41, 31);
            buttonSuivant.TabIndex = 56;
            buttonSuivant.UseVisualStyleBackColor = true;
            buttonSuivant.Click += buttonSuivant_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimer.Location = new Point(677, 420);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(147, 46);
            buttonSupprimer.TabIndex = 62;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifier.Location = new Point(677, 347);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(147, 46);
            buttonModifier.TabIndex = 61;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonRetourListe
            // 
            buttonRetourListe.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRetourListe.Location = new Point(677, 594);
            buttonRetourListe.Name = "buttonRetourListe";
            buttonRetourListe.Size = new Size(195, 46);
            buttonRetourListe.TabIndex = 63;
            buttonRetourListe.Text = "Retourner à la liste";
            buttonRetourListe.UseVisualStyleBackColor = true;
            buttonRetourListe.Click += buttonRetourListe_Click;
            // 
            // BorneMedia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 661);
            Controls.Add(buttonRetourListe);
            Controls.Add(buttonSupprimer);
            Controls.Add(buttonModifier);
            Controls.Add(buttonPrecedent);
            Controls.Add(buttonSuivant);
            Controls.Add(labelNbAnsPres);
            Controls.Add(labelPrise);
            Controls.Add(labelDatePrise);
            Controls.Add(labelA);
            Controls.Add(labelPres);
            Controls.Add(labelNomMedia);
            Controls.Add(labelNomCollection);
            Controls.Add(labelFichierOriginalValeur);
            Controls.Add(textBoxDescriptionMedia);
            Controls.Add(pictureBoxMiniature500);
            Name = "BorneMedia";
            Text = "BorneMedia";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiniature500).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMiniature500;
        private TextBox textBoxDescriptionMedia;
        private Label labelFichierOriginalValeur;
        private Label labelNomCollection;
        private Label labelNomMedia;
        private Label labelA;
        private Label labelPres;
        private Label labelDatePrise;
        private Label labelPrise;
        private Label labelNbAnsPres;
        private Button buttonPrecedent;
        private Button buttonSuivant;
        private Button buttonSupprimer;
        private Button buttonModifier;
        private Button buttonRetourListe;
    }
}