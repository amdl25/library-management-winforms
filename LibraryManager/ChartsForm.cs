using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryManager
{
    public partial class ChartsForm : Form
    {
        public ChartsForm()
        {
            InitializeComponent();
        }

        private void BtnAnalizare_Click(object sender, EventArgs e)
        {
            ActualizeazaCititori();
        }


        private void FormGrafice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cititoriDataSet3.Cititori' table. You can move, or remove it, as needed.
            this.cititoriTableAdapter.Fill(this.cititoriDataSet3.Cititori);
            listBoxImpremuturi.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxImpremuturi.MeasureItem += listBoxImpremuturi_MeasureItem;
            listBoxImpremuturi.DrawItem += listBoxImpremuturi_DrawItem;

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Stilizează antetul coloanelor
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.BackColor = Color.DarkBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

        }

        private void ActualizeazaCititori()
        {
            Dictionary<string, int> numarImprumuturi = new Dictionary<string, int>();

            // Parcurgem rândurile DataGridView-ului
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Verificăm dacă rândul este un rând de date (nu un rând de antet)
                if (!row.IsNewRow)
                {
                    // Obținem valoarea din coloana "Cititor"
                    DataGridViewCell cell = row.Cells["cititorDataGridViewTextBoxColumn"];
                    if (cell.Value != null)
                    {
                        string cititor = cell.Value.ToString();

                        // Verificăm dacă numele cititorului există deja în dicționar
                        if (numarImprumuturi.ContainsKey(cititor))
                        {
                            // Incrementăm numărul de imprumuturi pentru numele existent
                            numarImprumuturi[cititor]++;
                        }
                        else
                        {
                            // Adăugăm numele cititorului în dicționar și setăm numărul la 1
                            numarImprumuturi.Add(cititor, 1);
                        }
                    }
                }
            }

            // Afisăm rezultatul în ListBox
            listBoxImpremuturi.Items.Clear();
            foreach (KeyValuePair<string, int> pair in numarImprumuturi)
            {
                string cititor = pair.Key;
                int numar = pair.Value;
                string text = $"{"Cititorul " + cititor + " a imprumutat"}: {numar} {"carte/carti"}";
                listBoxImpremuturi.Items.Add(text);
            }
        }

        private void btnGenereazaGrafic_Click(object sender, EventArgs e)
        {

            Dictionary<string, int> numarImprumuturiGrafic = new Dictionary<string, int>();

            // Parcurgeți rândurile DataGridView-ului pentru a colecta datele
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewCell cell = row.Cells["cititorDataGridViewTextBoxColumn"];
                    if (cell.Value != null)
                    {
                        string cititor = cell.Value.ToString();

                        if (numarImprumuturiGrafic.ContainsKey(cititor))
                        {
                            numarImprumuturiGrafic[cititor]++;
                        }
                        else
                        {
                            numarImprumuturiGrafic.Add(cititor, 1);
                        }
                    }
                }
            }

            // Sortați perechile în funcție de valoarea acestora în ordine crescătoare
            var numarImprumuturiSortate = numarImprumuturiGrafic.OrderBy(pair => pair.Value);

            // Ștergeți datele existente din grafic
            chart1.Series.Clear();

            // Adăugați o nouă serie pentru grafic
            Series series = chart1.Series.Add("NumarImprumuturi");

            // Adăugați punctele de date la seria graficului
            foreach (KeyValuePair<string, int> entry in numarImprumuturiSortate)
            {
                string numeCititor = entry.Key;
                int numarImprumuturi = entry.Value;

                // Adăugați un punct de date la seria graficului pentru fiecare cititor
                series.Points.AddXY(numeCititor, numarImprumuturi);
            }

            // Ajustați intervalul axei orizontale (Interval = 1, Minimum = 0)
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            // Afișați graficul
            chart1.Visible = true;

        }

        //eveniment
        private void listBoxImpremuturi_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                string text = listBoxImpremuturi.Items[e.Index].ToString();
                Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
                Brush brush = Brushes.BlueViolet;

                e.Graphics.DrawString(text, font, brush, e.Bounds);
            }
        }

        private void listBoxImpremuturi_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 30; // Inaltimea dorita a fiecarui element
        }

        private void FormGrafice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica daca tasta apasata este ESC
            if (e.KeyChar == (char)Keys.Escape)
                //Inchide fereastra
                this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxImpremuturi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}







