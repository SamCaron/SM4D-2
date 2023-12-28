namespace SM4D_2
{
    partial class BorneListeCollections
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
            dataGridViewCollections = new DataGridView();
            nomCollectionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contributeurDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            responsableDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Deployee = new DataGridViewCheckBoxColumn();
            collectionsBindingSource = new BindingSource(components);
            buttonSupprimer = new Button();
            buttonModifier = new Button();
            buttonAjouter = new Button();
            labelListeCollections = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollections).BeginInit();
            ((System.ComponentModel.ISupportInitialize)collectionsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCollections
            // 
            dataGridViewCollections.AllowUserToOrderColumns = true;
            dataGridViewCollections.AutoGenerateColumns = false;
            dataGridViewCollections.BackgroundColor = Color.Gainsboro;
            dataGridViewCollections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCollections.Columns.AddRange(new DataGridViewColumn[] { nomCollectionDataGridViewTextBoxColumn, contributeurDataGridViewTextBoxColumn, responsableDataGridViewTextBoxColumn, notesDataGridViewTextBoxColumn, Deployee });
            dataGridViewCollections.DataSource = collectionsBindingSource;
            dataGridViewCollections.Location = new Point(12, 51);
            dataGridViewCollections.Name = "dataGridViewCollections";
            dataGridViewCollections.ReadOnly = true;
            dataGridViewCollections.RowTemplate.Height = 50;
            dataGridViewCollections.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCollections.Size = new Size(766, 481);
            dataGridViewCollections.TabIndex = 68;
            dataGridViewCollections.CellContentClick += dataGridViewCollections_CellContentClick;
            dataGridViewCollections.SelectionChanged += dataGridViewCollections_SelectionChanged;
            // 
            // nomCollectionDataGridViewTextBoxColumn
            // 
            nomCollectionDataGridViewTextBoxColumn.DataPropertyName = "NomCollection";
            nomCollectionDataGridViewTextBoxColumn.HeaderText = "Collection";
            nomCollectionDataGridViewTextBoxColumn.Name = "nomCollectionDataGridViewTextBoxColumn";
            nomCollectionDataGridViewTextBoxColumn.ReadOnly = true;
            nomCollectionDataGridViewTextBoxColumn.Width = 140;
            // 
            // contributeurDataGridViewTextBoxColumn
            // 
            contributeurDataGridViewTextBoxColumn.DataPropertyName = "Contributeur";
            contributeurDataGridViewTextBoxColumn.HeaderText = "Contributeur";
            contributeurDataGridViewTextBoxColumn.Name = "contributeurDataGridViewTextBoxColumn";
            contributeurDataGridViewTextBoxColumn.ReadOnly = true;
            contributeurDataGridViewTextBoxColumn.Width = 140;
            // 
            // responsableDataGridViewTextBoxColumn
            // 
            responsableDataGridViewTextBoxColumn.DataPropertyName = "Responsable";
            responsableDataGridViewTextBoxColumn.HeaderText = "Responsable";
            responsableDataGridViewTextBoxColumn.Name = "responsableDataGridViewTextBoxColumn";
            responsableDataGridViewTextBoxColumn.ReadOnly = true;
            responsableDataGridViewTextBoxColumn.Width = 140;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            notesDataGridViewTextBoxColumn.ReadOnly = true;
            notesDataGridViewTextBoxColumn.Width = 210;
            // 
            // Deployee
            // 
            Deployee.DataPropertyName = "Deployee";
            Deployee.HeaderText = "Deployée";
            Deployee.Name = "Deployee";
            Deployee.ReadOnly = true;
            Deployee.Width = 60;
            // 
            // collectionsBindingSource
            // 
            collectionsBindingSource.DataSource = typeof(SM4D2Librairie.Modeles.Collections);
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimer.Location = new Point(784, 124);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(109, 46);
            buttonSupprimer.TabIndex = 70;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifier.Location = new Point(784, 51);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(109, 46);
            buttonModifier.TabIndex = 69;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouter.Location = new Point(784, 193);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(109, 46);
            buttonAjouter.TabIndex = 71;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // labelListeCollections
            // 
            labelListeCollections.AutoSize = true;
            labelListeCollections.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelListeCollections.Location = new Point(23, 9);
            labelListeCollections.Margin = new Padding(4, 0, 4, 0);
            labelListeCollections.Name = "labelListeCollections";
            labelListeCollections.Size = new Size(189, 25);
            labelListeCollections.TabIndex = 72;
            labelListeCollections.Text = "Liste des Collections";
            // 
            // BorneListeCollections
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 587);
            Controls.Add(labelListeCollections);
            Controls.Add(buttonAjouter);
            Controls.Add(buttonSupprimer);
            Controls.Add(buttonModifier);
            Controls.Add(dataGridViewCollections);
            Name = "BorneListeCollections";
            Text = "BorneListeCollections";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollections).EndInit();
            ((System.ComponentModel.ISupportInitialize)collectionsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewCollections;
        private Button buttonSupprimer;
        private Button buttonModifier;
        private Button buttonAjouter;
        private Label labelListeCollections;
        private BindingSource collectionsBindingSource;
        private DataGridViewTextBoxColumn nomCollectionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contributeurDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn responsableDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Deployee;
    }
}