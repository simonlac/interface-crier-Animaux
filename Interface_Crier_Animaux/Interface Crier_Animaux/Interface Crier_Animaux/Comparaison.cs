using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Crier_Animaux
{
    //Classe statique/utilitaire. 
    static class Comparaison 
    {
        //Méthodes statiques.
        public static bool PlusGrandStrict(IConvertible anim1,IConvertible Anim2)
        {
         
            if (anim1.toHumanAge() > Anim2.toHumanAge())
                return true;
            else
                return false;
        }

        public static bool PlusPetitStrict(IConvertible anim1, IConvertible Anim2)
        {

            if (anim1.toHumanAge() < Anim2.toHumanAge())
                return true;
            else
                return false;
        }

        public static bool Egalite(IConvertible anim1, IConvertible Anim2)
        {

            if (anim1.toHumanAge() == Anim2.toHumanAge())
                return true;
            else
                return false;
        }

    }
}
