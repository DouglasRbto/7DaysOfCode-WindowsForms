namespace CatAsService.View
{
    partial class frmFindBreed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindBreed));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBreed = new ComboBox();
            label4 = new Label();
            lblOrigin = new Label();
            label5 = new Label();
            lblTemperament = new Label();
            label6 = new Label();
            lblDescription = new Label();
            btnSearch = new Button();
            btnFavorite = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-6, -8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 61);
            label2.Name = "label2";
            label2.Size = new Size(467, 25);
            label2.TabIndex = 1;
            label2.Text = "Use the cat breed selection box to check its characteristics";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 19);
            label1.Name = "label1";
            label1.Size = new Size(333, 32);
            label1.TabIndex = 0;
            label1.Text = "Find Your Favourite Breed";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 110);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 1;
            label3.Text = "Cat Breed:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBreed
            // 
            comboBreed.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBreed.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBreed.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBreed.FormattingEnabled = true;
            comboBreed.Location = new Point(31, 131);
            comboBreed.Name = "comboBreed";
            comboBreed.Size = new Size(248, 23);
            comboBreed.TabIndex = 2;
            comboBreed.Text = "Select a Cat Breed";
            comboBreed.SelectedIndexChanged += comboRaca_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 156);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 1;
            label4.Text = "Origin:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOrigin
            // 
            lblOrigin.BackColor = SystemColors.ButtonHighlight;
            lblOrigin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrigin.Location = new Point(31, 177);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(248, 19);
            lblOrigin.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 198);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(106, 19);
            label5.TabIndex = 1;
            label5.Text = "Temperament:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTemperament
            // 
            lblTemperament.BackColor = SystemColors.ButtonHighlight;
            lblTemperament.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTemperament.Location = new Point(31, 219);
            lblTemperament.Name = "lblTemperament";
            lblTemperament.Size = new Size(248, 89);
            lblTemperament.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(305, 110);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(89, 19);
            label6.TabIndex = 1;
            label6.Text = "Description:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = SystemColors.ButtonHighlight;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(305, 131);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(248, 178);
            lblDescription.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(179, 325);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 24);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFavorite
            // 
            btnFavorite.Location = new Point(305, 325);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(100, 24);
            btnFavorite.TabIndex = 3;
            btnFavorite.Text = "Favorite";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // frmFindBreed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(btnFavorite);
            Controls.Add(btnSearch);
            Controls.Add(comboBreed);
            Controls.Add(lblDescription);
            Controls.Add(lblTemperament);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblOrigin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmFindBreed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find Cat Breeds";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBreed;
        private Label label4;
        private Label lblOrigin;
        private Label label5;
        private Label lblTemperament;
        private Label label6;
        private Label lblDescription;
        private Button btnSearch;
        private Button btnFavorite;
    }
}