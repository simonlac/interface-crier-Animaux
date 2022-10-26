using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Crier_Animaux 
{
    //La classe Lapins hérite de la classe Animaux et implémente l'interface IConvertible.
    class Lapins : Animaux,IConvertible
    { 
        // Attribut de classe/statique nb_lapins.
        public static int nb_lapins=0;
        
        // Constructeur de la classe Lapins.
        public Lapins (int p_age=0) : base (p_age)
        { 
            nb_lapins+=1;
        }
        //Surcharge (Override) de la méthode SeDeplacer. 
        public override void SeDeplacer()
        {
            Console.WriteLine("Je saute !!!");
        }
        // Implémentation de la méthode toHumanAge().
        public int toHumanAge()
        {
            return this.age * 5;
        }

    }

      
}
