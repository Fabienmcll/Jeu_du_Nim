namespace JeuDeNim
{
    partial class FrmPartie
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            btnDeconnexion = new Button();
            btnMonCompte = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            listBox1 = new ListBox();
            btnRetour = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
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
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(listBox1, 1, 6);
            tableLayoutPanel1.Controls.Add(btnRetour, 0, 8);
            tableLayoutPanel1.Controls.Add(button1, 1, 8);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(914, 441);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(325, 0);
            label2.Name = "label2";
            label2.Size = new Size(263, 25);
            label2.TabIndex = 0;
            label2.Text = "Jeu de Nim - Création partie";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Anchor = AnchorStyles.Right;
            btnDeconnexion.BackColor = Color.Red;
            btnDeconnexion.ForeColor = SystemColors.ButtonFace;
            btnDeconnexion.Location = new Point(780, 448);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(131, 34);
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
            btnMonCompte.Location = new Point(3, 448);
            btnMonCompte.Name = "btnMonCompte";
            btnMonCompte.Size = new Size(131, 34);
            btnMonCompte.TabIndex = 2;
            btnMonCompte.Text = "Mon compte";
            btnMonCompte.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(369, 88);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 3;
            label1.Text = "Code d'invitation";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(325, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 27);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Rubik", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(368, 208);
            label3.Name = "label3";
            label3.Size = new Size(176, 23);
            label3.TabIndex = 5;
            label3.Text = "Liste des joueurs";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(325, 243);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(263, 124);
            listBox1.TabIndex = 6;
            // 
            // btnRetour
            // 
            btnRetour.Anchor = AnchorStyles.Left;
            btnRetour.BackColor = Color.DarkGoldenrod;
            btnRetour.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetour.ForeColor = SystemColors.ButtonFace;
            btnRetour.Location = new Point(3, 393);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(131, 38);
            btnRetour.TabIndex = 7;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(391, 393);
            button1.Name = "button1";
            button1.Size = new Size(131, 38);
            button1.TabIndex = 8;
            button1.Text = "Lancer la partie";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmPartie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 441);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPartie";
            Text = "Créer une partie";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button btnDeconnexion;
        private Button btnMonCompte;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private ListBox listBox1;
        private Button btnRetour;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}