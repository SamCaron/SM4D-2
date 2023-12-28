namespace SM4D_2
{
    partial class TestPhotos
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            groupBoxFiltres = new GroupBox();
            buttonNext = new Button();
            buttonPrevious = new Button();
            textBoxTexte = new TextBox();
            textBoxDate = new TextBox();
            textBoxSpan = new TextBox();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxFiltres.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Location = new Point(32, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(249, 256);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 356);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBoxFiltres
            // 
            groupBoxFiltres.Controls.Add(textBoxSpan);
            groupBoxFiltres.Controls.Add(textBoxDate);
            groupBoxFiltres.Controls.Add(textBoxTexte);
            groupBoxFiltres.Location = new Point(12, 5);
            groupBoxFiltres.Name = "groupBoxFiltres";
            groupBoxFiltres.Size = new Size(294, 72);
            groupBoxFiltres.TabIndex = 2;
            groupBoxFiltres.TabStop = false;
            groupBoxFiltres.Text = "Filtres";
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(286, 85);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(19, 254);
            buttonNext.TabIndex = 3;
            buttonNext.Text = ">";
            buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            buttonPrevious.Location = new Point(12, 83);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(16, 256);
            buttonPrevious.TabIndex = 4;
            buttonPrevious.Text = "<";
            buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // textBoxTexte
            // 
            textBoxTexte.Location = new Point(6, 15);
            textBoxTexte.Multiline = true;
            textBoxTexte.Name = "textBoxTexte";
            textBoxTexte.PlaceholderText = "Texte";
            textBoxTexte.Size = new Size(215, 52);
            textBoxTexte.TabIndex = 0;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(227, 15);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.PlaceholderText = "Année";
            textBoxDate.Size = new Size(61, 23);
            textBoxDate.TabIndex = 1;
            // 
            // textBoxSpan
            // 
            textBoxSpan.Location = new Point(227, 43);
            textBoxSpan.Name = "textBoxSpan";
            textBoxSpan.PlaceholderText = "+/- ans";
            textBoxSpan.Size = new Size(61, 23);
            textBoxSpan.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(16, 470);
            label.Name = "label";
            label.Size = new Size(84, 15);
            label.TabIndex = 5;
            label.Text = "<nom média>";
            // 
            // TestPhotos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 515);
            Controls.Add(label);
            Controls.Add(buttonPrevious);
            Controls.Add(buttonNext);
            Controls.Add(groupBoxFiltres);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "TestPhotos";
            Text = "TestPhotos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxFiltres.ResumeLayout(false);
            groupBoxFiltres.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private GroupBox groupBoxFiltres;
        private TextBox textBoxSpan;
        private TextBox textBoxDate;
        private TextBox textBoxTexte;
        private Button buttonNext;
        private Button buttonPrevious;
        private Label label;
    }
}