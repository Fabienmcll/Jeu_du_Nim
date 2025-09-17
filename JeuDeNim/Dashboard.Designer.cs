namespace JeuDeNim
{
    partial class Dashboard
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
            label2 = new Label();
            btnDeconnexion = new Button();
            btnMonCompte = new Button();
            txbxCode = new TextBox();
            label1 = new Label();
            btnRejoindre = new Button();
            btnCreer = new Button();
            lblConnecte = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(btnDeconnexion, 2, 9);
            tableLayoutPanel1.Controls.Add(btnMonCompte, 0, 9);
            tableLayoutPanel1.Controls.Add(txbxCode, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(btnRejoindre, 1, 3);
            tableLayoutPanel1.Controls.Add(btnCreer, 1, 6);
            tableLayoutPanel1.Controls.Add(lblConnecte, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(914, 504);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 25);
            label2.TabIndex = 0;
            label2.Text = "Jeu de Nim - Dashboard";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Anchor = AnchorStyles.Right;
            btnDeconnexion.BackColor = Color.Red;
            btnDeconnexion.ForeColor = SystemColors.ButtonFace;
            btnDeconnexion.Location = new Point(780, 455);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(131, 38);
            btnDeconnexion.TabIndex = 1;
            btnDeconnexion.Text = "Deconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            // 
            // btnMonCompte
            // 
            btnMonCompte.Anchor = AnchorStyles.Left;
            btnMonCompte.BackColor = Color.DarkCyan;
            btnMonCompte.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMonCompte.ForeColor = SystemColors.ButtonFace;
            btnMonCompte.Location = new Point(3, 455);
            btnMonCompte.Name = "btnMonCompte";
            btnMonCompte.Size = new Size(131, 38);
            btnMonCompte.TabIndex = 2;
            btnMonCompte.Text = "Mon compte";
            btnMonCompte.UseVisualStyleBackColor = false;
            // 
            // txbxCode
            // 
            txbxCode.Location = new Point(344, 123);
            txbxCode.Name = "txbxCode";
            txbxCode.Size = new Size(226, 27);
            txbxCode.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(380, 90);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 4;
            label1.Text = "Rejoindre une partie";
            // 
            // btnRejoindre
            // 
            btnRejoindre.Anchor = AnchorStyles.None;
            btnRejoindre.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRejoindre.Location = new Point(406, 164);
            btnRejoindre.Name = "btnRejoindre";
            btnRejoindre.Size = new Size(101, 31);
            btnRejoindre.TabIndex = 6;
            btnRejoindre.Text = "Rejoindre";
            btnRejoindre.UseVisualStyleBackColor = true;
            // 
            // btnCreer
            // 
            btnCreer.Anchor = AnchorStyles.None;
            btnCreer.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreer.Location = new Point(375, 243);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(163, 31);
            btnCreer.TabIndex = 7;
            btnCreer.Text = "Créer une partie";
            btnCreer.UseVisualStyleBackColor = true;
            // 
            // lblConnecte
            // 
            lblConnecte.AutoSize = true;
            lblConnecte.Location = new Point(3, 0);
            lblConnecte.Name = "lblConnecte";
            lblConnecte.Size = new Size(15, 20);
            lblConnecte.TabIndex = 8;
            lblConnecte.Text = "-";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 504);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Text = "Jeu du Nim - Dashboard";
            Load += Dashboard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button btnDeconnexion;
        private Button btnMonCompte;
        private TextBox txbxCode;
        private Label label1;
        private Button btnRejoindre;
        private Button btnCreer;
        private Label lblConnecte;
    }
}