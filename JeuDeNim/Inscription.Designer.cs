namespace JeuDeNim
{
    partial class Inscriptioncs
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            txtPseudoInscription = new TextBox();
            txtNomInscription = new TextBox();
            txtPrenomInscription = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtMdpInscription = new TextBox();
            label3 = new Label();
            Nom = new Label();
            label5 = new Label();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 23);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 0;
            label1.Text = "Jeu du Nim - Inscription";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPseudoInscription, 1, 1);
            tableLayoutPanel1.Controls.Add(txtNomInscription, 1, 2);
            tableLayoutPanel1.Controls.Add(txtPrenomInscription, 1, 3);
            tableLayoutPanel1.Controls.Add(button1, 1, 6);
            tableLayoutPanel1.Controls.Add(txtMdpInscription, 1, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(Nom, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(button2, 1, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.Size = new Size(1045, 664);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(410, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 25);
            label2.TabIndex = 0;
            label2.Text = "Jeu de Nim - Inscription";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPseudoInscription
            // 
            txtPseudoInscription.Anchor = AnchorStyles.None;
            txtPseudoInscription.Location = new Point(421, 86);
            txtPseudoInscription.Name = "txtPseudoInscription";
            txtPseudoInscription.Size = new Size(202, 27);
            txtPseudoInscription.TabIndex = 3;
            // 
            // txtNomInscription
            // 
            txtNomInscription.Anchor = AnchorStyles.None;
            txtNomInscription.Location = new Point(421, 126);
            txtNomInscription.Name = "txtNomInscription";
            txtNomInscription.Size = new Size(202, 27);
            txtNomInscription.TabIndex = 4;
            // 
            // txtPrenomInscription
            // 
            txtPrenomInscription.Anchor = AnchorStyles.None;
            txtPrenomInscription.Location = new Point(421, 166);
            txtPrenomInscription.Name = "txtPrenomInscription";
            txtPrenomInscription.Size = new Size(202, 27);
            txtPrenomInscription.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(421, 243);
            button1.Name = "button1";
            button1.Size = new Size(202, 31);
            button1.TabIndex = 1;
            button1.Text = "Inscription";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(421, 367);
            button2.Name = "button2";
            button2.Size = new Size(202, 32);
            button2.TabIndex = 2;
            button2.Text = "Se connecter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtMdpInscription
            // 
            txtMdpInscription.Anchor = AnchorStyles.None;
            txtMdpInscription.Location = new Point(421, 206);
            txtMdpInscription.Name = "txtMdpInscription";
            txtMdpInscription.Size = new Size(202, 27);
            txtMdpInscription.TabIndex = 6;
            txtMdpInscription.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(347, 90);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "Pseudo";
            // 
            // Nom
            // 
            Nom.Anchor = AnchorStyles.Right;
            Nom.AutoSize = true;
            Nom.Location = new Point(362, 130);
            Nom.Name = "Nom";
            Nom.Size = new Size(42, 20);
            Nom.TabIndex = 8;
            Nom.Text = "Nom";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(344, 170);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "Prénom";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(306, 210);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 10;
            label6.Text = "Mot de passe";
            // 
            // Inscriptioncs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 664);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inscriptioncs";
            Text = "Jeu de Nim - Inscription";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox txtPseudoInscription;
        private TextBox txtNomInscription;
        private TextBox txtPrenomInscription;
        private Button button1;
        private Button button2;
        private TextBox txtMdpInscription;
        private Label label3;
        private Label Nom;
        private Label label5;
        private Label label6;
    }
}