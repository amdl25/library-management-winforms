using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Xml;
using System.Xml.Linq;


namespace LibraryManager
{
    public partial class FilesForm : Form
    {
        private PrintDocument printDocument;
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public FilesForm()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
        }

        private void ExtragereListaCititori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cititoriDataSet1.Cititori' table. You can move, or remove it, as needed.
            this.cititoriTableAdapter.Fill(this.cititoriDataSet1.Cititori);


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

            btnPrint.Click += printToolStripMenuItem_Click;
        }

        private void tbDrag_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewSelectedRowCollection)))
            {
                DataGridViewSelectedRowCollection draggedRows = (DataGridViewSelectedRowCollection)e.Data.GetData(typeof(DataGridViewSelectedRowCollection));

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("-------");

                foreach (DataGridViewRow draggedRow in draggedRows)
                {
                    foreach (DataGridViewCell cell in draggedRow.Cells)
                    {
                        string columnName = dataGridView1.Columns[cell.ColumnIndex].HeaderText;
                        string cellValue = cell.Value.ToString();
                        stringBuilder.AppendLine($"{columnName}: {cellValue}");
                    }
                    stringBuilder.AppendLine(); // Adăugăm un rând gol între abonamente
                }

                // Adăugăm textul la sfârșitul conținutului existent
                tbDrag.AppendText(stringBuilder.ToString());

                tbDrag.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                tbDrag.ForeColor = Color.Black;
                tbDrag.BackColor = Color.LightGray;
                tbDrag.ReadOnly = true;
                tbDrag.ScrollBars = ScrollBars.Vertical;

                tbDrag.SelectionStart = 10; // Poziția de start a selecției
                tbDrag.SelectionLength = 5; // Lungimea selecției
            }
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                DataGridViewRow draggedRow = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("__________________:");

                foreach (DataGridViewCell cell in draggedRow.Cells)
                {
                    string columnName = dataGridView1.Columns[cell.ColumnIndex].HeaderText;
                    string cellValue = cell.Value.ToString();
                    stringBuilder.AppendLine($"{columnName}: {cellValue}");
                }

                tbDrag.Text = stringBuilder.ToString();

                // Modificarea culorilor textului și fundalului
                tbDrag.ForeColor = Color.White;
                tbDrag.BackColor = Color.Black;

                // Adăugarea unui scrollbar în TextBox
                tbDrag.ScrollBars = ScrollBars.Vertical;
            }
        }


        private void tbDrag_MouseDown(object sender, MouseEventArgs e)
        {
            // Verificăm dacă s-a apăsat butonul stâng al mouse-ului
            if (e.Button == MouseButtons.Left)
            {
                // Verificăm dacă există rânduri selectate
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obținem rândurile selectate din DataGridView
                    DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;

                    // Inițiem operația de drag and drop cu rândurile selectate ca sursă
                    dataGridView1.DoDragDrop(selectedRows, DragDropEffects.Copy);
                }
            }
        }

        private void tbDrag_MouseEnter(object sender, EventArgs e)
        {
            tbDrag.DragEnter += new DragEventHandler(tbDrag_DragEnter);
            tbDrag.DragOver += new DragEventHandler(tbDrag_DragOver);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            // Verificăm dacă s-a apăsat butonul stâng al mouse-ului
            if (e.Button == MouseButtons.Left)
            {
                // Verificăm dacă există rânduri selectate
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obținem rândurile selectate din DataGridView
                    DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;

                    // Inițiem operația de drag and drop cu rândurile selectate ca sursă
                    dataGridView1.DoDragDrop(selectedRows, DragDropEffects.Copy);
                }
            }
        }

        private void tbDrag_DragEnter(object sender, DragEventArgs e)
        {
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void tbDrag_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Obținem rândul de sub cursor
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.HitTest(e.X, e.Y).RowIndex];

                // Inițiem operația de drag and drop cu rândul respectiv ca sursă
                dataGridView1.DoDragDrop(row, DragDropEffects.Copy);
            }
        }

        private void incarcatxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fișiere text (*.txt)|*.txt";
            openFileDialog.Title = "Încarcă fișier text";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Încărcăm conținutul fișierului într-o variabilă string
                    string fileContent = File.ReadAllText(filePath);

                    // Construim detaliile pentru stilizarea textului
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.AppendLine(fileContent);
                    stringBuilder.AppendLine();
                    

                    // Atribuim conținutul fișierului și detaliile la TextBox
                    tbDrag.Text = stringBuilder.ToString();

                    // Stilizăm textul
                    tbDrag.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                    tbDrag.ForeColor = Color.Black;
                    tbDrag.BackColor = Color.LightGray;
                    tbDrag.ReadOnly = true;
                    tbDrag.ScrollBars = ScrollBars.Vertical;
                    tbDrag.SelectionStart = 10;
                    tbDrag.SelectionLength = 5;

                    MessageBox.Show("Fișierul a fost încărcat cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare în timpul încărcării fișierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void descarcatxtToolStripMenuItem_Click(object sender, EventArgs e)
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
                    File.WriteAllText(filePath, tbDrag.Text);
                    MessageBox.Show("Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += printDocument1_PrintPage;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = document;

            // Adăugați un eveniment pentru a personaliza aspectul ferestrei de previzualizare
            printPreviewDialog.Paint += printPreviewDialog1_Paint;

            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Definim fontul și marginile
            Font font = new Font("Arial", 12);
            int marginTop = 50;
            int marginLeft = 50;

            // Calculăm înălțimea liniei de text
            int lineHeight = (int)font.GetHeight(e.Graphics);

            // Definim zona de imprimare
            RectangleF printArea = new RectangleF(marginLeft, marginTop, e.PageBounds.Width - marginLeft * 2, e.PageBounds.Height - marginTop * 2);

            // Definim un StringFormat pentru alinierea textului
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;

            // Obținem textul din TextBox
            string text = tbDrag.Text;

            // Obținem mărimea textului
            SizeF textSize = e.Graphics.MeasureString(text, font, (int)printArea.Width, stringFormat);

            // Verificăm dacă textul depășește zona de imprimare pe verticală
            if (textSize.Height > printArea.Height)
            {
                // Nu se poate imprima tot textul pe această pagină, așa că vom imprima cât putem și vom seta e.HasMorePages pe true
                int charactersFitted;
                int linesFitted;
                e.Graphics.MeasureString(text, font, printArea.Size, stringFormat, out charactersFitted, out linesFitted);

                // Obținem textul care se încadrează pe această pagină
                string partialText = text.Substring(0, charactersFitted);

                // Desenăm textul pe pagină
                e.Graphics.DrawString(partialText, font, Brushes.Black, printArea, stringFormat);

                // Reducem textul inițial pentru următoarea pagină
                tbDrag.Text = text.Substring(charactersFitted);

                // Setăm e.HasMorePages pe true pentru a imprima pe următoarea pagină
                e.HasMorePages = true;
            }
            else
            {
                // Textul se încadrează pe o singură pagină, așa că îl desenăm complet și setăm e.HasMorePages pe false
                e.Graphics.DrawString(text, font, Brushes.Black, printArea, stringFormat);
                e.HasMorePages = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += printDocument1_PrintPage;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = document;

            // Adăugați un eveniment pentru a personaliza aspectul ferestrei de previzualizare
            printPreviewDialog.Paint += printPreviewDialog1_Paint;

            printPreviewDialog.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Paint(object sender, PaintEventArgs e)
        {
            // Obțineți ferestra de previzualizare
            PrintPreviewDialog printPreviewDialog = (PrintPreviewDialog)sender;

            // Obțineți documentul asociat ferestrei de previzualizare
            PrintDocument document = printPreviewDialog.Document;

            // Desenați previzualizarea documentului pe suprafața ferestrei de previzualizare
            using (Graphics graphics = e.Graphics)
            {
                // Calculați dimensiunea paginii previzualizate
                Rectangle previewBounds = e.ClipRectangle;
                previewBounds.Inflate(-10, -10);

                // Desenați conținutul documentului în pagină
                using (Font font = new Font("Arial", 12))
                {
                    using (SolidBrush brush = new SolidBrush(Color.Black))
                    {
                        float lineHeight = font.GetHeight(graphics) + 5;
                        float x = previewBounds.Left;
                        float y = previewBounds.Top;

                        string[] lines = tbDrag.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                        foreach (string line in lines)
                        {
                            graphics.DrawString(line, font, brush, x, y);
                            y += lineHeight;

                            // Verificați dacă trebuie să treceți la o nouă pagină
                            if (y + lineHeight > previewBounds.Bottom)
                            {
                                // Adăugați o nouă pagină la documentul previzualizat
                                document.PrintPage += printDocument1_PrintPage;

                                // Ieșiți din bucla de desenare a previzualizării
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void FormFisiere_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica daca tasta apasata este ESC
            if (e.KeyChar == (char)Keys.Escape)
                //Inchide fereastra
                this.Close();
        }

        private void fisiereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void descarcaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fișiere XML (*.xml)|*.xml";
            saveFileDialog.Title = "Salvare fișier XML";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Transformați conținutul text într-un document XML
                    XDocument xmlDoc = new XDocument(new XElement("Root", new XElement("Content", tbDrag.Text)));

                    // Salvăm documentul XML în fișierul specificat
                    xmlDoc.Save(filePath);

                    MessageBox.Show("Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void incarcaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Încărcăm conținutul fișierului XML într-un obiect XmlDocument
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filePath);

                    // Obținem conținutul din elementul "Content"
                    XmlNode contentNode = xmlDoc.SelectSingleNode("//Content");
                    string content = contentNode.InnerText;

                    // Adăugăm conținutul în controlul tbDrag
                    tbDrag.Text = content;

                    // Setăm aspectul controlului tbDrag
                    tbDrag.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                    tbDrag.ForeColor = Color.Black;
                    tbDrag.BackColor = Color.LightGray;
                    tbDrag.ReadOnly = true;
                    tbDrag.ScrollBars = ScrollBars.Vertical;

                    MessageBox.Show("Fișierul XML a fost încărcat cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare în timpul încărcării fișierului XML: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
    

