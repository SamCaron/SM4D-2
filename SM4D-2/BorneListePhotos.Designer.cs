namespace SM4D_2
{
    partial class BorneListePhotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorneListePhotos));
            comboBoxSens = new ComboBox();
            comboBoxLieux = new ComboBox();
            comboBoxTri = new ComboBox();
            labelTri = new Label();
            dateTimePickerA = new DateTimePicker();
            labelA = new Label();
            dateTimePickerDe = new DateTimePicker();
            labelDe = new Label();
            comboBoxCollections = new ComboBox();
            comboBoxSujets = new ComboBox();
            textBoxTexte = new TextBox();
            buttonDernierePage = new Button();
            buttonPrecedent = new Button();
            buttonSuivant = new Button();
            tableLayoutPanelMedias = new TableLayoutPanel();
            buttonDebut = new Button();
            labelNombreMedias = new Label();
            buttonAjouter = new Button();
            SuspendLayout();
            // 
            // comboBoxSens
            // 
            comboBoxSens.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSens.FormattingEnabled = true;
            comboBoxSens.Items.AddRange(new object[] { "Ascendant", "Descendant" });
            comboBoxSens.Location = new Point(747, 34);
            comboBoxSens.Name = "comboBoxSens";
            comboBoxSens.Size = new Size(102, 23);
            comboBoxSens.TabIndex = 48;
            comboBoxSens.SelectedValueChanged += textBoxTexte_FiltresChanges;
            // 
            // comboBoxLieux
            // 
            comboBoxLieux.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLieux.FormattingEnabled = true;
            comboBoxLieux.Location = new Point(448, 34);
            comboBoxLieux.Name = "comboBoxLieux";
            comboBoxLieux.Size = new Size(254, 23);
            comboBoxLieux.TabIndex = 47;
            comboBoxLieux.SelectedValueChanged += textBoxTexte_FiltresChanges;
            // 
            // comboBoxTri
            // 
            comboBoxTri.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTri.FormattingEnabled = true;
            comboBoxTri.Location = new Point(747, 8);
            comboBoxTri.Name = "comboBoxTri";
            comboBoxTri.Size = new Size(118, 23);
            comboBoxTri.TabIndex = 46;
            comboBoxTri.SelectedValueChanged += textBoxTexte_FiltresChanges;
            // 
            // labelTri
            // 
            labelTri.AutoSize = true;
            labelTri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTri.Location = new Point(694, 11);
            labelTri.Name = "labelTri";
            labelTri.Size = new Size(45, 15);
            labelTri.TabIndex = 45;
            labelTri.Text = "Tri par ";
            // 
            // dateTimePickerA
            // 
            dateTimePickerA.Format = DateTimePickerFormat.Custom;
            dateTimePickerA.Location = new Point(105, 35);
            dateTimePickerA.Name = "dateTimePickerA";
            dateTimePickerA.Size = new Size(49, 23);
            dateTimePickerA.TabIndex = 44;
            dateTimePickerA.ValueChanged += textBoxTexte_FiltresChanges;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(89, 38);
            labelA.Name = "labelA";
            labelA.Size = new Size(13, 15);
            labelA.TabIndex = 43;
            labelA.Text = "à";
            // 
            // dateTimePickerDe
            // 
            dateTimePickerDe.Format = DateTimePickerFormat.Custom;
            dateTimePickerDe.Location = new Point(33, 35);
            dateTimePickerDe.Name = "dateTimePickerDe";
            dateTimePickerDe.Size = new Size(49, 23);
            dateTimePickerDe.TabIndex = 42;
            dateTimePickerDe.Value = new DateTime(1800, 5, 18, 12, 51, 0, 0);
            dateTimePickerDe.ValueChanged += textBoxTexte_FiltresChanges;
            // 
            // labelDe
            // 
            labelDe.AutoSize = true;
            labelDe.Location = new Point(10, 39);
            labelDe.Name = "labelDe";
            labelDe.Size = new Size(21, 15);
            labelDe.TabIndex = 41;
            labelDe.Text = "De";
            // 
            // comboBoxCollections
            // 
            comboBoxCollections.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCollections.FormattingEnabled = true;
            comboBoxCollections.Location = new Point(174, 34);
            comboBoxCollections.Name = "comboBoxCollections";
            comboBoxCollections.Size = new Size(263, 23);
            comboBoxCollections.TabIndex = 40;
            comboBoxCollections.SelectedValueChanged += textBoxTexte_FiltresChanges;
            // 
            // comboBoxSujets
            // 
            comboBoxSujets.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSujets.FormattingEnabled = true;
            comboBoxSujets.Location = new Point(211, 7);
            comboBoxSujets.Name = "comboBoxSujets";
            comboBoxSujets.Size = new Size(329, 23);
            comboBoxSujets.TabIndex = 39;
            comboBoxSujets.SelectedValueChanged += textBoxTexte_FiltresChanges;
            // 
            // textBoxTexte
            // 
            textBoxTexte.Location = new Point(10, 7);
            textBoxTexte.Name = "textBoxTexte";
            textBoxTexte.PlaceholderText = "Texte recherché";
            textBoxTexte.Size = new Size(195, 23);
            textBoxTexte.TabIndex = 38;
            textBoxTexte.TextChanged += textBoxTexte_FiltresChanges;
            // 
            // buttonDernierePage
            // 
            buttonDernierePage.Image = (Image)resources.GetObject("buttonDernierePage.Image");
            buttonDernierePage.Location = new Point(541, 625);
            buttonDernierePage.Name = "buttonDernierePage";
            buttonDernierePage.Size = new Size(41, 31);
            buttonDernierePage.TabIndex = 54;
            buttonDernierePage.UseVisualStyleBackColor = true;
            buttonDernierePage.Click += buttonDernierePage_Click_1;
            // 
            // buttonPrecedent
            // 
            buttonPrecedent.Image = (Image)resources.GetObject("buttonPrecedent.Image");
            buttonPrecedent.Location = new Point(442, 625);
            buttonPrecedent.Name = "buttonPrecedent";
            buttonPrecedent.Size = new Size(41, 31);
            buttonPrecedent.TabIndex = 53;
            buttonPrecedent.UseVisualStyleBackColor = true;
            buttonPrecedent.Click += buttonPrecedent_Click_1;
            // 
            // buttonSuivant
            // 
            buttonSuivant.Image = (Image)resources.GetObject("buttonSuivant.Image");
            buttonSuivant.Location = new Point(494, 625);
            buttonSuivant.Name = "buttonSuivant";
            buttonSuivant.Size = new Size(41, 31);
            buttonSuivant.TabIndex = 52;
            buttonSuivant.UseVisualStyleBackColor = true;
            buttonSuivant.Click += buttonSuivant_Click_1;
            // 
            // tableLayoutPanelMedias
            // 
            tableLayoutPanelMedias.ColumnCount = 6;
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanelMedias.Location = new Point(21, 62);
            tableLayoutPanelMedias.MinimumSize = new Size(845, 562);
            tableLayoutPanelMedias.Name = "tableLayoutPanelMedias";
            tableLayoutPanelMedias.RowCount = 4;
            tableLayoutPanelMedias.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanelMedias.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanelMedias.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanelMedias.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanelMedias.Size = new Size(845, 562);
            tableLayoutPanelMedias.TabIndex = 49;
            // 
            // buttonDebut
            // 
            buttonDebut.AccessibleName = "Première Page";
            buttonDebut.Image = Properties.Resources.Pagination_Premier;
            buttonDebut.Location = new Point(395, 625);
            buttonDebut.Name = "buttonDebut";
            buttonDebut.Size = new Size(41, 31);
            buttonDebut.TabIndex = 51;
            buttonDebut.UseVisualStyleBackColor = true;
            buttonDebut.Click += buttonDebut_Click;
            // 
            // labelNombreMedias
            // 
            labelNombreMedias.AutoSize = true;
            labelNombreMedias.Location = new Point(91, 633);
            labelNombreMedias.Name = "labelNombreMedias";
            labelNombreMedias.Size = new Size(108, 15);
            labelNombreMedias.TabIndex = 50;
            labelNombreMedias.Text = "Page <n> de <nn>";
            labelNombreMedias.Click += labelNombreMedias_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouter.Location = new Point(734, 630);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(132, 26);
            buttonAjouter.TabIndex = 61;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // BorneListePhotos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 661);
            Controls.Add(buttonAjouter);
            Controls.Add(buttonDernierePage);
            Controls.Add(buttonPrecedent);
            Controls.Add(buttonSuivant);
            Controls.Add(tableLayoutPanelMedias);
            Controls.Add(buttonDebut);
            Controls.Add(labelNombreMedias);
            Controls.Add(comboBoxSens);
            Controls.Add(comboBoxLieux);
            Controls.Add(comboBoxTri);
            Controls.Add(labelTri);
            Controls.Add(dateTimePickerA);
            Controls.Add(labelA);
            Controls.Add(dateTimePickerDe);
            Controls.Add(labelDe);
            Controls.Add(comboBoxCollections);
            Controls.Add(comboBoxSujets);
            Controls.Add(textBoxTexte);
            Name = "BorneListePhotos";
            Text = "BorneListePhotos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSens;
        private ComboBox comboBoxLieux;
        private ComboBox comboBoxTri;
        private Label labelTri;
        private DateTimePicker dateTimePickerA;
        private Label labelA;
        private DateTimePicker dateTimePickerDe;
        private Label labelDe;
        private ComboBox comboBoxCollections;
        private ComboBox comboBoxSujets;
        private TextBox textBoxTexte;
        private Button buttonDernierePage;
        private Button buttonPrecedent;
        private Button buttonSuivant;
        private TableLayoutPanel tableLayoutPanelMedias;
        private Button buttonDebut;
        private Label labelNombreMedias;
        private Button buttonAjouter;
    }
}