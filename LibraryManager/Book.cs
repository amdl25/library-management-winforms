using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager;

namespace LibraryManager
{
    public class Book : Library,ICloneable
    {
        private string nume;
        private string autor;
        private int nrPg;

        public Book() : base()
        {
        }

        public Book(string nume, string autor, int nrPg, string numeBibliotecă, string locație, int anInființare) :base(numeBibliotecă,  locație, anInființare)
        {
            this.nume = nume;
            this.autor = autor;
            this.nrPg = nrPg;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int NrPg
        {
            get { return nrPg; }
            set { nrPg = value; }
        }

        public object Clone()
        {
            return new Book(this.nume, this.autor, this.nrPg, base.NumeBibliotecă, base.Locație, base.AnInființare);
        }
    }
}

