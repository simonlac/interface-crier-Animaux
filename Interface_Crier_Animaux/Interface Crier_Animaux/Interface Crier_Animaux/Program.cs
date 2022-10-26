using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Crier_Animaux
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liste d'animaux.
            List<Animaux> lsAnimaux = new List <Animaux> ();
            //Ajouter deux chats et un lapin à la liste des animaux.
            Chats chat1 = new Chats();
            chat1.Age = 5;
            chat1.Nom = "Minou";
            lsAnimaux.Add(chat1);
            Lapins lapin1 = new Lapins();
            lapin1.Age = 4;
            lapin1.Nom = "Lapinou";
            lsAnimaux.Add(lapin1);
            Chats chat2 = new Chats();
            chat2.Age = 6;
            chat2.Nom = "Sweety";
            lsAnimaux.Add(chat2);
            //Parcourir la liste des animaux et faire crier les chats.
            foreach (Animaux anim in lsAnimaux)
            {
                Console.WriteLine("Je m'appelle " + anim.Nom + ". ");
                Console.WriteLine("J'ai {0} ans",anim.Age);
                if (anim.GetType().Name == "Chats")
                {
                    // Conversion de l'objet anim de Animaux à Chats.
                    // pour pouvoir avoir accès à la méthode Crier().
                    Chats anim1 = (Chats)anim;
                    anim1.Crier();
                }
                // Pas besoin de conversion ici car SeDeplacer est accessible
                // par tous les objets de la classe Animaux.
                anim.SeDeplacer();
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            }
            // Comparer l'âge des animaux
            Console.WriteLine(chat2.Nom +" est plus agé que "+ chat1.Nom+ " : "+Comparaison.PlusGrandStrict(chat2, chat1));
            Console.WriteLine(lapin1.Nom + " est moins agé que " + chat2.Nom + " : " + Comparaison.PlusPetitStrict(lapin1, chat2));
            Console.WriteLine(chat1.Nom + " a le même âge que " + lapin1.Nom + " : " + Comparaison.Egalite(chat1, lapin1));

            // Afficher le nombre de lapins et de chats
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            //Afficher les attributs statiques/de classe : nb_lapins et nb_chats.
            Console.WriteLine("Nous avons {0} lapin(s) et {1} chat(s)", Lapins.nb_lapins,Chats.nb_chats);
            Console.ReadLine();
        }
    }
}
