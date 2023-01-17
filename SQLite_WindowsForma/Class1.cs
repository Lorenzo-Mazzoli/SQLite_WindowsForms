using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_WindowsForma
{
    class Query
    {
        public string Titolo { get; set; }
        public string Contenuto { get; set; }

        public string getTitolo()
        {
            return this.Titolo;
        }
        public string getContenuto()
        {
            return this.Contenuto;
        }
    }
}
