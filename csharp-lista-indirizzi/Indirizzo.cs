using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Via { get; set; }
        public string Città { get; set; }
        public string Provincia { get; set; }
        public string Cap { get; set; }

        public Indirizzo(string nome, string cognome, string via, string città, string provincia, string cap)
        {
            Nome = nome;
            Cognome = cognome;
            Via = via;
            Città = città;
            Provincia = provincia;
            Cap = cap;
        }
        public Indirizzo() { }
       

    }
}
