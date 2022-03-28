using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    class Articolo
    {
        // TODO: (8) aggiungere attributi privati di Articolo
        // ...
        string unitaMisura;
        string descrizione;
        double prezzo;
        int codice;

        // TODO: (9) aggiungere property di sola lettura dei dati necessari all'esterno di Articolo
        // ...
        public string UnitaMisura { get { return unitaMisura; } }
        public string Descrizione { get { return descrizione; } }   
        public double Prezzo { get { return prezzo; } }
        public int Codice { get { return codice; } }

        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            // TODO: (10) impostazione costruttore classe Articolo come utilizzato da frmMain
            // ...
            this.unitaMisura=unitaMisura;
            this.descrizione=descrizione;
            this.prezzo = prezzo;
            this.codice = codice;

        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaMisura} {prezzo} ({codice})";
        }
    }
}
