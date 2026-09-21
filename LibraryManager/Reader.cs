using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager;





namespace LibraryManager
{
    public class Reader : IComparable, ICloneable
    {
        private string nume;
        private List<Loan> imprumuturi;

        public Reader()
        {
        }

        public Reader(string nume, List<Loan> imprumuturi)
        {
            this.nume = nume;
            this.imprumuturi = imprumuturi;
        }

        public Reader(string nume)
        {
            this.nume = nume;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public List<Loan> Imprumuturi
        {
            get { return imprumuturi; }
            set { imprumuturi = value; }
        }

        public static Reader operator +(Reader cititor, Loan imprumut)
        {
            if (cititor.imprumuturi == null)
            {
                cititor.imprumuturi = new List<Loan>();
            }

            cititor.imprumuturi.Add(imprumut);

            return cititor;
        }

        public static Reader operator -(Reader cititor, Loan imprumut)
        {
            if (cititor.imprumuturi == null)
            {
                cititor.imprumuturi = new List<Loan>();
            }

            cititor.imprumuturi.Remove(imprumut);

            return cititor;
        }

        public object Clone()
        {
            return new Reader(this.nume, new List<Loan>(this.imprumuturi));
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            Reader otherCititor = obj as Reader;
            if (otherCititor != null)
            {
                return string.Compare(this.nume, otherCititor.nume);
            }
            else
            {
                throw new ArgumentException("Obiectul nu este de tipul cititor.");
            }
        }
    }
}
