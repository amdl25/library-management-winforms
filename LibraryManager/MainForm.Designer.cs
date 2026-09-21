namespace LibraryManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cititorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControlNume1 = new LibraryManager.NameUserControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cititorToolStripMenuItem,
            this.fisiereToolStripMenuItem,
            this.graficeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(886, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cititorToolStripMenuItem
            // 
            this.cititorToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cititorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.vizualizareToolStripMenuItem1});
            this.cititorToolStripMenuItem.Name = "cititorToolStripMenuItem";
            this.cititorToolStripMenuItem.Size = new System.Drawing.Size(106, 42);
            this.cititorToolStripMenuItem.Text = "Cititor";
            this.cititorToolStripMenuItem.Click += new System.EventHandler(this.cititorToolStripMenuItem_Click);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adaugaToolStripMenuItem.Image")));
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(245, 42);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click_1);
            // 
            // vizualizareToolStripMenuItem1
            // 
            this.vizualizareToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("vizualizareToolStripMenuItem1.Image")));
            this.vizualizareToolStripMenuItem1.Name = "vizualizareToolStripMenuItem1";
            this.vizualizareToolStripMenuItem1.Size = new System.Drawing.Size(245, 42);
            this.vizualizareToolStripMenuItem1.Text = "Vizualizare";
            this.vizualizareToolStripMenuItem1.Click += new System.EventHandler(this.vizualizareToolStripMenuItem1_Click);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(176, 42);
            this.fisiereToolStripMenuItem.Text = "Lista Cititori";
            this.fisiereToolStripMenuItem.Click += new System.EventHandler(this.fisiereToolStripMenuItem_Click);
            // 
            // graficeToolStripMenuItem
            // 
            this.graficeToolStripMenuItem.Name = "graficeToolStripMenuItem";
            this.graficeToolStripMenuItem.Size = new System.Drawing.Size(118, 42);
            this.graficeToolStripMenuItem.Text = "Grafice";
            this.graficeToolStripMenuItem.Click += new System.EventHandler(this.graficeToolStripMenuItem_Click);
            // 
            // userControlNume1
            // 
            this.userControlNume1.BackColor = System.Drawing.Color.Transparent;
            this.userControlNume1.Location = new System.Drawing.Point(94, 467);
            this.userControlNume1.Name = "userControlNume1";
            this.userControlNume1.Size = new System.Drawing.Size(709, 62);
            this.userControlNume1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManager.Properties.Resources.main_form_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 532);
            this.Controls.Add(this.userControlNume1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPrincipal_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cititorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem1;
        private NameUserControl userControlNume1;
    }
}

