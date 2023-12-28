namespace SM4D_2
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            linkLabelAccueil = new LinkLabel();
            linkLabelQuitter = new LinkLabel();
            groupBoxMedias = new GroupBox();
            labelNombreMediasValeur = new Label();
            labelNombreMedias = new Label();
            buttonMedias = new Button();
            groupBoxPersonnes = new GroupBox();
            labelNombrePersonnesValeur = new Label();
            labelNombrePersonnes = new Label();
            buttonPersonnes = new Button();
            groupBoxLieux = new GroupBox();
            labelNombreLieuxValeur = new Label();
            labelNombreLieux = new Label();
            buttonLieux = new Button();
            groupBoxEvenements = new GroupBox();
            labelNombreEvenementsValeur = new Label();
            labelNombreEvenements = new Label();
            buttonEvenements = new Button();
            groupBoxLacunes = new GroupBox();
            labelNombreLacunesValeur = new Label();
            labelNombreLacunes = new Label();
            buttonLacunes = new Button();
            groupBoxReglages = new GroupBox();
            buttonReglages = new Button();
            groupBoxMedias.SuspendLayout();
            groupBoxPersonnes.SuspendLayout();
            groupBoxLieux.SuspendLayout();
            groupBoxEvenements.SuspendLayout();
            groupBoxLacunes.SuspendLayout();
            groupBoxReglages.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabelAccueil
            // 
            linkLabelAccueil.AutoSize = true;
            linkLabelAccueil.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelAccueil.Location = new Point(12, 9);
            linkLabelAccueil.Name = "linkLabelAccueil";
            linkLabelAccueil.Size = new Size(73, 25);
            linkLabelAccueil.TabIndex = 0;
            linkLabelAccueil.TabStop = true;
            linkLabelAccueil.Text = "Accueil";
            linkLabelAccueil.LinkClicked += linkLabelAccueil_LinkClicked;
            // 
            // linkLabelQuitter
            // 
            linkLabelQuitter.AutoSize = true;
            linkLabelQuitter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelQuitter.Location = new Point(777, 9);
            linkLabelQuitter.Name = "linkLabelQuitter";
            linkLabelQuitter.Size = new Size(71, 25);
            linkLabelQuitter.TabIndex = 1;
            linkLabelQuitter.TabStop = true;
            linkLabelQuitter.Text = "Quitter";
            linkLabelQuitter.LinkClicked += linkLabelQuitter_LinkClicked;
            // 
            // groupBoxMedias
            // 
            groupBoxMedias.BackColor = SystemColors.ControlLight;
            groupBoxMedias.Controls.Add(labelNombreMediasValeur);
            groupBoxMedias.Controls.Add(labelNombreMedias);
            groupBoxMedias.Controls.Add(buttonMedias);
            groupBoxMedias.FlatStyle = FlatStyle.Popup;
            groupBoxMedias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxMedias.Location = new Point(57, 72);
            groupBoxMedias.Name = "groupBoxMedias";
            groupBoxMedias.Size = new Size(200, 200);
            groupBoxMedias.TabIndex = 3;
            groupBoxMedias.TabStop = false;
            groupBoxMedias.Text = "Médias";
            // 
            // labelNombreMediasValeur
            // 
            labelNombreMediasValeur.AutoSize = true;
            labelNombreMediasValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreMediasValeur.Location = new Point(87, 149);
            labelNombreMediasValeur.Name = "labelNombreMediasValeur";
            labelNombreMediasValeur.Size = new Size(77, 19);
            labelNombreMediasValeur.TabIndex = 3;
            labelNombreMediasValeur.Text = "<nombre>";
            labelNombreMediasValeur.Click += label2_Click;
            // 
            // labelNombreMedias
            // 
            labelNombreMedias.AutoSize = true;
            labelNombreMedias.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreMedias.Location = new Point(47, 149);
            labelNombreMedias.Name = "labelNombreMedias";
            labelNombreMedias.Size = new Size(34, 19);
            labelNombreMedias.TabIndex = 1;
            labelNombreMedias.Text = "Nb: ";
            labelNombreMedias.Click += label1_Click;
            // 
            // buttonMedias
            // 
            buttonMedias.BackgroundImage = (Image)resources.GetObject("buttonMedias.BackgroundImage");
            buttonMedias.FlatStyle = FlatStyle.Popup;
            buttonMedias.Location = new Point(49, 36);
            buttonMedias.Name = "buttonMedias";
            buttonMedias.Size = new Size(106, 102);
            buttonMedias.TabIndex = 0;
            buttonMedias.UseVisualStyleBackColor = true;
            buttonMedias.Click += button1_Click;
            // 
            // groupBoxPersonnes
            // 
            groupBoxPersonnes.BackColor = SystemColors.ControlLight;
            groupBoxPersonnes.Controls.Add(labelNombrePersonnesValeur);
            groupBoxPersonnes.Controls.Add(labelNombrePersonnes);
            groupBoxPersonnes.Controls.Add(buttonPersonnes);
            groupBoxPersonnes.FlatStyle = FlatStyle.Popup;
            groupBoxPersonnes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxPersonnes.Location = new Point(336, 72);
            groupBoxPersonnes.Name = "groupBoxPersonnes";
            groupBoxPersonnes.Size = new Size(200, 200);
            groupBoxPersonnes.TabIndex = 4;
            groupBoxPersonnes.TabStop = false;
            groupBoxPersonnes.Text = "Familles";
            groupBoxPersonnes.Enter += groupBox1_Enter;
            // 
            // labelNombrePersonnesValeur
            // 
            labelNombrePersonnesValeur.AutoSize = true;
            labelNombrePersonnesValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombrePersonnesValeur.Location = new Point(78, 149);
            labelNombrePersonnesValeur.Name = "labelNombrePersonnesValeur";
            labelNombrePersonnesValeur.Size = new Size(77, 19);
            labelNombrePersonnesValeur.TabIndex = 3;
            labelNombrePersonnesValeur.Text = "<nombre>";
            // 
            // labelNombrePersonnes
            // 
            labelNombrePersonnes.AutoSize = true;
            labelNombrePersonnes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombrePersonnes.Location = new Point(39, 149);
            labelNombrePersonnes.Name = "labelNombrePersonnes";
            labelNombrePersonnes.Size = new Size(34, 19);
            labelNombrePersonnes.TabIndex = 1;
            labelNombrePersonnes.Text = "Nb: ";
            // 
            // buttonPersonnes
            // 
            buttonPersonnes.BackgroundImage = (Image)resources.GetObject("buttonPersonnes.BackgroundImage");
            buttonPersonnes.FlatStyle = FlatStyle.Popup;
            buttonPersonnes.Location = new Point(49, 36);
            buttonPersonnes.Name = "buttonPersonnes";
            buttonPersonnes.Size = new Size(106, 102);
            buttonPersonnes.TabIndex = 0;
            buttonPersonnes.UseVisualStyleBackColor = true;
            buttonPersonnes.Click += buttonPersonnes_Click;
            // 
            // groupBoxLieux
            // 
            groupBoxLieux.BackColor = SystemColors.ControlLight;
            groupBoxLieux.Controls.Add(labelNombreLieuxValeur);
            groupBoxLieux.Controls.Add(labelNombreLieux);
            groupBoxLieux.Controls.Add(buttonLieux);
            groupBoxLieux.FlatStyle = FlatStyle.Popup;
            groupBoxLieux.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxLieux.Location = new Point(57, 378);
            groupBoxLieux.Name = "groupBoxLieux";
            groupBoxLieux.Size = new Size(200, 200);
            groupBoxLieux.TabIndex = 5;
            groupBoxLieux.TabStop = false;
            groupBoxLieux.Text = "Lieux";
            // 
            // labelNombreLieuxValeur
            // 
            labelNombreLieuxValeur.AutoSize = true;
            labelNombreLieuxValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreLieuxValeur.Location = new Point(73, 155);
            labelNombreLieuxValeur.Name = "labelNombreLieuxValeur";
            labelNombreLieuxValeur.Size = new Size(77, 19);
            labelNombreLieuxValeur.TabIndex = 3;
            labelNombreLieuxValeur.Text = "<nombre>";
            labelNombreLieuxValeur.Click += labelNombreLieuxValeurs_Click;
            // 
            // labelNombreLieux
            // 
            labelNombreLieux.AutoSize = true;
            labelNombreLieux.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreLieux.Location = new Point(34, 155);
            labelNombreLieux.Name = "labelNombreLieux";
            labelNombreLieux.Size = new Size(34, 19);
            labelNombreLieux.TabIndex = 1;
            labelNombreLieux.Text = "Nb: ";
            // 
            // buttonLieux
            // 
            buttonLieux.BackgroundImage = (Image)resources.GetObject("buttonLieux.BackgroundImage");
            buttonLieux.FlatStyle = FlatStyle.Popup;
            buttonLieux.Location = new Point(49, 42);
            buttonLieux.Name = "buttonLieux";
            buttonLieux.Size = new Size(106, 88);
            buttonLieux.TabIndex = 0;
            buttonLieux.UseVisualStyleBackColor = true;
            buttonLieux.Click += buttonLieux_Click;
            // 
            // groupBoxEvenements
            // 
            groupBoxEvenements.BackColor = SystemColors.ControlLight;
            groupBoxEvenements.Controls.Add(labelNombreEvenementsValeur);
            groupBoxEvenements.Controls.Add(labelNombreEvenements);
            groupBoxEvenements.Controls.Add(buttonEvenements);
            groupBoxEvenements.FlatStyle = FlatStyle.Popup;
            groupBoxEvenements.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxEvenements.Location = new Point(336, 378);
            groupBoxEvenements.Name = "groupBoxEvenements";
            groupBoxEvenements.Size = new Size(200, 200);
            groupBoxEvenements.TabIndex = 6;
            groupBoxEvenements.TabStop = false;
            groupBoxEvenements.Text = "Événements";
            groupBoxEvenements.Enter += groupBox1_Enter_1;
            // 
            // labelNombreEvenementsValeur
            // 
            labelNombreEvenementsValeur.AutoSize = true;
            labelNombreEvenementsValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreEvenementsValeur.Location = new Point(78, 155);
            labelNombreEvenementsValeur.Name = "labelNombreEvenementsValeur";
            labelNombreEvenementsValeur.Size = new Size(77, 19);
            labelNombreEvenementsValeur.TabIndex = 3;
            labelNombreEvenementsValeur.Text = "<nombre>";
            // 
            // labelNombreEvenements
            // 
            labelNombreEvenements.AutoSize = true;
            labelNombreEvenements.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreEvenements.Location = new Point(39, 155);
            labelNombreEvenements.Name = "labelNombreEvenements";
            labelNombreEvenements.Size = new Size(34, 19);
            labelNombreEvenements.TabIndex = 1;
            labelNombreEvenements.Text = "Nb: ";
            // 
            // buttonEvenements
            // 
            buttonEvenements.BackgroundImage = (Image)resources.GetObject("buttonEvenements.BackgroundImage");
            buttonEvenements.FlatStyle = FlatStyle.Popup;
            buttonEvenements.Location = new Point(39, 42);
            buttonEvenements.Name = "buttonEvenements";
            buttonEvenements.Size = new Size(106, 102);
            buttonEvenements.TabIndex = 0;
            buttonEvenements.UseVisualStyleBackColor = true;
            // 
            // groupBoxLacunes
            // 
            groupBoxLacunes.BackColor = SystemColors.ControlLight;
            groupBoxLacunes.Controls.Add(labelNombreLacunesValeur);
            groupBoxLacunes.Controls.Add(labelNombreLacunes);
            groupBoxLacunes.Controls.Add(buttonLacunes);
            groupBoxLacunes.FlatStyle = FlatStyle.Popup;
            groupBoxLacunes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxLacunes.Location = new Point(611, 72);
            groupBoxLacunes.Name = "groupBoxLacunes";
            groupBoxLacunes.Size = new Size(200, 200);
            groupBoxLacunes.TabIndex = 7;
            groupBoxLacunes.TabStop = false;
            groupBoxLacunes.Text = "Lacunes";
            // 
            // labelNombreLacunesValeur
            // 
            labelNombreLacunesValeur.AutoSize = true;
            labelNombreLacunesValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreLacunesValeur.Location = new Point(87, 149);
            labelNombreLacunesValeur.Name = "labelNombreLacunesValeur";
            labelNombreLacunesValeur.Size = new Size(77, 19);
            labelNombreLacunesValeur.TabIndex = 3;
            labelNombreLacunesValeur.Text = "<nombre>";
            // 
            // labelNombreLacunes
            // 
            labelNombreLacunes.AutoSize = true;
            labelNombreLacunes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreLacunes.Location = new Point(48, 149);
            labelNombreLacunes.Name = "labelNombreLacunes";
            labelNombreLacunes.Size = new Size(34, 19);
            labelNombreLacunes.TabIndex = 1;
            labelNombreLacunes.Text = "Nb: ";
            // 
            // buttonLacunes
            // 
            buttonLacunes.BackgroundImage = (Image)resources.GetObject("buttonLacunes.BackgroundImage");
            buttonLacunes.FlatStyle = FlatStyle.Popup;
            buttonLacunes.Location = new Point(48, 36);
            buttonLacunes.Name = "buttonLacunes";
            buttonLacunes.Size = new Size(106, 102);
            buttonLacunes.TabIndex = 0;
            buttonLacunes.UseVisualStyleBackColor = true;
            buttonLacunes.Click += buttonLacunes_Click;
            // 
            // groupBoxReglages
            // 
            groupBoxReglages.BackColor = SystemColors.ControlLight;
            groupBoxReglages.Controls.Add(buttonReglages);
            groupBoxReglages.FlatStyle = FlatStyle.Popup;
            groupBoxReglages.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxReglages.Location = new Point(611, 378);
            groupBoxReglages.Name = "groupBoxReglages";
            groupBoxReglages.Size = new Size(200, 200);
            groupBoxReglages.TabIndex = 8;
            groupBoxReglages.TabStop = false;
            groupBoxReglages.Text = "Réglages";
            // 
            // buttonReglages
            // 
            buttonReglages.BackgroundImage = (Image)resources.GetObject("buttonReglages.BackgroundImage");
            buttonReglages.FlatStyle = FlatStyle.Popup;
            buttonReglages.Location = new Point(48, 59);
            buttonReglages.Name = "buttonReglages";
            buttonReglages.Size = new Size(106, 102);
            buttonReglages.TabIndex = 0;
            buttonReglages.UseVisualStyleBackColor = true;
            buttonReglages.Click += buttonReglages_Click;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(860, 653);
            Controls.Add(groupBoxReglages);
            Controls.Add(groupBoxLacunes);
            Controls.Add(groupBoxEvenements);
            Controls.Add(groupBoxLieux);
            Controls.Add(groupBoxPersonnes);
            Controls.Add(groupBoxMedias);
            Controls.Add(linkLabelQuitter);
            Controls.Add(linkLabelAccueil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Accueil";
            Text = "Accueil Archives St-Marcel";
            Load += Accueil_Load;
            groupBoxMedias.ResumeLayout(false);
            groupBoxMedias.PerformLayout();
            groupBoxPersonnes.ResumeLayout(false);
            groupBoxPersonnes.PerformLayout();
            groupBoxLieux.ResumeLayout(false);
            groupBoxLieux.PerformLayout();
            groupBoxEvenements.ResumeLayout(false);
            groupBoxEvenements.PerformLayout();
            groupBoxLacunes.ResumeLayout(false);
            groupBoxLacunes.PerformLayout();
            groupBoxReglages.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabelAccueil;
        private LinkLabel linkLabelQuitter;
        private GroupBox groupBoxMedias;
        private Button buttonMedias;
        private Label labelNombreMedias;
        private Label labelNombreMediasValeur;
        private GroupBox groupBoxPersonnes;
        private Label labelNombrePersonnesValeur;
        private Label labelNombrePersonnes;
        private Button buttonPersonnes;
        private Label labelNombreLieuxValeur;
        private Label labelNombreLieux;
        private Button buttonLieux;
        private GroupBox groupBoxEvenements;
        private Label labelNombreEvenementsValeur;
        private Label labelNombreEvenements;
        private Button buttonEvenements;
        private GroupBox groupBoxLacunes;
        private GroupBox groupBoxLieux;
        private Label labelNombreLacunesValeur;
        private Label labelNombreLacunes;
        private Button buttonLacunes;
        private GroupBox groupBoxReglages;
        private Button buttonReglages;
    }
}