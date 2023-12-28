namespace SM4D_2
{
    partial class SelectionSujet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionSujet));
            labelSujetCourant = new Label();
            buttonAnnuler = new Button();
            buttonSelection = new Button();
            listBoxSujets = new ListBox();
            textBoxFiltres = new TextBox();
            checkBoxDetailles = new CheckBox();
            SuspendLayout();
            // 
            // labelSujetCourant
            // 
            labelSujetCourant.AutoSize = true;
            labelSujetCourant.Location = new Point(12, 160);
            labelSujetCourant.Name = "labelSujetCourant";
            labelSujetCourant.Size = new Size(92, 15);
            labelSujetCourant.TabIndex = 27;
            labelSujetCourant.Text = "<sujet courant>";
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAnnuler.Location = new Point(148, 190);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(80, 36);
            buttonAnnuler.TabIndex = 26;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click_1;
            // 
            // buttonSelection
            // 
            buttonSelection.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelection.Location = new Point(12, 190);
            buttonSelection.Name = "buttonSelection";
            buttonSelection.Size = new Size(80, 36);
            buttonSelection.TabIndex = 25;
            buttonSelection.Text = "Sélection";
            buttonSelection.UseVisualStyleBackColor = true;
            buttonSelection.Click += buttonSelection_Click;
            // 
            // listBoxSujets
            // 
            listBoxSujets.FormattingEnabled = true;
            listBoxSujets.ItemHeight = 15;
            listBoxSujets.Location = new Point(12, 54);
            listBoxSujets.Name = "listBoxSujets";
            listBoxSujets.Size = new Size(216, 94);
            listBoxSujets.TabIndex = 24;
            listBoxSujets.Click += listBoxSujets_SelectedIndexChanged;
            listBoxSujets.SelectedIndexChanged += listBoxSujets_SelectedIndexChanged;
            // 
            // textBoxFiltres
            // 
            textBoxFiltres.Location = new Point(12, 25);
            textBoxFiltres.Name = "textBoxFiltres";
            textBoxFiltres.Size = new Size(140, 23);
            textBoxFiltres.TabIndex = 22;
            textBoxFiltres.Text = "Texte filtre";
            textBoxFiltres.TextChanged += textBoxFiltres_TextChanged;
            // 
            // checkBoxDetailles
            // 
            checkBoxDetailles.AutoSize = true;
            checkBoxDetailles.Location = new Point(158, 28);
            checkBoxDetailles.Name = "checkBoxDetailles";
            checkBoxDetailles.Size = new Size(70, 19);
            checkBoxDetailles.TabIndex = 28;
            checkBoxDetailles.Text = "Détaillés";
            checkBoxDetailles.UseVisualStyleBackColor = true;
            checkBoxDetailles.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SelectionSujet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 243);
            Controls.Add(checkBoxDetailles);
            Controls.Add(labelSujetCourant);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonSelection);
            Controls.Add(listBoxSujets);
            Controls.Add(textBoxFiltres);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectionSujet";
            Text = "Selection de Sujet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSujetCourant;
        private Button buttonAnnuler;
        private Button buttonSelection;
        private ListBox listBoxSujets;
        private TextBox textBoxFiltres;
        private CheckBox checkBoxDetailles;
    }
}