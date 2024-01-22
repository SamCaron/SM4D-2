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
            rtbCommentaires = new RichTextBox();
            btnCommenter = new Button();
            rtbCommenter = new RichTextBox();
            lblComm = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiniature500).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMiniature500
            // 
            pictureBoxMiniature500.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMiniature500.Location = new Point(12, -19);
            pictureBoxMiniature500.Name = "pictureBoxMiniature500";
            pictureBoxMiniature500.Size = new Size(685, 799);
            pictureBoxMiniature500.TabIndex = 25;
            pictureBoxMiniature500.TabStop = false;
            // 
            // textBoxDescriptionMedia
            // 
            textBoxDescriptionMedia.Location = new Point(703, 145);
            textBoxDescriptionMedia.Margin = new Padding(3, 4, 3, 4);
            textBoxDescriptionMedia.Multiline = true;
            textBoxDescriptionMedia.Name = "textBoxDescriptionMedia";
            textBoxDescriptionMedia.PlaceholderText = "Description du média";
            textBoxDescriptionMedia.ReadOnly = true;
            textBoxDescriptionMedia.Size = new Size(311, 130);
            textBoxDescriptionMedia.TabIndex = 26;
            // 
            // labelFichierOriginalValeur
            // 
            labelFichierOriginalValeur.AutoSize = true;
            labelFichierOriginalValeur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFichierOriginalValeur.Location = new Point(74, 833);
            labelFichierOriginalValeur.Margin = new Padding(5, 0, 5, 0);
            labelFichierOriginalValeur.Name = "labelFichierOriginalValeur";
            labelFichierOriginalValeur.Size = new Size(104, 20);
            labelFichierOriginalValeur.TabIndex = 28;
            labelFichierOriginalValeur.Text = "<nom fichier>";
            labelFichierOriginalValeur.TextChanged += labelFichierOriginalValeur_TextChanged;
            // 
            // labelNomCollection
            // 
            labelNomCollection.AutoSize = true;
            labelNomCollection.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomCollection.Location = new Point(701, 16);
            labelNomCollection.Margin = new Padding(5, 0, 5, 0);
            labelNomCollection.Name = "labelNomCollection";
            labelNomCollection.Size = new Size(147, 23);
            labelNomCollection.TabIndex = 29;
            labelNomCollection.Text = "<nom collection>";
            // 
            // labelNomMedia
            // 
            labelNomMedia.AutoSize = true;
            labelNomMedia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomMedia.Location = new Point(703, 57);
            labelNomMedia.Margin = new Padding(5, 0, 5, 0);
            labelNomMedia.Name = "labelNomMedia";
            labelNomMedia.Size = new Size(105, 20);
            labelNomMedia.TabIndex = 30;
            labelNomMedia.Text = "<nom média>";
            labelNomMedia.Click += labelNomMedia_Click;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelA.Location = new Point(873, 103);
            labelA.Margin = new Padding(5, 0, 5, 0);
            labelA.Name = "labelA";
            labelA.Size = new Size(22, 20);
            labelA.TabIndex = 34;
            labelA.Text = "(à";
            labelA.UseWaitCursor = true;
            // 
            // labelPres
            // 
            labelPres.AutoSize = true;
            labelPres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPres.Location = new Point(935, 103);
            labelPres.Margin = new Padding(5, 0, 5, 0);
            labelPres.Name = "labelPres";
            labelPres.Size = new Size(68, 20);
            labelPres.TabIndex = 32;
            labelPres.Text = "ans près)";
            // 
            // labelDatePrise
            // 
            labelDatePrise.AutoSize = true;
            labelDatePrise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDatePrise.Location = new Point(749, 99);
            labelDatePrise.Margin = new Padding(5, 0, 5, 0);
            labelDatePrise.Name = "labelDatePrise";
            labelDatePrise.Size = new Size(133, 23);
            labelDatePrise.TabIndex = 35;
            labelDatePrise.Text = "<date de prise>";
            // 
            // labelPrise
            // 
            labelPrise.AutoSize = true;
            labelPrise.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrise.Location = new Point(703, 99);
            labelPrise.Margin = new Padding(5, 0, 5, 0);
            labelPrise.Name = "labelPrise";
            labelPrise.Size = new Size(55, 23);
            labelPrise.TabIndex = 36;
            labelPrise.Text = "Prise: ";
            labelPrise.Click += label1_Click;
            // 
            // labelNbAnsPres
            // 
            labelNbAnsPres.AutoSize = true;
            labelNbAnsPres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelNbAnsPres.Location = new Point(890, 103);
            labelNbAnsPres.Margin = new Padding(5, 0, 5, 0);
            labelNbAnsPres.Name = "labelNbAnsPres";
            labelNbAnsPres.Size = new Size(51, 20);
            labelNbAnsPres.TabIndex = 37;
            labelNbAnsPres.Text = "<ans>";
            // 
            // buttonPrecedent
            // 
            buttonPrecedent.Image = (Image)resources.GetObject("buttonPrecedent.Image");
            buttonPrecedent.Location = new Point(8, 825);
            buttonPrecedent.Margin = new Padding(3, 4, 3, 4);
            buttonPrecedent.Name = "buttonPrecedent";
            buttonPrecedent.Size = new Size(47, 41);
            buttonPrecedent.TabIndex = 57;
            buttonPrecedent.UseVisualStyleBackColor = true;
            buttonPrecedent.Click += buttonPrecedent_Click;
            // 
            // buttonSuivant
            // 
            buttonSuivant.Image = (Image)resources.GetObject("buttonSuivant.Image");
            buttonSuivant.Location = new Point(647, 825);
            buttonSuivant.Margin = new Padding(3, 4, 3, 4);
            buttonSuivant.Name = "buttonSuivant";
            buttonSuivant.Size = new Size(47, 41);
            buttonSuivant.TabIndex = 56;
            buttonSuivant.UseVisualStyleBackColor = true;
            buttonSuivant.Click += buttonSuivant_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimer.Location = new Point(854, 283);
            buttonSupprimer.Margin = new Padding(3, 4, 3, 4);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(142, 50);
            buttonSupprimer.TabIndex = 62;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifier.Location = new Point(703, 283);
            buttonModifier.Margin = new Padding(3, 4, 3, 4);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(145, 50);
            buttonModifier.TabIndex = 61;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonRetourListe
            // 
            buttonRetourListe.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRetourListe.Location = new Point(740, 825);
            buttonRetourListe.Margin = new Padding(3, 4, 3, 4);
            buttonRetourListe.Name = "buttonRetourListe";
            buttonRetourListe.Size = new Size(263, 49);
            buttonRetourListe.TabIndex = 63;
            buttonRetourListe.Text = "Retourner à la liste";
            buttonRetourListe.UseVisualStyleBackColor = true;
            buttonRetourListe.Click += buttonRetourListe_Click;
            // 
            // rtbCommentaires
            // 
            rtbCommentaires.Location = new Point(703, 358);
            rtbCommentaires.Name = "rtbCommentaires";
            rtbCommentaires.ReadOnly = true;
            rtbCommentaires.Size = new Size(313, 312);
            rtbCommentaires.TabIndex = 1;
            rtbCommentaires.Text = "";
            // 
            // btnCommenter
            // 
            btnCommenter.Location = new Point(889, 782);
            btnCommenter.Name = "btnCommenter";
            btnCommenter.Size = new Size(107, 36);
            btnCommenter.TabIndex = 0;
            btnCommenter.Text = "Commenter";
            btnCommenter.Click += btnCommenter_Click;
            // 
            // rtbCommenter
            // 
            rtbCommenter.AcceptsTab = true;
            rtbCommenter.Location = new Point(703, 676);
            rtbCommenter.Margin = new Padding(3, 3, 3, 36);
            rtbCommenter.Name = "rtbCommenter";
            rtbCommenter.Size = new Size(313, 102);
            rtbCommenter.TabIndex = 64;
            rtbCommenter.Text = "";
            // 
            // lblComm
            // 
            lblComm.AutoSize = true;
            lblComm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblComm.Location = new Point(712, 337);
            lblComm.Name = "lblComm";
            lblComm.Size = new Size(211, 41);
            lblComm.TabIndex = 65;
            lblComm.Text = "Commentaires";
            // 
            // BorneMedia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 881);
            Controls.Add(btnCommenter);
            Controls.Add(lblComm);
            Controls.Add(rtbCommenter);
            Controls.Add(rtbCommentaires);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private RichTextBox rtbCommentaires;
        private Button btnCommenter;
        private RichTextBox rtbCommenter;
        private Label lblComm;
    }
}