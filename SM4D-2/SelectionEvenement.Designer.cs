namespace SM4D_2
{
    partial class SelectionEvenement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionEvenement));
            labelEvenementCourant = new Label();
            buttonAnnuler = new Button();
            buttonSelection = new Button();
            listBoxEvenements = new ListBox();
            labelFiltres = new Label();
            textBoxFiltres = new TextBox();
            SuspendLayout();
            // 
            // labelEvenementCourant
            // 
            labelEvenementCourant.AutoSize = true;
            labelEvenementCourant.Location = new Point(12, 18);
            labelEvenementCourant.Name = "labelEvenementCourant";
            labelEvenementCourant.Size = new Size(126, 15);
            labelEvenementCourant.TabIndex = 27;
            labelEvenementCourant.Text = "<événement courant>";
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAnnuler.Location = new Point(148, 191);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(80, 36);
            buttonAnnuler.TabIndex = 26;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonSelection
            // 
            buttonSelection.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelection.Location = new Point(12, 191);
            buttonSelection.Name = "buttonSelection";
            buttonSelection.Size = new Size(80, 36);
            buttonSelection.TabIndex = 25;
            buttonSelection.Text = "Sélection";
            buttonSelection.UseVisualStyleBackColor = true;
            buttonSelection.Click += buttonSelection_Click;
            // 
            // listBoxEvenements
            // 
            listBoxEvenements.FormattingEnabled = true;
            listBoxEvenements.ItemHeight = 15;
            listBoxEvenements.Location = new Point(12, 79);
            listBoxEvenements.Name = "listBoxEvenements";
            listBoxEvenements.Size = new Size(216, 94);
            listBoxEvenements.TabIndex = 24;
            listBoxEvenements.MouseClick += listBoxEvenements_MouseClick;
            // 
            // labelFiltres
            // 
            labelFiltres.AutoSize = true;
            labelFiltres.Location = new Point(9, 55);
            labelFiltres.Name = "labelFiltres";
            labelFiltres.Size = new Size(41, 15);
            labelFiltres.TabIndex = 23;
            labelFiltres.Text = "Fltres :";
            // 
            // textBoxFiltres
            // 
            textBoxFiltres.Location = new Point(56, 48);
            textBoxFiltres.Name = "textBoxFiltres";
            textBoxFiltres.Size = new Size(172, 23);
            textBoxFiltres.TabIndex = 22;
            textBoxFiltres.TextChanged += textBoxFiltres_TextChanged;
            // 
            // SelectionEvenement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 243);
            Controls.Add(labelEvenementCourant);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonSelection);
            Controls.Add(listBoxEvenements);
            Controls.Add(labelFiltres);
            Controls.Add(textBoxFiltres);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectionEvenement";
            Text = "Sélection Événement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEvenementCourant;
        private Button buttonAnnuler;
        private Button buttonSelection;
        private ListBox listBoxEvenements;
        private Label labelFiltres;
        private TextBox textBoxFiltres;
    }
}