using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    
    public delegate void RestituireImprumutEventHandler(object sender, EventArgs e);

    public class Loan
    {
       
        public event RestituireImprumutEventHandler RestituireImprumut;

        Book carteImprumutata;
        DateTime data_imprumut;
        DateTime data_restituire;

        public Loan()
        {
        }

        public Loan(Book carteImprumutata, DateTime data_imprumut, DateTime data_restituire)
        {
            this.carteImprumutata = carteImprumutata;
            this.data_imprumut = data_imprumut;
            this.data_restituire = data_restituire;
        }

        public Book CarteImprumutata
        {
            get { return carteImprumutata; }
            set { carteImprumutata = value; }
        }

        public DateTime DataRestituire
        {
            get { return data_restituire; }
            set { data_restituire = value; }
        }

        public DateTime DataImprumut
        {
            get { return data_imprumut; }
            set { data_imprumut = value; }
        }

        // Metoda care declanșează evenimentul RestituireImprumut
        protected virtual void OnRestituireImprumut()
        {
            
            if (RestituireImprumut != null)
            {
                // Creăm un argument eveniment
                EventArgs args = new EventArgs();

                // Declanșăm evenimentul
                RestituireImprumut(this, args);
            }
        }

        // Metoda pentru restituirea unui imprumut
        public void Restituire()
        {
            // Apelăm metoda pentru declanșarea evenimentului
            OnRestituireImprumut();
        }
    }
}