namespace SM4D_2
{
    partial class GererDomaineValeurs
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GererDomaineValeurs));
            comboBoxDomaine = new ComboBox();
            labelDomaine = new Label();
            textBoxCode = new TextBox();
            labelCode = new Label();
            labelValeur = new Label();
            textBoxValeur = new TextBox();
            buttonAjouterRester = new Button();
            buttonSupprimer = new Button();
            listBoxDomaineValeurs = new ListBox();
            domaineValeursBindingSource = new BindingSource(components);
            linkLabelQuitter = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)domaineValeursBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxDomaine
            // 
            comboBoxDomaine.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDomaine.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDomaine.FormattingEnabled = true;
            comboBoxDomaine.Location = new Point(95, 15);
            comboBoxDomaine.Name = "comboBoxDomaine";
            comboBoxDomaine.Size = new Size(217, 25);
            comboBoxDomaine.TabIndex = 29;
            comboBoxDomaine.UseWaitCursor = true;
            comboBoxDomaine.SelectedIndexChanged += comboBoxDomaine_SelectedIndexChanged;
            // 
            // labelDomaine
            // 
            labelDomaine.AutoSize = true;
            labelDomaine.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDomaine.Location = new Point(13, 21);
            labelDomaine.Margin = new Padding(4, 0, 4, 0);
            labelDomaine.Name = "labelDomaine";
            labelDomaine.Size = new Size(64, 19);
            labelDomaine.TabIndex = 28;
            labelDomaine.Text = "Domaine";
            labelDomaine.UseWaitCursor = true;
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(79, 61);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(99, 23);
            textBoxCode.TabIndex = 32;
            textBoxCode.UseWaitCursor = true;
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCode.Location = new Point(13, 61);
            labelCode.Margin = new Padding(4, 0, 4, 0);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(52, 19);
            labelCode.TabIndex = 31;
            labelCode.Text = "Code  :";
            labelCode.UseWaitCursor = true;
            // 
            // labelValeur
            // 
            labelValeur.AutoSize = true;
            labelValeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelValeur.Location = new Point(200, 61);
            labelValeur.Margin = new Padding(4, 0, 4, 0);
            labelValeur.Name = "labelValeur";
            labelValeur.Size = new Size(58, 19);
            labelValeur.TabIndex = 33;
            labelValeur.Text = "Valeur  :";
            labelValeur.UseWaitCursor = true;
            // 
            // textBoxValeur
            // 
            textBoxValeur.Location = new Point(282, 57);
            textBoxValeur.Name = "textBoxValeur";
            textBoxValeur.Size = new Size(374, 23);
            textBoxValeur.TabIndex = 34;
            textBoxValeur.UseWaitCursor = true;
            // 
            // buttonAjouterRester
            // 
            buttonAjouterRester.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouterRester.Location = new Point(702, 51);
            buttonAjouterRester.Name = "buttonAjouterRester";
            buttonAjouterRester.Size = new Size(127, 34);
            buttonAjouterRester.TabIndex = 37;
            buttonAjouterRester.Text = "Enregistrer";
            buttonAjouterRester.UseVisualStyleBackColor = true;
            buttonAjouterRester.UseWaitCursor = true;
            buttonAjouterRester.Click += buttonAjouterRester_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimer.Location = new Point(702, 178);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(126, 36);
            buttonSupprimer.TabIndex = 36;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.UseWaitCursor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // listBoxDomaineValeurs
            // 
            listBoxDomaineValeurs.DataSource = domaineValeursBindingSource;
            listBoxDomaineValeurs.FormattingEnabled = true;
            listBoxDomaineValeurs.ItemHeight = 15;
            listBoxDomaineValeurs.Location = new Point(79, 105);
            listBoxDomaineValeurs.Name = "listBoxDomaineValeurs";
            listBoxDomaineValeurs.Size = new Size(577, 334);
            listBoxDomaineValeurs.TabIndex = 39;
            listBoxDomaineValeurs.UseWaitCursor = true;
            listBoxDomaineValeurs.SelectedIndexChanged += listBoxDomaineValeurs_SelectedIndexChanged;
            // 
            // domaineValeursBindingSource
            // 
            domaineValeursBindingSource.DataSource = typeof(SM4D2Librairie.Modeles.DomaineValeurs);
            // 
            // linkLabelQuitter
            // 
            linkLabelQuitter.AutoSize = true;
            linkLabelQuitter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelQuitter.Location = new Point(786, 9);
            linkLabelQuitter.Name = "linkLabelQuitter";
            linkLabelQuitter.Size = new Size(58, 25);
            linkLabelQuitter.TabIndex = 40;
            linkLabelQuitter.TabStop = true;
            linkLabelQuitter.Text = "Sortir";
            linkLabelQuitter.LinkClicked += linkLabelQuitter_LinkClicked;
            // 
            // GererDomaineValeurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 463);
            Controls.Add(linkLabelQuitter);
            Controls.Add(listBoxDomaineValeurs);
            Controls.Add(buttonAjouterRester);
            Controls.Add(buttonSupprimer);
            Controls.Add(textBoxValeur);
            Controls.Add(labelValeur);
            Controls.Add(textBoxCode);
            Controls.Add(labelCode);
            Controls.Add(comboBoxDomaine);
            Controls.Add(labelDomaine);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GererDomaineValeurs";
            Text = "Gerer un Domaine de Valeurs";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)domaineValeursBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDomaine;
        private Label labelDomaine;
        private TextBox textBoxCode;
        private Label labelCode;
        private Label labelValeur;
        private TextBox textBoxValeur;
        private Button buttonAjouterRester;
        private Button buttonSupprimer;
        private ListBox listBoxDomaineValeurs;
        private BindingSource domaineValeursBindingSource;
        private LinkLabel linkLabelQuitter;
    }
}