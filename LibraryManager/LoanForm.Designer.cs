namespace LibraryManager
{
    partial class LoanForm
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
            this.cititoriDataSet5 = new LibraryManager.CititoriDataSet5();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbCititor = new System.Windows.Forms.TextBox();
            this.lbCititor = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbCarte = new System.Windows.Forms.Label();
            this.tbCarte = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.lbNrPagini = new System.Windows.Forms.Label();
            this.tbNrPagini = new System.Windows.Forms.TextBox();
            this.lbImprumut = new System.Windows.Forms.Label();
            this.dtImprumut = new System.Windows.Forms.DateTimePicker();
            this.lbRestituire = new System.Windows.Forms.Label();
            this.dtRestiturire = new System.Windows.Forms.DateTimePicker();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.cititoriTableAdapter = new LibraryManager.CititoriDataSet5TableAdapters.CititoriTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
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
            this.dataGridView1.Location = new System.Drawing.Point(71, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(923, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // cititorDataGridViewTextBoxColumn
            // 
            this.cititorDataGridViewTextBoxColumn.DataPropertyName = "Cititor";
            this.cititorDataGridViewTextBoxColumn.HeaderText = "Cititor";
            this.cititorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cititorDataGridViewTextBoxColumn.Name = "cititorDataGridViewTextBoxColumn";
            this.cititorDataGridViewTextBoxColumn.Width = 125;
            // 
            // carteDataGridViewTextBoxColumn
            // 
            this.carteDataGridViewTextBoxColumn.DataPropertyName = "Carte";
            this.carteDataGridViewTextBoxColumn.HeaderText = "Carte";
            this.carteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carteDataGridViewTextBoxColumn.Name = "carteDataGridViewTextBoxColumn";
            this.carteDataGridViewTextBoxColumn.Width = 125;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 125;
            // 
            // numarPaginiDataGridViewTextBoxColumn
            // 
            this.numarPaginiDataGridViewTextBoxColumn.DataPropertyName = "NumarPagini";
            this.numarPaginiDataGridViewTextBoxColumn.HeaderText = "NumarPagini";
            this.numarPaginiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numarPaginiDataGridViewTextBoxColumn.Name = "numarPaginiDataGridViewTextBoxColumn";
            this.numarPaginiDataGridViewTextBoxColumn.Width = 125;
            // 
            // imprumutDataGridViewTextBoxColumn
            // 
            this.imprumutDataGridViewTextBoxColumn.DataPropertyName = "Imprumut";
            this.imprumutDataGridViewTextBoxColumn.HeaderText = "Imprumut";
            this.imprumutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imprumutDataGridViewTextBoxColumn.Name = "imprumutDataGridViewTextBoxColumn";
            this.imprumutDataGridViewTextBoxColumn.Width = 125;
            // 
            // restituireDataGridViewTextBoxColumn
            // 
            this.restituireDataGridViewTextBoxColumn.DataPropertyName = "Restituire";
            this.restituireDataGridViewTextBoxColumn.HeaderText = "Restituire";
            this.restituireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.restituireDataGridViewTextBoxColumn.Name = "restituireDataGridViewTextBoxColumn";
            this.restituireDataGridViewTextBoxColumn.Width = 125;
            // 
            // cititoriBindingSource
            // 
            this.cititoriBindingSource.DataMember = "Cititori";
            this.cititoriBindingSource.DataSource = this.cititoriDataSet5;
            // 
            // cititoriDataSet5
            // 
            this.cititoriDataSet5.DataSetName = "CititoriDataSet5";
            this.cititoriDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 322);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboBox1_DragEnter);
            // 
            // tbCititor
            // 
            this.tbCititor.Location = new System.Drawing.Point(229, 368);
            this.tbCititor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCititor.Name = "tbCititor";
            this.tbCititor.Size = new System.Drawing.Size(178, 22);
            this.tbCititor.TabIndex = 15;
            this.tbCititor.Validating += new System.ComponentModel.CancelEventHandler(this.numeCititor_validating);
            this.tbCititor.Validated += new System.EventHandler(this.numeCititor_Validated);
            // 
            // lbCititor
            // 
            this.lbCititor.BackColor = System.Drawing.Color.Transparent;
            this.lbCititor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCititor.Location = new System.Drawing.Point(98, 371);
            this.lbCititor.Name = "lbCititor";
            this.lbCititor.Size = new System.Drawing.Size(91, 25);
            this.lbCititor.TabIndex = 16;
            this.lbCititor.Text = "Cititor";
            this.lbCititor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbCititor.Click += new System.EventHandler(this.lbCititor_Click);
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbId.Location = new System.Drawing.Point(88, 321);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(91, 25);
            this.lbId.TabIndex = 17;
            this.lbId.Text = "Id";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbCarte
            // 
            this.lbCarte.BackColor = System.Drawing.Color.Transparent;
            this.lbCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarte.Location = new System.Drawing.Point(98, 417);
            this.lbCarte.Name = "lbCarte";
            this.lbCarte.Size = new System.Drawing.Size(91, 25);
            this.lbCarte.TabIndex = 18;
            this.lbCarte.Text = "Carte";
            this.lbCarte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbCarte.Click += new System.EventHandler(this.lbCarte_Click);
            // 
            // tbCarte
            // 
            this.tbCarte.Location = new System.Drawing.Point(229, 414);
            this.tbCarte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCarte.Name = "tbCarte";
            this.tbCarte.Size = new System.Drawing.Size(178, 22);
            this.tbCarte.TabIndex = 19;
            this.tbCarte.Validating += new System.ComponentModel.CancelEventHandler(this.carte_validating);
            this.tbCarte.Validated += new System.EventHandler(this.carte_validated);
            // 
            // lbAutor
            // 
            this.lbAutor.BackColor = System.Drawing.Color.Transparent;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(98, 467);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(91, 25);
            this.lbAutor.TabIndex = 20;
            this.lbAutor.Text = "Autor";
            this.lbAutor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbAutor.Validating += new System.ComponentModel.CancelEventHandler(this.autor_validating);
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(229, 464);
            this.tbAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(178, 22);
            this.tbAutor.TabIndex = 21;
            this.tbAutor.Validating += new System.ComponentModel.CancelEventHandler(this.autor_validating);
            this.tbAutor.Validated += new System.EventHandler(this.autor_validated);
            // 
            // lbNrPagini
            // 
            this.lbNrPagini.BackColor = System.Drawing.Color.Transparent;
            this.lbNrPagini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNrPagini.Location = new System.Drawing.Point(98, 508);
            this.lbNrPagini.Name = "lbNrPagini";
            this.lbNrPagini.Size = new System.Drawing.Size(91, 25);
            this.lbNrPagini.TabIndex = 22;
            this.lbNrPagini.Text = "NrPagini";
            this.lbNrPagini.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbNrPagini
            // 
            this.tbNrPagini.Location = new System.Drawing.Point(229, 511);
            this.tbNrPagini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNrPagini.Name = "tbNrPagini";
            this.tbNrPagini.Size = new System.Drawing.Size(178, 22);
            this.tbNrPagini.TabIndex = 23;
            this.tbNrPagini.TextChanged += new System.EventHandler(this.tbNrPagini_TextChanged);
            this.tbNrPagini.Validating += new System.ComponentModel.CancelEventHandler(this.nrPagini_validating);
            this.tbNrPagini.Validated += new System.EventHandler(this.nrPagini_validated);
            // 
            // lbImprumut
            // 
            this.lbImprumut.BackColor = System.Drawing.Color.Transparent;
            this.lbImprumut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprumut.Location = new System.Drawing.Point(98, 560);
            this.lbImprumut.Name = "lbImprumut";
            this.lbImprumut.Size = new System.Drawing.Size(91, 25);
            this.lbImprumut.TabIndex = 24;
            this.lbImprumut.Text = "Imprumut";
            this.lbImprumut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtImprumut
            // 
            this.dtImprumut.Location = new System.Drawing.Point(229, 563);
            this.dtImprumut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtImprumut.Name = "dtImprumut";
            this.dtImprumut.Size = new System.Drawing.Size(178, 22);
            this.dtImprumut.TabIndex = 25;
            this.dtImprumut.Validating += new System.ComponentModel.CancelEventHandler(this.imprumut_validating);
            this.dtImprumut.Validated += new System.EventHandler(this.imprumut_validated);
            // 
            // lbRestituire
            // 
            this.lbRestituire.BackColor = System.Drawing.Color.Transparent;
            this.lbRestituire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRestituire.Location = new System.Drawing.Point(98, 610);
            this.lbRestituire.Name = "lbRestituire";
            this.lbRestituire.Size = new System.Drawing.Size(91, 25);
            this.lbRestituire.TabIndex = 26;
            this.lbRestituire.Text = "Restituire";
            this.lbRestituire.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtRestiturire
            // 
            this.dtRestiturire.Location = new System.Drawing.Point(229, 605);
            this.dtRestiturire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtRestiturire.Name = "dtRestiturire";
            this.dtRestiturire.Size = new System.Drawing.Size(178, 22);
            this.dtRestiturire.TabIndex = 27;
            this.dtRestiturire.Validating += new System.ComponentModel.CancelEventHandler(this.restituire_validating);
            this.dtRestiturire.Validated += new System.EventHandler(this.restituire_validated);
            // 
            // btnActualizeaza
            // 
            this.btnActualizeaza.BackColor = System.Drawing.Color.RosyBrown;
            this.btnActualizeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizeaza.Location = new System.Drawing.Point(663, 351);
            this.btnActualizeaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(133, 57);
            this.btnActualizeaza.TabIndex = 28;
            this.btnActualizeaza.Text = "Actualizeaza";
            this.btnActualizeaza.UseVisualStyleBackColor = false;
            this.btnActualizeaza.Click += new System.EventHandler(this.btnActualizeaza_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(663, 467);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(123, 50);
            this.btnAdauga.TabIndex = 29;
            this.btnAdauga.Text = "Modifica";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // cititoriTableAdapter
            // 
            this.cititoriTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(663, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 49);
            this.button1.TabIndex = 30;
            this.button1.Text = "Sterge";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LibraryManager.Properties.Resources.secondary_forms_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 709);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnActualizeaza);
            this.Controls.Add(this.dtRestiturire);
            this.Controls.Add(this.lbRestituire);
            this.Controls.Add(this.dtImprumut);
            this.Controls.Add(this.lbImprumut);
            this.Controls.Add(this.tbNrPagini);
            this.Controls.Add(this.lbNrPagini);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.tbCarte);
            this.Controls.Add(this.lbCarte);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbCititor);
            this.Controls.Add(this.tbCititor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "FormImprumut";
            this.Text = "FormImprumut";
            this.Load += new System.EventHandler(this.FormImprumut_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormImprumut_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbCititor;
        private System.Windows.Forms.Label lbCititor;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbCarte;
        private System.Windows.Forms.TextBox tbCarte;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label lbNrPagini;
        private System.Windows.Forms.TextBox tbNrPagini;
        private System.Windows.Forms.Label lbImprumut;
        private System.Windows.Forms.DateTimePicker dtImprumut;
        private System.Windows.Forms.Label lbRestituire;
        private System.Windows.Forms.DateTimePicker dtRestiturire;
        private System.Windows.Forms.Button btnActualizeaza;
        private System.Windows.Forms.Button btnAdauga;
        private CititoriDataSet5 cititoriDataSet5;
        private System.Windows.Forms.BindingSource cititoriBindingSource;
        private CititoriDataSet5TableAdapters.CititoriTableAdapter cititoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cititorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarPaginiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imprumutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restituireDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}