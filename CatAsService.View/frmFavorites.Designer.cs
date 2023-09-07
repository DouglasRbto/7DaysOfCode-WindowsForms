namespace CatAsService.View
{
    partial class frmFavorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFavorites));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btnRemoveFavorite = new Button();
            lboxFavorites = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-6, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 108);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(126, 61);
            label2.Name = "label2";
            label2.Size = new Size(345, 25);
            label2.TabIndex = 1;
            label2.Text = "Here you can find your favorite cat breeds";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(236, 19);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 0;
            label1.Text = "Favorites";
            // 
            // btnRemoveFavorite
            // 
            btnRemoveFavorite.Location = new Point(216, 324);
            btnRemoveFavorite.Name = "btnRemoveFavorite";
            btnRemoveFavorite.Size = new Size(152, 24);
            btnRemoveFavorite.TabIndex = 4;
            btnRemoveFavorite.Text = "Remove Favorite";
            btnRemoveFavorite.UseVisualStyleBackColor = true;
            btnRemoveFavorite.Click += btnRemoveFavorite_Click;
            // 
            // lboxFavorites
            // 
            lboxFavorites.FormattingEnabled = true;
            lboxFavorites.ItemHeight = 15;
            lboxFavorites.Location = new Point(64, 112);
            lboxFavorites.Name = "lboxFavorites";
            lboxFavorites.Size = new Size(456, 199);
            lboxFavorites.TabIndex = 5;
            // 
            // frmFavorites
            // 
            AcceptButton = btnRemoveFavorite;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(584, 361);
            Controls.Add(lboxFavorites);
            Controls.Add(btnRemoveFavorite);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmFavorites";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Favorites";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnRemoveFavorite;
        private ListBox lboxFavorites;
    }
}