using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void extragereListaCititoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void extragereListaCititoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void vizualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void fisiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilesForm extragere = new FilesForm();
            extragere.ShowDialog();
        }

        private void cititorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void graficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartsForm formGrafice = new ChartsForm();
            formGrafice.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {


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
                    //subMenuItem.BackColor = Color.FromArgb(255, 240, 240, 240);

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

        private void FormPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica daca tasta apasata este ESC
            if (e.KeyChar == (char)Keys.Escape)
                //Inchide fereastra
                this.Close();
        }

        private void adaugaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoanForm formImprumut = new LoanForm();
            formImprumut.ShowDialog();
        }

        private void vizualizareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewForm formVizualizare = new ViewForm();
            formVizualizare.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
