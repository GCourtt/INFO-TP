using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemon
    {
        private string Nom { get; set; }
        private int Pv { get; set; }
        private int Pui { get; set; }
        private int Vit { get; set; }
        private string Type { get; set; }
        public Pokemon(string Nom,ClassePokemon classe, string type)
        {
            this.Nom = Nom;
            Type = type;
            Pv = classe.Pv;
            Pui = classe.Pui;
            Vit = classe.Vit;
        }
        public override string ToString()
        {
            return Nom+" "+Pv + " " + Pui + " " + Vit + " "+Type;
        }
    }
}
