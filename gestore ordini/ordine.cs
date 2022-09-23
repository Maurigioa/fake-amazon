using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestore_ordini
{
    class Ordine
    {
        public string idOrdine { get; set; }

        public string codiceCliente { get; set; }

        public string[] arrayArticoli { get; set; }

        public Ordine(string codice, string cliente)
        {
            idOrdine = codice;
            codiceCliente = cliente;
            arrayArticoli = new string[1];
        }

        public bool insertArt(string codart) 
        {
            int i = arrayArticoli.Length;
            arrayArticoli[i - 1] = codart;
            arrayArticoli = new string[i + 1];
            i++;  
            return true;

        
        }

    }
}
