 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Crier_Animaux
{
    //La classe Chats hérite de la classe Animaux et implémente les deux interfaces ICrier et IConvertible. 
    class Chats : Animaux,ICrier,IConvertible
    {
        
        // Attribut de classe / statique. 
        public static int nb_chats=0;

        // Constructeur de la classe Chats.
        public Chats(int p_age=0) : base (p_age)
        {
            nb_chats += 1;
        }
        // Implémenter la méthode abstraite de la classe Animaux SeDeplacer().
        public override void SeDeplacer()
        {
            Console.WriteLine("Pour me déplacer, je propulse mon corps avec mes 2 pattes postérieures...");
        }
        //Surcharge de la méthode Crier() de l'interface ICrier.
        public void Crier()
        {
            Console.WriteLine("Je miaule...");
        }

        // Implémenter la méthode toHumanAge() de l'interface IConvertible.
        public int toHumanAge()
        {
            return this.age * 4;
        }
    }
}