namespace SM4D_2
{
    partial class SelectionPersonne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionPersonne));
            labelPersonneCourante = new Label();
            buttonAnnuler = new Button();
            buttonSelection = new Button();
            listBoxPersonnes = new ListBox();
            labelFiltres = new Label();
            textBoxFiltres = new TextBox();
            pictureBoxPhotoProfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhotoProfil).BeginInit();
            SuspendLayout();
            // 
            // labelPersonneCourante
            // 
            labelPersonneCourante.AutoSize = true;
            labelPersonneCourante.Location = new Point(12, 9);
            labelPersonneCourante.Name = "labelPersonneCourante";
            labelPersonneCourante.Size = new Size(122, 15);
            labelPersonneCourante.TabIndex = 33;
            labelPersonneCourante.Text = "<personne courante>";
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAnnuler.Location = new Point(148, 264);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(80, 36);
            buttonAnnuler.TabIndex = 32;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click_1;
            // 
            // buttonSelection
            // 
            buttonSelection.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelection.Location = new Point(12, 264);
            buttonSelection.Name = "buttonSelection";
            buttonSelection.Size = new Size(80, 36);
            buttonSelection.TabIndex = 31;
            buttonSelection.Text = "Sélection";
            buttonSelection.UseVisualStyleBackColor = true;
            buttonSelection.Click += buttonSelection_Click;
            // 
            // listBoxPersonnes
            // 
            listBoxPersonnes.FormattingEnabled = true;
            listBoxPersonnes.ItemHeight = 15;
            listBoxPersonnes.Location = new Point(12, 112);
            listBoxPersonnes.Name = "listBoxPersonnes";
            listBoxPersonnes.Size = new Size(224, 139);
            listBoxPersonnes.TabIndex = 30;
            listBoxPersonnes.MouseClick += listBoxPersonnes_MouseClick;
            listBoxPersonnes.SelectedIndexChanged += listBoxPersonnes_SelectedIndexChanged;
            listBoxPersonnes.SelectedValueChanged += listBoxPersonnes_SelectedIndexChanged;
            // 
            // labelFiltres
            // 
            labelFiltres.AutoSize = true;
            labelFiltres.Location = new Point(12, 91);
            labelFiltres.Name = "labelFiltres";
            labelFiltres.Size = new Size(44, 15);
            labelFiltres.TabIndex = 29;
            labelFiltres.Text = "Filtres :";
            // 
            // textBoxFiltres
            // 
            textBoxFiltres.Location = new Point(60, 83);
            textBoxFiltres.Name = "textBoxFiltres";
            textBoxFiltres.Size = new Size(174, 23);
            textBoxFiltres.TabIndex = 28;
            textBoxFiltres.TextChanged += textBoxFiltres_TextChanged;
            // 
            // pictureBoxPhotoProfil
            // 
            pictureBoxPhotoProfil.Location = new Point(12, 27);
            pictureBoxPhotoProfil.Name = "pictureBoxPhotoProfil";
            pictureBoxPhotoProfil.Size = new Size(50, 50);
            pictureBoxPhotoProfil.TabIndex = 34;
            pictureBoxPhotoProfil.TabStop = false;
            // 
            // SelectionPersonne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 312);
            Controls.Add(pictureBoxPhotoProfil);
            Controls.Add(labelPersonneCourante);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonSelection);
            Controls.Add(listBoxPersonnes);
            Controls.Add(labelFiltres);
            Controls.Add(textBoxFiltres);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectionPersonne";
            Text = "Sélection de Personne";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhotoProfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPersonneCourante;
        private Button buttonAnnuler;
        private Button buttonSelection;
        private ListBox listBoxPersonnes;
        private Label labelFiltres;
        private TextBox textBoxFiltres;
        private PictureBox pictureBoxPhotoProfil;
    }
}