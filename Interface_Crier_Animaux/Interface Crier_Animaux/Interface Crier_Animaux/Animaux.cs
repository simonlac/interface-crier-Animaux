using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Crier_Animaux
{
    // Classe mère Animaux.
    abstract class Animaux
    {
        // Attribut privé age. Cet attribut est accessible dans la classe Animaux
        // Et dans les classes filles Lapins et Chats.
        protected int age;
        private string nom;
        // Propriété Age qui assure l'encapsulation de l'attribut privé age.
        // age est modifié seulement si la valeur entrée par l'utilisateur est entre 0 et 20.
        public int Age
        {
            get { return this.age; }
            set { if (value > 0 & value <= 20) this.age = value; }
        }
        // Propriété NOm qui assure l'encapsulation de l'attribut privé nom.
        // nom est modifié seulement si la valeur entrée par l'utilisateur est une chaine alphabétique
        // de longueur inférieure à 30.
        public string Nom        
        {
            get { return this.nom; }
            
            set { if (value.All(char.IsLetter) & value.Length<30) this.nom = value; }
        }

        //Constructeur avec paramètre et valeur par défaut.
        public Animaux (int p_age = 0,string p_nom="")
        {
            this.age = p_age;
            this.nom = p_nom;
        }
        // Méthode abstraite Sedeplacer().
        // Cette méthode doit être surchagée (Override) dans les classes filles. 
        public abstract void SeDeplacer();
    }
}
