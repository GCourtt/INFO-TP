using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Joueur
    {
        public List<Pokemon> pokeJoueur = new List<Pokemon>();//équipe du joueur
        private List<Pokemon> pokemon = new List<Pokemon>();//tous les pokémons
        public Joueur(List<Pokemon> pokemon)
        {
            this.pokemon = pokemon;
            Random rand = new Random();
            for (int i = 0; i <3; i++)//on remplit l'équipe du joueur
            {
                pokeJoueur.Add(pokemon[rand.Next(0, pokemon.Count)]);
            }
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < 3; i++)//on remplit l'équipe du joueur
            {
                s=s+"\n"+pokeJoueur[i];
            }
            return s;
        }
    }
}
