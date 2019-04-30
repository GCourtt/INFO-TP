using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class ClassePokemon
    {
        private static int ConstPv=30;
        private static int ConstPui=7;
        private int Pv { get; set; }
        private int Pui { get; set; }
        private int Vit { get; set; }
        public ClassePokemon(int coefPv, int coefPui, int coefVit)
        {
            Random rand = new Random();
            Pv =(int) Math.Ceiling((double) (ConstPv + coefPv*(rand.Next(75,126))/100));//on prend l'arrondie au dessus de a+b*c avec a constante b coef de classe et c un facteur aléatoire
            Pui = (int)Math.Ceiling((double)(ConstPui + coefPui * (rand.Next(75, 126)) / 100));
            Vit = (int)Math.Ceiling((double)(coefVit * (rand.Next(75, 126)) / 100));
        }
        
    }
}
