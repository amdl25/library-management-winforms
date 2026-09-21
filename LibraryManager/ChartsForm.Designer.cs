namespace LibraryManager
{
    partial class ChartsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnAnalizare = new System.Windows.Forms.Button();
            this.btnGenereazaGrafic = new System.Windows.Forms.Button();
            this.listBoxImpremuturi = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cititorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarPaginiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprumutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restituireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cititoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cititoriDataSet3 = new LibraryManager.CititoriDataSet3();
            this.cititoriTableAdapter = new LibraryManager.CititoriDataSet3TableAdapters.CititoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 34);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(580, 315);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // BtnAnalizare
            // 
            this.BtnAnalizare.BackColor = System.Drawing.Color.MistyRose;
            this.BtnAnalizare.Location = new System.Drawing.Point(481, 215);
            this.BtnAnalizare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAnalizare.Name = "BtnAnalizare";
            this.BtnAnalizare.Size = new System.Drawing.Size(111, 65);
            this.BtnAnalizare.TabIndex = 2;
            this.BtnAnalizare.Text = "Analizare";
            this.BtnAnalizare.UseVisualStyleBackColor = false;
            this.BtnAnalizare.Click += new System.EventHandler(this.BtnAnalizare_Click);
            // 
            // btnGenereazaGrafic
            // 
            this.btnGenereazaGrafic.BackColor = System.Drawing.Color.MistyRose;
            this.btnGenereazaGrafic.Location = new System.Drawing.Point(481, 284);
            this.btnGenereazaGrafic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenereazaGrafic.Name = "btnGenereazaGrafic";
            this.btnGenereazaGrafic.Size = new System.Drawing.Size(111, 65);
            this.btnGenereazaGrafic.TabIndex = 3;
            this.btnGenereazaGrafic.Text = "Genereaza";
            this.btnGenereazaGrafic.UseVisualStyleBackColor = false;
            this.btnGenereazaGrafic.Click += new System.EventHandler(this.btnGenereazaGrafic_Click);
            // 
            // listBoxImpremuturi
            // 
            this.listBoxImpremuturi.FormattingEnabled = true;
            this.listBoxImpremuturi.ItemHeight = 16;
            this.listBoxImpremuturi.Location = new System.Drawing.Point(616, 44);
            this.listBoxImpremuturi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxImpremuturi.Name = "listBoxImpremuturi";
            this.listBoxImpremuturi.Size = new System.Drawing.Size(685, 292);
            this.listBoxImpremuturi.TabIndex = 5;
            this.listBoxImpremuturi.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxImpremuturi_DrawItem);
            this.listBoxImpremuturi.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBoxImpremuturi_MeasureItem);
            this.listBoxImpremuturi.SelectedIndexChanged += new System.EventHandler(this.listBoxImpremuturi_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(155, 430);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 256);
            this.dataGridView1.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // cititorDataGridViewTextBoxColumn
            // 
            this.cititorDataGridViewTextBoxColumn.DataPropertyName = "Cititor";
            this.cititorDataGridViewTextBoxColumn.HeaderText = "Cititor";
            this.cititorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cititorDataGridViewTextBoxColumn.Name = "cititorDataGridViewTextBoxColumn";
            this.cititorDataGridViewTextBoxColumn.Width = 150;
            // 
            // carteDataGridViewTextBoxColumn
            // 
            this.carteDataGridViewTextBoxColumn.DataPropertyName = "Carte";
            this.carteDataGridViewTextBoxColumn.HeaderText = "Carte";
            this.carteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carteDataGridViewTextBoxColumn.Name = "carteDataGridViewTextBoxColumn";
            this.carteDataGridViewTextBoxColumn.Width = 150;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 150;
            // 
            // numarPaginiDataGridViewTextBoxColumn
            // 
            this.numarPaginiDataGridViewTextBoxColumn.DataPropertyName = "NumarPagini";
            this.numarPaginiDataGridViewTextBoxColumn.HeaderText = "NumarPagini";
            this.numarPaginiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numarPaginiDataGridViewTextBoxColumn.Name = "numarPaginiDataGridViewTextBoxColumn";
            this.numarPaginiDataGridViewTextBoxColumn.Width = 150;
            // 
            // imprumutDataGridViewTextBoxColumn
            // 
            this.imprumutDataGridViewTextBoxColumn.DataPropertyName = "Imprumut";
            this.imprumutDataGridViewTextBoxColumn.HeaderText = "Imprumut";
            this.imprumutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.imprumutDataGridViewTextBoxColumn.Name = "imprumutDataGridViewTextBoxColumn";
            this.imprumutDataGridViewTextBoxColumn.Width = 150;
            // 
            // restituireDataGridViewTextBoxColumn
            // 
            this.restituireDataGridViewTextBoxColumn.DataPropertyName = "Restituire";
            this.restituireDataGridViewTextBoxColumn.HeaderText = "Restituire";
            this.restituireDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.restituireDataGridViewTextBoxColumn.Name = "restituireDataGridViewTextBoxColumn";
            this.restituireDataGridViewTextBoxColumn.Width = 150;
            // 
            // cititoriBindingSource
            // 
            this.cititoriBindingSource.DataMember = "Cititori";
            this.cititoriBindingSource.DataSource = this.cititoriDataSet3;
            // 
            // cititoriDataSet3
            // 
            this.cititoriDataSet3.DataSetName = "CititoriDataSet3";
            this.cititoriDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cititoriTableAdapter
            // 
            this.cititoriTableAdapter.ClearBeforeFill = true;
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::LibraryManager.Properties.Resources.secondary_forms_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1659, 844);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxImpremuturi);
            this.Controls.Add(this.btnGenereazaGrafic);
            this.Controls.Add(this.BtnAnalizare);
            this.Controls.Add(this.chart1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGrafice";
            this.Text = "FormGrafice";
            this.Load += new System.EventHandler(this.FormGrafice_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormGrafice_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtnAnalizare;
        private System.Windows.Forms.Button btnGenereazaGrafic;
        private System.Windows.Forms.ListBox listBoxImpremuturi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CititoriDataSet3 cititoriDataSet3;
        private System.Windows.Forms.BindingSource cititoriBindingSource;
        private CititoriDataSet3TableAdapters.CititoriTableAdapter cititoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cititorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarPaginiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imprumutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restituireDataGridViewTextBoxColumn;
    }
}