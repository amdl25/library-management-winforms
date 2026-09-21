using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class LoanForm : Form, IAddable
    {
        DataSet DSCititori = new DataSet();
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Cititori;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        string selectCommand = "select * from Cititori";
        public void adaugare()
        {
            MessageBox.Show("Ati modificat");
        }
        public LoanForm()
        {
            InitializeComponent();
            IncarcaDate();
        }

        private void FormImprumut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cititoriDataSet5.Cititori' table. You can move, or remove it, as needed.
            this.cititoriTableAdapter.Fill(this.cititoriDataSet5.Cititori);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Stilizează antetul coloanelor
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.BackColor = Color.SteelBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
        }

        private void IncarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();

            SqlDataAdapter adaptor = new SqlDataAdapter(selectCommand, conexiune);
            adaptor.Fill(DSCititori, "Cititori");

            DSCititori.Tables["Cititori"].PrimaryKey = new DataColumn[1]
            {DSCititori.Tables["Cititori"].Columns["Id"] };
            conexiune.Close();

            comboBox1.DataSource = DSCititori.Tables["Cititori"];
            comboBox1.DisplayMember = "Id";
            comboBox1.ValueMember = "Id";

            tbCititor.DataBindings.Clear();
            tbCarte.DataBindings.Clear();
            tbAutor.DataBindings.Clear();
            tbNrPagini.DataBindings.Clear();
            dtImprumut.DataBindings.Clear();
            dtRestiturire.DataBindings.Clear();

            tbCititor.DataBindings.Add("Text", DSCititori.Tables["Cititori"], "Cititor");
            tbCarte.DataBindings.Add("Text", DSCititori.Tables["Cititori"], "Carte");
            tbAutor.DataBindings.Add("Text", DSCititori.Tables["Cititori"], "Autor");
            tbNrPagini.DataBindings.Add("Text", DSCititori.Tables["Cititori"], "NumarPagini");
            dtImprumut.DataBindings.Add("Value", DSCititori.Tables["Cititori"], "Imprumut");
            dtRestiturire.DataBindings.Add("Value", DSCititori.Tables["Cititori"], "Restituire");

        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                cititoriBindingSource.EndEdit();
                int i = cititoriTableAdapter.Update(cititoriDataSet5.Cititori);
                MessageBox.Show("Salvare cu succes " + i + " linii");
                
                    
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            IncarcaDate();
            


        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            // Verifică dacă există un rând selectat în DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Verifică dacă rândul selectat este gol
                if (selectedRow.Cells[0].Value == null || string.IsNullOrEmpty(selectedRow.Cells[0].Value.ToString()))
                {
                    // Populează rândul gol cu datele din TextBox-uri
                    selectedRow.Cells[1].Value = tbCititor.Text;
                    selectedRow.Cells[2].Value = tbCarte.Text;
                    selectedRow.Cells[3].Value = tbAutor.Text;
                    selectedRow.Cells[4].Value = tbNrPagini.Text;
                    selectedRow.Cells[5].Value = dtImprumut.Value;
                    selectedRow.Cells[6].Value = dtRestiturire.Value;
                }
                else
                {
                    // Modifică textul celulelor rândului selectat cu datele din TextBox-uri
                    selectedRow.Cells[1].Value = tbCititor.Text;
                    selectedRow.Cells[2].Value = tbCarte.Text;
                    selectedRow.Cells[3].Value = tbAutor.Text;
                    selectedRow.Cells[4].Value = tbNrPagini.Text;
                    selectedRow.Cells[5].Value = dtImprumut.Value;
                    selectedRow.Cells[6].Value = dtRestiturire.Value;
                }
            }
            else
            {
                // Adaugă un nou rând în DataGridView cu datele din TextBox-uri
                int newId = dataGridView1.Rows.Count + 1; // Generare Id unic bazat pe numărul de rânduri existente
                dataGridView1.Rows.Add(new object[] { newId, tbCititor.Text, tbCarte.Text, tbAutor.Text, tbNrPagini.Text, dtImprumut.Value, dtRestiturire.Value });
            }

            adaugare();
        }

        private void lbCarte_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verifică dacă există un rând selectat
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // Obține rândul selectat
                dataGridView1.Rows.Remove(selectedRow); // Șterge rândul din DataGridView

                // Actualizează valorile coloanei Id în ordine crescătoare
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["idDataGridViewTextBoxColumn"].Value = i + 1;
                }

                // Resetează valoarea maximă a coloanei Id la 1
                int newMaxId = dataGridView1.Rows.Count + 1;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int currentId = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                    if (currentId >= newMaxId)
                    {
                        row.Cells["idDataGridViewTextBoxColumn"].Value = newMaxId;
                        newMaxId++;
                    }
                }
            }
        }

        private void numeCititor_validating(object sender, CancelEventArgs e)
        {
            if (tbCititor.Text.Length < 2)
            {
                errorProvider1.SetError(tbCititor, "Numele este prea scurt");
                e.Cancel = true;
            }
        }

        private void numeCititor_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbCititor, "");
        }

        private void nrPagini_validating(object sender, CancelEventArgs e)
        {
            int nr_pagini;
            if (!int.TryParse(tbNrPagini.Text, out nr_pagini) || nr_pagini < 0)
            {
                e.Cancel = true;
                tbNrPagini.Select(0, tbNrPagini.Text.Length);
                errorProvider1.SetError(tbNrPagini, "Introduceți un numar de pagini pozitiv");
            }
        }

        private void nrPagini_validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbNrPagini, "");
        }

        private void imprumut_validating(object sender, CancelEventArgs e)
        {
            DateTime selectedDate = dtImprumut.Value;
            if (selectedDate > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtImprumut, "Data aleasa trebuie sa fie mai mica sau egala cu data de azi.");
            }
        }

        private void imprumut_validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtImprumut, "");
        }

        private void restituire_validating(object sender, CancelEventArgs e)
        {
            DateTime selectedDate = dtRestiturire.Value;
            DateTime currentDate = DateTime.Now;
            DateTime maxAllowedDate = currentDate.AddDays(14);

            if (selectedDate > maxAllowedDate)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtRestiturire, "Data aleasă trebuie să fie în ultimele 14 zile.");
            }
        }

        private void lbCititor_Click(object sender, EventArgs e)
        {

        }

        private void tbNrPagini_TextChanged(object sender, EventArgs e)
        {

        }

        private void autor_validating(object sender, CancelEventArgs e)
        {
            string autor = tbAutor.Text;
            if (autor.Length < 2)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbAutor, "Numele autorului este prea scurt");
            }

        }

        private void autor_validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbAutor,"");
        }

        private void restituire_validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtRestiturire, "");
        }

        private void carte_validating(object sender, CancelEventArgs e)
        {
            string carte=tbCarte.Text;
            if(carte.Length<2)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCarte, "Numele cartii este prea scurt");
            }
        }

        private void carte_validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbCarte, "");
        }

        private void FormImprumut_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica daca tasta apasata este ESC
            if (e.KeyChar == (char)Keys.Escape)
                //Inchide fereastra
                this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
