using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création des classes pour les pokémons
            ClassePokemon Tank = new ClassePokemon(20, 0, 0);
            ClassePokemon TankPlus = new ClassePokemon(40, -2, 0);
            ClassePokemon TankVit = new ClassePokemon(10, 0, 10);
            ClassePokemon TankDeg = new ClassePokemon(10, 4, 0);
            ClassePokemon Deg = new ClassePokemon(0, 10, 0);
            ClassePokemon DegPlus = new ClassePokemon(-10, 20, 0);
            ClassePokemon DegVit = new ClassePokemon(0, 6, 10);
            ClassePokemon Vit = new ClassePokemon(0, 0, 20);
            ClassePokemon Normal = new ClassePokemon(0, 0, 0);

            //Création des pokémons
            Pokemon Florizarre = new Pokemon("Florizarre",Tank, "Plante");
            Pokemon Dracaufeu = new Pokemon("Dracaufeu",TankDeg, "Feu");
            Pokemon Tortank = new Pokemon("Tortank",Deg, "Eau");
            Pokemon Papilusion = new Pokemon("Papilusion",Vit, "Insecte");
            Pokemon Dartagnan = new Pokemon("Dartagnan",DegVit, "Poison");
            Pokemon Roucarnage = new Pokemon("Roucarnage",Vit, "Vol");
            Pokemon Rattatac = new Pokemon("Rattatac",Normal, "Normal");
            Pokemon Rapasdepic = new Pokemon("Rapasdepic",Normal, "Vol");
            Pokemon Arbok = new Pokemon("Arbok",Deg, "Poison");

            //Ajout des pokémons dans une liste
            List<Pokemon> pokemon = new List<Pokemon>();
            pokemon.Add(Florizarre);
            pokemon.Add(Dracaufeu);
            pokemon.Add(Tortank);
            pokemon.Add(Papilusion);
            pokemon.Add(Dartagnan);
            pokemon.Add(Roucarnage);
            pokemon.Add(Rattatac);
            pokemon.Add(Rapasdepic);
            pokemon.Add(Arbok);
            
            //Création des joueurs
            Joueur j1 = new Joueur(pokemon);
            Console.WriteLine(j1);
            Console.ReadKey();
        }
    }
}
