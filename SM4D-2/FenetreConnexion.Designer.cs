namespace SM4D_2
{
    partial class FenetreConnexion
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
            label1 = new Label();
            txtbPrenom = new TextBox();
            lblNom = new Label();
            txtbNom = new TextBox();
            lblPrenom = new Label();
            txtbDetails = new RichTextBox();
            lblDetails = new Label();
            btnEnregistrer = new Button();
            btnRecommencer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 0;
            label1.Text = "Identifiez-vous pour commenter";
            // 
            // txtbPrenom
            // 
            txtbPrenom.Location = new Point(246, 104);
            txtbPrenom.Name = "txtbPrenom";
            txtbPrenom.Size = new Size(342, 27);
            txtbPrenom.TabIndex = 2;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(179, 150);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(42, 20);
            lblNom.TabIndex = 3;
            lblNom.Text = "Nom";
            // 
            // txtbNom
            // 
            txtbNom.Location = new Point(246, 150);
            txtbNom.Name = "txtbNom";
            txtbNom.Size = new Size(342, 27);
            txtbNom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(179, 107);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(60, 20);
            lblPrenom.TabIndex = 5;
            lblPrenom.Text = "Prénom";
            // 
            // txtbDetails
            // 
            txtbDetails.Location = new Point(246, 206);
            txtbDetails.Name = "txtbDetails";
            txtbDetails.Size = new Size(342, 120);
            txtbDetails.TabIndex = 6;
            txtbDetails.Text = "";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(171, 206);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(55, 20);
            lblDetails.TabIndex = 7;
            lblDetails.Text = "Détails";
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Location = new Point(494, 360);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(94, 29);
            btnEnregistrer.TabIndex = 8;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // btnRecommencer
            // 
            btnRecommencer.Location = new Point(374, 360);
            btnRecommencer.Name = "btnRecommencer";
            btnRecommencer.Size = new Size(114, 29);
            btnRecommencer.TabIndex = 9;
            btnRecommencer.Text = "Recommencer";
            btnRecommencer.UseVisualStyleBackColor = true;
            btnRecommencer.Click += btnRecommencer_Click;
            // 
            // FenetreConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecommencer);
            Controls.Add(btnEnregistrer);
            Controls.Add(lblDetails);
            Controls.Add(txtbDetails);
            Controls.Add(lblPrenom);
            Controls.Add(txtbNom);
            Controls.Add(lblNom);
            Controls.Add(txtbPrenom);
            Controls.Add(label1);
            Name = "FenetreConnexion";
            Text = "FenetreConnexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbPrenom;
        private Label lblNom;
        private TextBox txtbNom;
        private Label lblPrenom;
        private RichTextBox txtbDetails;
        private Label lblDetails;
        private Button btnEnregistrer;
        private Button btnRecommencer;
    }
}