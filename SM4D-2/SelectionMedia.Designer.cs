namespace SM4D_2
{
    partial class SelectionMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionMedia));
            labelSelection = new Label();
            buttonPrevious = new Button();
            buttonNext = new Button();
            groupBoxFiltres = new GroupBox();
            comboBoxSujets = new ComboBox();
            dateTimePickerA = new DateTimePicker();
            dateTimePickerDe = new DateTimePicker();
            labelA = new Label();
            labelDe = new Label();
            textBoxTexte = new TextBox();
            pictureBoxSelection = new PictureBox();
            tableLayoutPanelMedias = new TableLayoutPanel();
            buttonAnnuler = new Button();
            buttonSelection = new Button();
            labelPage = new Label();
            groupBoxFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelection).BeginInit();
            SuspendLayout();
            // 
            // labelSelection
            // 
            labelSelection.AutoSize = true;
            labelSelection.Location = new Point(16, 502);
            labelSelection.Name = "labelSelection";
            labelSelection.Size = new Size(84, 15);
            labelSelection.TabIndex = 11;
            labelSelection.Text = "<nom média>";
            // 
            // buttonPrevious
            // 
            buttonPrevious.Location = new Point(12, 115);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(16, 256);
            buttonPrevious.TabIndex = 10;
            buttonPrevious.Text = "<";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(286, 117);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(19, 254);
            buttonNext.TabIndex = 9;
            buttonNext.Text = ">";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // groupBoxFiltres
            // 
            groupBoxFiltres.Controls.Add(comboBoxSujets);
            groupBoxFiltres.Controls.Add(dateTimePickerA);
            groupBoxFiltres.Controls.Add(dateTimePickerDe);
            groupBoxFiltres.Controls.Add(labelA);
            groupBoxFiltres.Controls.Add(labelDe);
            groupBoxFiltres.Controls.Add(textBoxTexte);
            groupBoxFiltres.Location = new Point(12, 10);
            groupBoxFiltres.Name = "groupBoxFiltres";
            groupBoxFiltres.Size = new Size(294, 99);
            groupBoxFiltres.TabIndex = 8;
            groupBoxFiltres.TabStop = false;
            groupBoxFiltres.Text = "Filtres";
            // 
            // comboBoxSujets
            // 
            comboBoxSujets.FormattingEnabled = true;
            comboBoxSujets.Location = new Point(9, 67);
            comboBoxSujets.Name = "comboBoxSujets";
            comboBoxSujets.Size = new Size(279, 23);
            comboBoxSujets.TabIndex = 30;
            comboBoxSujets.Text = "Sujet";
            comboBoxSujets.SelectedIndexChanged += comboBoxSujets_SelectedIndexChanged;
            // 
            // dateTimePickerA
            // 
            dateTimePickerA.Format = DateTimePickerFormat.Custom;
            dateTimePickerA.Location = new Point(39, 40);
            dateTimePickerA.Name = "dateTimePickerA";
            dateTimePickerA.Size = new Size(49, 23);
            dateTimePickerA.TabIndex = 29;
            dateTimePickerA.ValueChanged += dateTimePickerA_ValueChanged;
            // 
            // dateTimePickerDe
            // 
            dateTimePickerDe.Format = DateTimePickerFormat.Custom;
            dateTimePickerDe.Location = new Point(39, 14);
            dateTimePickerDe.Name = "dateTimePickerDe";
            dateTimePickerDe.Size = new Size(49, 23);
            dateTimePickerDe.TabIndex = 28;
            dateTimePickerDe.ValueChanged += dateTimePickerDe_ValueChanged;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(7, 40);
            labelA.Name = "labelA";
            labelA.Size = new Size(15, 15);
            labelA.TabIndex = 25;
            labelA.Text = "A";
            // 
            // labelDe
            // 
            labelDe.AutoSize = true;
            labelDe.Location = new Point(6, 18);
            labelDe.Name = "labelDe";
            labelDe.Size = new Size(21, 15);
            labelDe.TabIndex = 24;
            labelDe.Text = "De";
            // 
            // textBoxTexte
            // 
            textBoxTexte.Location = new Point(112, 14);
            textBoxTexte.Multiline = true;
            textBoxTexte.Name = "textBoxTexte";
            textBoxTexte.PlaceholderText = "Texte";
            textBoxTexte.Size = new Size(176, 49);
            textBoxTexte.TabIndex = 0;
            textBoxTexte.TextChanged += textBoxTexte_TextChanged;
            // 
            // pictureBoxSelection
            // 
            pictureBoxSelection.Location = new Point(12, 391);
            pictureBoxSelection.Name = "pictureBoxSelection";
            pictureBoxSelection.Size = new Size(100, 100);
            pictureBoxSelection.TabIndex = 7;
            pictureBoxSelection.TabStop = false;
            pictureBoxSelection.Click += pictureBoxSelection_Click;
            // 
            // tableLayoutPanelMedias
            // 
            tableLayoutPanelMedias.ColumnCount = 5;
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanelMedias.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanelMedias.Location = new Point(32, 115);
            tableLayoutPanelMedias.Name = "tableLayoutPanelMedias";
            tableLayoutPanelMedias.RowCount = 5;
            tableLayoutPanelMedias.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelMedias.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelMedias.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelMedias.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelMedias.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelMedias.Size = new Size(249, 256);
            tableLayoutPanelMedias.TabIndex = 6;
            tableLayoutPanelMedias.Click += pictureBoxSelection_Click;
            tableLayoutPanelMedias.Paint += tableLayoutPanelMedias_Paint;
            tableLayoutPanelMedias.DoubleClick += pictureBoxSelection_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAnnuler.Location = new Point(231, 420);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(80, 36);
            buttonAnnuler.TabIndex = 22;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonSelection
            // 
            buttonSelection.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelection.Location = new Point(124, 420);
            buttonSelection.Name = "buttonSelection";
            buttonSelection.Size = new Size(96, 36);
            buttonSelection.TabIndex = 21;
            buttonSelection.Text = "<- Sélection";
            buttonSelection.UseVisualStyleBackColor = true;
            buttonSelection.Click += buttonSelection_Click;
            // 
            // labelPage
            // 
            labelPage.AutoSize = true;
            labelPage.Location = new Point(106, 376);
            labelPage.Name = "labelPage";
            labelPage.Size = new Size(105, 15);
            labelPage.TabIndex = 23;
            labelPage.Text = "< page courante >";
            // 
            // SelectionMedia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 527);
            Controls.Add(labelPage);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonSelection);
            Controls.Add(labelSelection);
            Controls.Add(buttonPrevious);
            Controls.Add(buttonNext);
            Controls.Add(groupBoxFiltres);
            Controls.Add(pictureBoxSelection);
            Controls.Add(tableLayoutPanelMedias);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectionMedia";
            Text = "Sélection d'un Média";
            groupBoxFiltres.ResumeLayout(false);
            groupBoxFiltres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelection).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSelection;
        private Button buttonPrevious;
        private Button buttonNext;
        private GroupBox groupBoxFiltres;
        private TextBox textBoxTexte;
        private PictureBox pictureBoxSelection;
        private TableLayoutPanel tableLayoutPanelMedias;
        private Button buttonAnnuler;
        private Button buttonSelection;
        private Label labelPage;
        private ComboBox comboBoxSujets;
        private DateTimePicker dateTimePickerA;
        private DateTimePicker dateTimePickerDe;
        private Label labelA;
        private Label labelDe;
    }
}