using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace LibraryManager
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void FormVizualizare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cititoriDataSet2.Cititori' table. You can move, or remove it, as needed.
            this.cititoriTableAdapter.Fill(this.cititoriDataSet2.Cititori);
            
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


            // Personalizați stilul pentru menustrip
            menuStrip1.BackColor = Color.FromArgb(255, 240, 240, 240); // Setarea culorii de fundal
            menuStrip1.ForeColor = Color.FromArgb(255, 45, 45, 48); // Setarea culorii textului
            menuStrip1.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Setarea fontului și dimensiunii textului

            // Personalizați stilul pentru elementele menustrip
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                // Setarea culorii de fundal a elementului principal
                menuItem.BackColor = Color.FromArgb(255, 240, 240, 240);

                // Setarea culorii textului și a culorii de fundal a elementului principal la survol
                menuItem.MouseEnter += (s, ev) =>
                {
                    menuItem.ForeColor = Color.FromArgb(255, 0, 123, 255);
                    menuItem.BackColor = Color.FromArgb(255, 245, 245, 245);
                };

                // Resetarea culorii textului și a culorii de fundal a elementului principal după survol
                menuItem.MouseLeave += (s, ev) =>
                {
                    menuItem.ForeColor = Color.FromArgb(255, 45, 45, 48);
                    menuItem.BackColor = Color.FromArgb(255, 240, 240, 240);
                };

                // Personalizați stilul pentru elementele din meniul contextual
                foreach (ToolStripMenuItem subMenuItem in menuItem.DropDownItems)
                {
                    // Setarea culorii de fundal a elementelor din meniul contextual
                    subMenuItem.BackColor = Color.FromArgb(255, 240, 240, 240);

                    // Setarea culorii textului și a culorii de fundal a elementelor din meniul contextual la survol
                    subMenuItem.MouseEnter += (s, ev) =>
                    {
                        subMenuItem.ForeColor = Color.FromArgb(255, 0, 123, 255);
                        subMenuItem.BackColor = Color.FromArgb(255, 245, 245, 245);
                    };

                    // Resetarea culorii textului și a culorii de fundal a elementelor din meniul contextual după survol
                    subMenuItem.MouseLeave += (s, ev) =>
                    {
                        subMenuItem.ForeColor = Color.FromArgb(255, 45, 45, 48);
                        subMenuItem.BackColor = Color.FromArgb(255, 240, 240, 240);
                    };
                }
            }

        }



        //metoda
        private string BuildInformationString(DataGridViewRow row)
        {
            StringBuilder sb = new StringBuilder();


            if (row.Cells[2].Value != null)
            {
                sb.AppendLine("Carte: " + row.Cells[2].Value.ToString());
            }

            if (row.Cells[3].Value != null)
            {
                sb.AppendLine("Autor: " + row.Cells[3].Value.ToString());
            }

            if (row.Cells[4].Value != null)
            {
                sb.AppendLine("Număr Pagini: " + row.Cells[4].Value.ToString());
            }

            if (row.Cells[5].Value != null)
            {
                sb.AppendLine("Împrumut: " + row.Cells[5].Value.ToString());
            }

            if (row.Cells[6].Value != null)
            {
                sb.AppendLine("Restituire: " + row.Cells[6].Value.ToString());
            }

            return sb.ToString();
        }
        private void btnAfisare_Click(object sender, EventArgs e)
        {
            // Verifică dacă există cel puțin un rând în DataGridView
            if (dataGridView1.Rows.Count > 0)
            {
                Dictionary<string, List<string>> cititori = new Dictionary<string, List<string>>();

                // Parcurge fiecare rând și adaugă valorile în dicționarul "cititori"
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Verifică dacă celula "Nume Proprietar" conține o valoare validă
                    if (row.Cells[1].Value != null)
                    {
                        string numeProprietar = row.Cells[1].Value.ToString();

                        // Verifică dacă numele proprietarului există deja în dicționar
                        if (cititori.ContainsKey(numeProprietar))
                        {
                            // Adaugă informațiile în lista existentă pentru proprietarul respectiv
                            List<string> informatii = cititori[numeProprietar];
                            informatii.Add(BuildInformationString(row));
                        }
                        else
                        {
                            // Creează o nouă listă pentru proprietarul respectiv și adaugă informațiile
                            List<string> informatii = new List<string>();
                            informatii.Add(BuildInformationString(row));
                            cititori.Add(numeProprietar, informatii);
                        }
                    }
                }

                // Construiește un StringBuilder pentru a afișa informațiile
                StringBuilder sb = new StringBuilder();

                // Parcurge fiecare proprietar și informațiile asociate
                foreach (var entry in cititori)
                {
                    sb.AppendLine("--------");
                    sb.AppendLine("Nume Cititor: " + entry.Key);
                    sb.AppendLine();
                    sb.AppendLine("Informații:");
                    sb.AppendLine(string.Join(Environment.NewLine, entry.Value));
                    sb.AppendLine();
                }

                // Afișează toate datele în TextBox
                tbAfisareBazaDate.Text = sb.ToString();

                // Modifică stilul de afișare al TextBox
                tbAfisareBazaDate.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                tbAfisareBazaDate.ForeColor = Color.Black;
                tbAfisareBazaDate.BackColor = Color.LightGray;
                tbAfisareBazaDate.ReadOnly = true;
                tbAfisareBazaDate.ScrollBars = ScrollBars.Vertical;

                tbAfisareBazaDate.SelectionStart = 10; // Poziția de start a selecției
                tbAfisareBazaDate.SelectionLength = 5; // Lungimea selecției
            }
            else
            {
                // Nu există rânduri în DataGridView
                MessageBox.Show("Nu există date de afișat.");
            }
        }

        private void descarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fișiere text (*.txt)|*.txt";
            saveFileDialog.Title = "Salvare fișier text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Salvăm conținutul din TextBox în fișierul text
                    File.WriteAllText(filePath, tbAfisareBazaDate.Text);
                    MessageBox.Show("Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormVizualizare_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica daca tasta apasata este ESC
            if (e.KeyChar == (char)Keys.Escape)
                //Inchide fereastra
                this.Close();
        }
    }
}
