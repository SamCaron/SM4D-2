namespace SM4D_2
{
    partial class SelectionLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionLieu));
            textBoxFiltres = new TextBox();
            labelFiltres = new Label();
            listBoxLieux = new ListBox();
            buttonSelection = new Button();
            buttonAnnuler = new Button();
            labelLieuCourant = new Label();
            SuspendLayout();
            // 
            // textBoxFiltres
            // 
            textBoxFiltres.Location = new Point(60, 31);
            textBoxFiltres.Name = "textBoxFiltres";
            textBoxFiltres.Size = new Size(207, 23);
            textBoxFiltres.TabIndex = 0;
            textBoxFiltres.TextChanged += textBoxFiltres_TextChanged;
            // 
            // labelFiltres
            // 
            labelFiltres.AutoSize = true;
            labelFiltres.Location = new Point(13, 38);
            labelFiltres.Name = "labelFiltres";
            labelFiltres.Size = new Size(44, 15);
            labelFiltres.TabIndex = 1;
            labelFiltres.Text = "Filtres :";
            // 
            // listBoxLieux
            // 
            listBoxLieux.FormattingEnabled = true;
            listBoxLieux.ItemHeight = 15;
            listBoxLieux.Location = new Point(16, 61);
            listBoxLieux.Name = "listBoxLieux";
            listBoxLieux.Size = new Size(251, 169);
            listBoxLieux.TabIndex = 2;
            listBoxLieux.MouseClick += listBoxLieux_SelectedIndexChanged;
            listBoxLieux.SelectedIndexChanged += listBoxLieux_SelectedIndexChanged;
            // 
            // buttonSelection
            // 
            buttonSelection.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelection.Location = new Point(16, 239);
            buttonSelection.Name = "buttonSelection";
            buttonSelection.Size = new Size(80, 36);
            buttonSelection.TabIndex = 19;
            buttonSelection.Text = "Sélection";
            buttonSelection.UseVisualStyleBackColor = true;
            buttonSelection.Click += buttonSelection_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAnnuler.Location = new Point(152, 239);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(80, 36);
            buttonAnnuler.TabIndex = 20;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // labelLieuCourant
            // 
            labelLieuCourant.AutoSize = true;
            labelLieuCourant.Location = new Point(16, 11);
            labelLieuCourant.Name = "labelLieuCourant";
            labelLieuCourant.Size = new Size(86, 15);
            labelLieuCourant.TabIndex = 21;
            labelLieuCourant.Text = "<lieu courant>";
            // 
            // SelectionLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 285);
            Controls.Add(labelLieuCourant);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonSelection);
            Controls.Add(listBoxLieux);
            Controls.Add(labelFiltres);
            Controls.Add(textBoxFiltres);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectionLieu";
            Text = "Sélection Lieu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFiltres;
        private Label labelFiltres;
        private ListBox listBoxLieux;
        private Button buttonSelection;
        private Button buttonAnnuler;
        private Label labelLieuCourant;
    }
}