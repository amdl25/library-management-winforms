namespace LibraryManager
{
    partial class ViewForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cititorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarPaginiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprumutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restituireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cititoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cititoriDataSet2 = new LibraryManager.CititoriDataSet2();
            this.cititoriTableAdapter = new LibraryManager.CititoriDataSet2TableAdapters.CititoriTableAdapter();
            this.tbAfisareBazaDate = new System.Windows.Forms.TextBox();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.descarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
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
            this.dataGridView1.Location = new System.Drawing.Point(91, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 240);
            this.dataGridView1.TabIndex = 0;
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
            this.cititoriBindingSource.DataSource = this.cititoriDataSet2;
            // 
            // cititoriDataSet2
            // 
            this.cititoriDataSet2.DataSetName = "CititoriDataSet2";
            this.cititoriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cititoriTableAdapter
            // 
            this.cititoriTableAdapter.ClearBeforeFill = true;
            // 
            // tbAfisareBazaDate
            // 
            this.tbAfisareBazaDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbAfisareBazaDate.Location = new System.Drawing.Point(300, 314);
            this.tbAfisareBazaDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAfisareBazaDate.Multiline = true;
            this.tbAfisareBazaDate.Name = "tbAfisareBazaDate";
            this.tbAfisareBazaDate.Size = new System.Drawing.Size(610, 341);
            this.tbAfisareBazaDate.TabIndex = 2;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(824, 609);
            this.btnAfisare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(86, 46);
            this.btnAfisare.TabIndex = 3;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descarcaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1359, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // descarcaToolStripMenuItem
            // 
            this.descarcaToolStripMenuItem.Name = "descarcaToolStripMenuItem";
            this.descarcaToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.descarcaToolStripMenuItem.Text = "Descarca";
            this.descarcaToolStripMenuItem.Click += new System.EventHandler(this.descarcaToolStripMenuItem_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::LibraryManager.Properties.Resources.secondary_forms_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1359, 740);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.tbAfisareBazaDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormVizualizare";
            this.Text = "FormVizualizare";
            this.Load += new System.EventHandler(this.FormVizualizare_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormVizualizare_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CititoriDataSet2 cititoriDataSet2;
        private System.Windows.Forms.BindingSource cititoriBindingSource;
        private CititoriDataSet2TableAdapters.CititoriTableAdapter cititoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cititorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarPaginiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imprumutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restituireDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbAfisareBazaDate;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem descarcaToolStripMenuItem;
    }
}