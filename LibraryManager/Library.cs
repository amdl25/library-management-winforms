using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
        public abstract class Library
        {
            private string numeBibliotecă;
            private string locație;
            private int anInființare;

             public Library()
            {

            }
            public Library(string numeBibliotecă, string locație, int anInființare)
            {
                this.numeBibliotecă = numeBibliotecă;
                this.locație = locație;
                this.anInființare = anInființare;
            }

            
            public string NumeBibliotecă
            {
                get { return numeBibliotecă; }
                set { numeBibliotecă = value; }
            }

            public string Locație
            {
                get { return locație; }
                set { locație = value; }
            }

            public int AnInființare
            {
                get { return anInființare; }
                set { anInființare = value; }
            }
        }

    
}
