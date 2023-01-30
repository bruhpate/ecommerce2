using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    public class DispElettronico : prodotto
    {
        private bool _lunedì = true;
        private string _modello;
        private int _sconto;
        public string Modello { get { return _modello; } set { _modello = value; }}
        public override float Prezzo
        {
            get
            {
                if (_lunedì)
                {
                    return base.Prezzo / 100 * 95;
                }
                return base.Prezzo;
            }
        }
        public int Sconto
        {
            set { _sconto = value; }
            get { return _sconto; }
        }
        public DispElettronico(string id, string nome, string produttore, string descrizione, float prezzo, string modellospec) : base(id, nome, produttore, descrizione, prezzo)
        {
            Modello = modellospec;
        }

    }
}
