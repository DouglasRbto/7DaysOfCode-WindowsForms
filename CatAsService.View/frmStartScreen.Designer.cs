namespace CatAsService.View
{
    partial class frmStartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartScreen));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            btnBuscarRacas = new ToolStripMenuItem();
            btnFavoritos = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 304);
            label1.Name = "label1";
            label1.Size = new Size(452, 41);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Cat As Service!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnBuscarRacas, btnFavoritos });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnBuscarRacas
            // 
            btnBuscarRacas.Name = "btnBuscarRacas";
            btnBuscarRacas.Size = new Size(96, 20);
            btnBuscarRacas.Text = "Find Cat Breed";
            btnBuscarRacas.Click += btnBuscarRacas_Click;
            // 
            // btnFavoritos
            // 
            btnFavoritos.Name = "btnFavoritos";
            btnFavoritos.Size = new Size(66, 20);
            btnFavoritos.Text = "Favorites";
            btnFavoritos.Click += btnFavoritos_Click;
            // 
            // frmStartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmStartScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to Cat As Service";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnBuscarRacas;
        private ToolStripMenuItem btnFavoritos;
    }
}