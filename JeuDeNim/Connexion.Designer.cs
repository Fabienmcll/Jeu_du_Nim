namespace JeuDeNim
{
    partial class Connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnConnexion = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            txtPseudoConnexion = new TextBox();
            txtMotDePasseConnexion = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 0;
            label1.Text = "Jeu de Nim - Connexion";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConnexion
            // 
            btnConnexion.Anchor = AnchorStyles.Top;
            btnConnexion.Location = new Point(355, 163);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(202, 32);
            btnConnexion.TabIndex = 1;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnConnexion, 1, 3);
            tableLayoutPanel1.Controls.Add(button2, 1, 4);
            tableLayoutPanel1.Controls.Add(txtPseudoConnexion, 1, 1);
            tableLayoutPanel1.Controls.Add(txtMotDePasseConnexion, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(914, 600);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(355, 203);
            button2.Name = "button2";
            button2.Size = new Size(202, 32);
            button2.TabIndex = 2;
            button2.Text = "Créer un compte";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtPseudoConnexion
            // 
            txtPseudoConnexion.Anchor = AnchorStyles.Top;
            txtPseudoConnexion.Location = new Point(355, 83);
            txtPseudoConnexion.Name = "txtPseudoConnexion";
            txtPseudoConnexion.Size = new Size(202, 27);
            txtPseudoConnexion.TabIndex = 3;
            // 
            // txtMotDePasseConnexion
            // 
            txtMotDePasseConnexion.Anchor = AnchorStyles.Top;
            txtMotDePasseConnexion.Location = new Point(355, 123);
            txtMotDePasseConnexion.Name = "txtMotDePasseConnexion";
            txtMotDePasseConnexion.Size = new Size(202, 27);
            txtMotDePasseConnexion.TabIndex = 4;
            txtMotDePasseConnexion.UseSystemPasswordChar = true;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Connexion";
            Text = "Jeu de Nim - Connexion";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnConnexion;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private TextBox txtPseudoConnexion;
        private TextBox txtMotDePasseConnexion;
    }
}
