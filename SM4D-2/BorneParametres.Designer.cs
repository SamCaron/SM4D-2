namespace SM4D_2
{
    partial class BorneParametres
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
            labelEmplacement = new Label();
            linkLabelEmplacement = new LinkLabel();
            labelTypeInstallation = new Label();
            comboBoxTypeInstallation = new ComboBox();
            buttonDomaines = new Button();
            linkLabelGererDomaines = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelEmplacement
            // 
            labelEmplacement.AutoSize = true;
            labelEmplacement.Location = new Point(30, 85);
            labelEmplacement.Name = "labelEmplacement";
            labelEmplacement.Size = new Size(147, 15);
            labelEmplacement.TabIndex = 0;
            labelEmplacement.Text = "Emplacement des archives";
            labelEmplacement.Click += label1_Click;
            // 
            // linkLabelEmplacement
            // 
            linkLabelEmplacement.AutoSize = true;
            linkLabelEmplacement.Location = new Point(187, 84);
            linkLabelEmplacement.Name = "linkLabelEmplacement";
            linkLabelEmplacement.Size = new Size(127, 15);
            linkLabelEmplacement.TabIndex = 1;
            linkLabelEmplacement.TabStop = true;
            linkLabelEmplacement.Text = "linkLabelEmplacement";
            linkLabelEmplacement.LinkClicked += linkLabelEmplacement_LinkClicked;
            // 
            // labelTypeInstallation
            // 
            labelTypeInstallation.AutoSize = true;
            labelTypeInstallation.Location = new Point(30, 133);
            labelTypeInstallation.Name = "labelTypeInstallation";
            labelTypeInstallation.Size = new Size(102, 15);
            labelTypeInstallation.TabIndex = 2;
            labelTypeInstallation.Text = "Type d'installation";
            // 
            // comboBoxTypeInstallation
            // 
            comboBoxTypeInstallation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTypeInstallation.FormattingEnabled = true;
            comboBoxTypeInstallation.Location = new Point(187, 123);
            comboBoxTypeInstallation.Name = "comboBoxTypeInstallation";
            comboBoxTypeInstallation.Size = new Size(217, 25);
            comboBoxTypeInstallation.TabIndex = 6;
            comboBoxTypeInstallation.Text = "<type Installation>";
            // 
            // buttonDomaines
            // 
            buttonDomaines.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDomaines.Location = new Point(30, 399);
            buttonDomaines.Name = "buttonDomaines";
            buttonDomaines.Size = new Size(136, 26);
            buttonDomaines.TabIndex = 62;
            buttonDomaines.Text = "Enregistrer";
            buttonDomaines.UseVisualStyleBackColor = true;
            buttonDomaines.Click += buttonDomaines_Click;
            // 
            // linkLabelGererDomaines
            // 
            linkLabelGererDomaines.AutoSize = true;
            linkLabelGererDomaines.Location = new Point(30, 46);
            linkLabelGererDomaines.Name = "linkLabelGererDomaines";
            linkLabelGererDomaines.Size = new Size(163, 15);
            linkLabelGererDomaines.TabIndex = 63;
            linkLabelGererDomaines.TabStop = true;
            linkLabelGererDomaines.Text = "Gérer les domaines de valeurs";
            linkLabelGererDomaines.LinkClicked += linkLabelGererDomaines_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(251, 399);
            button1.Name = "button1";
            button1.Size = new Size(136, 26);
            button1.TabIndex = 64;
            button1.Text = "Annuler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BorneParametres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(linkLabelGererDomaines);
            Controls.Add(buttonDomaines);
            Controls.Add(comboBoxTypeInstallation);
            Controls.Add(labelTypeInstallation);
            Controls.Add(linkLabelEmplacement);
            Controls.Add(labelEmplacement);
            Name = "BorneParametres";
            Text = "Parametres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmplacement;
        private LinkLabel linkLabelEmplacement;
        private Label labelTypeInstallation;
        private ComboBox comboBoxTypeInstallation;
        private Button buttonDomaines;
        private LinkLabel linkLabelGererDomaines;
        private Button button1;
    }
}