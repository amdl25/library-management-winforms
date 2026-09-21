namespace LibraryManager
{
    partial class FilesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cititorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarPaginiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprumutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restituireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cititoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cititoriDataSet1 = new LibraryManager.CititoriDataSet1();
            this.tbDrag = new System.Windows.Forms.TextBox();
            this.cititoriTableAdapter = new LibraryManager.CititoriDataSet1TableAdapters.CititoriTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descarcatxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcatxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.descarcaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cititorDataGridViewTextBoxColumn,
            this.carteDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.numarPaginiDataGridViewTextBoxColumn,
            this.imprumutDataGridViewTextBoxColumn,
            this.restituireDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cititoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // cititorDataGridViewTextBoxColumn
            // 
            this.cititorDataGridViewTextBoxColumn.DataPropertyName = "Cititor";
            this.cititorDataGridViewTextBoxColumn.HeaderText = "Cititor";
            this.cititorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cititorDataGridViewTextBoxColumn.Name = "cititorDataGridViewTextBoxColumn";
            this.cititorDataGridViewTextBoxColumn.ReadOnly = true;
            this.cititorDataGridViewTextBoxColumn.Width = 150;
            // 
            // carteDataGridViewTextBoxColumn
            // 
            this.carteDataGridViewTextBoxColumn.DataPropertyName = "Carte";
            this.carteDataGridViewTextBoxColumn.HeaderText = "Carte";
            this.carteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carteDataGridViewTextBoxColumn.Name = "carteDataGridViewTextBoxColumn";
            this.carteDataGridViewTextBoxColumn.ReadOnly = true;
            this.carteDataGridViewTextBoxColumn.Width = 150;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Width = 150;
            // 
            // numarPaginiDataGridViewTextBoxColumn
            // 
            this.numarPaginiDataGridViewTextBoxColumn.DataPropertyName = "NumarPagini";
            this.numarPaginiDataGridViewTextBoxColumn.HeaderText = "NumarPagini";
            this.numarPaginiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numarPaginiDataGridViewTextBoxColumn.Name = "numarPaginiDataGridViewTextBoxColumn";
            this.numarPaginiDataGridViewTextBoxColumn.ReadOnly = true;
            this.numarPaginiDataGridViewTextBoxColumn.Width = 150;
            // 
            // imprumutDataGridViewTextBoxColumn
            // 
            this.imprumutDataGridViewTextBoxColumn.DataPropertyName = "Imprumut";
            this.imprumutDataGridViewTextBoxColumn.HeaderText = "Imprumut";
            this.imprumutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.imprumutDataGridViewTextBoxColumn.Name = "imprumutDataGridViewTextBoxColumn";
            this.imprumutDataGridViewTextBoxColumn.ReadOnly = true;
            this.imprumutDataGridViewTextBoxColumn.Width = 150;
            // 
            // restituireDataGridViewTextBoxColumn
            // 
            this.restituireDataGridViewTextBoxColumn.DataPropertyName = "Restituire";
            this.restituireDataGridViewTextBoxColumn.HeaderText = "Restituire";
            this.restituireDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.restituireDataGridViewTextBoxColumn.Name = "restituireDataGridViewTextBoxColumn";
            this.restituireDataGridViewTextBoxColumn.ReadOnly = true;
            this.restituireDataGridViewTextBoxColumn.Width = 150;
            // 
            // cititoriBindingSource
            // 
            this.cititoriBindingSource.DataMember = "Cititori";
            this.cititoriBindingSource.DataSource = this.cititoriDataSet1;
            // 
            // cititoriDataSet1
            // 
            this.cititoriDataSet1.DataSetName = "CititoriDataSet1";
            this.cititoriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDrag
            // 
            this.tbDrag.AllowDrop = true;
            this.tbDrag.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbDrag.Location = new System.Drawing.Point(263, 327);
            this.tbDrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDrag.Multiline = true;
            this.tbDrag.Name = "tbDrag";
            this.tbDrag.Size = new System.Drawing.Size(568, 279);
            this.tbDrag.TabIndex = 1;
            this.tbDrag.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbDrag_DragDrop);
            this.tbDrag.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbDrag_DragEnter);
            this.tbDrag.DragOver += new System.Windows.Forms.DragEventHandler(this.tbDrag_DragOver);
            this.tbDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbDrag_MouseDown);
            this.tbDrag.MouseEnter += new System.EventHandler(this.tbDrag_MouseEnter);
            // 
            // cititoriTableAdapter
            // 
            this.cititoriTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1240, 46);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descarcatxtToolStripMenuItem,
            this.incarcatxtToolStripMenuItem,
            this.printToolStripMenuItem,
            this.descarcaXMLToolStripMenuItem,
            this.incarcaXMLToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(111, 42);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            this.fisiereToolStripMenuItem.Click += new System.EventHandler(this.fisiereToolStripMenuItem_Click);
            // 
            // descarcatxtToolStripMenuItem
            // 
            this.descarcatxtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("descarcatxtToolStripMenuItem.Image")));
            this.descarcatxtToolStripMenuItem.Name = "descarcatxtToolStripMenuItem";
            this.descarcatxtToolStripMenuItem.Size = new System.Drawing.Size(286, 42);
            this.descarcatxtToolStripMenuItem.Text = "Descarca .txt";
            this.descarcatxtToolStripMenuItem.Click += new System.EventHandler(this.descarcatxtToolStripMenuItem_Click);
            // 
            // incarcatxtToolStripMenuItem
            // 
            this.incarcatxtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("incarcatxtToolStripMenuItem.Image")));
            this.incarcatxtToolStripMenuItem.Name = "incarcatxtToolStripMenuItem";
            this.incarcatxtToolStripMenuItem.Size = new System.Drawing.Size(268, 42);
            this.incarcatxtToolStripMenuItem.Text = "Incarca .txt";
            this.incarcatxtToolStripMenuItem.Click += new System.EventHandler(this.incarcatxtToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(268, 42);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrint.Location = new System.Drawing.Point(712, 556);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 50);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            this.printPreviewDialog1.Paint += new System.Windows.Forms.PaintEventHandler(this.printPreviewDialog1_Paint);
            // 
            // descarcaXMLToolStripMenuItem
            // 
            this.descarcaXMLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("descarcaXMLToolStripMenuItem.Image")));
            this.descarcaXMLToolStripMenuItem.Name = "descarcaXMLToolStripMenuItem";
            this.descarcaXMLToolStripMenuItem.Size = new System.Drawing.Size(286, 42);
            this.descarcaXMLToolStripMenuItem.Text = "Descarca XML";
            this.descarcaXMLToolStripMenuItem.Click += new System.EventHandler(this.descarcaXMLToolStripMenuItem_Click);
            // 
            // incarcaXMLToolStripMenuItem
            // 
            this.incarcaXMLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("incarcaXMLToolStripMenuItem.Image")));
            this.incarcaXMLToolStripMenuItem.Name = "incarcaXMLToolStripMenuItem";
            this.incarcaXMLToolStripMenuItem.Size = new System.Drawing.Size(286, 42);
            this.incarcaXMLToolStripMenuItem.Text = "Incarca XML";
            this.incarcaXMLToolStripMenuItem.Click += new System.EventHandler(this.incarcaXMLToolStripMenuItem_Click);
            // 
            // FilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::LibraryManager.Properties.Resources.secondary_forms_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 645);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tbDrag);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFisiere";
            this.Text = "ExtragereListaCititori";
            this.Load += new System.EventHandler(this.ExtragereListaCititori_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormFisiere_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbDrag;
        private CititoriDataSet1 cititoriDataSet1;
        private System.Windows.Forms.BindingSource cititoriBindingSource;
        private CititoriDataSet1TableAdapters.CititoriTableAdapter cititoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cititorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarPaginiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imprumutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restituireDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descarcatxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcatxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem descarcaXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaXMLToolStripMenuItem;
    }
}