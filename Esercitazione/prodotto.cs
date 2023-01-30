using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    public class prodotto
    {
        private string _id, _nome, _produttore, _descrizione;
        private float _prezzo;

        public prodotto()
        {

        }
        public prodotto(string id, string nome, string produttore, string descrizione, float prezzo)
        {
            _id = id;
            _nome = nome;
            _produttore = produttore;
            _descrizione = descrizione;
            _prezzo = prezzo;
        }

        public string Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Nome
        {
            get { return _nome; }
        }
        public string Produttore
        {
            get { return _produttore; }
        }
        public string Descrizione
        {
            get { return _descrizione; }
        }

        public virtual float Prezzo
        {
            get { return _prezzo; }
        }
    }
}
