using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    internal class Program
    {
        struct Personne
        {
            public string nom;
            public string prenom;
        }

        enum TypeMontant { 
            HT = 1, 
            TTC 
        }



        static void Main(string[] args)
        {
            /// Exercice 1

            /*
            Console.WriteLine(args[0]);
            int nombre = 10;

            double nombre_double = 10.0;

            decimal nombre_decimal = 1/7;

            bool faux = true;

            Console.WriteLine(nombre);
            Console.WriteLine(nombre_double);
            Console.WriteLine(nombre_decimal);
            Console.WriteLine(faux);
            */

            /// Exercice 2

            /*
            long numero;
            Console.WriteLine(numero);
            */

            /// Exercice 3 

            /*
            float montant = 10.35;
            */

            /// Exercice 4

            /*
            Console.WriteLine("Hello World!");
            */

            /// Exercice 5




            /// Exercice 6
/*
            string reponse;

            do
            { 
                //Demandez a l’utilisateur si il souhaite continuer
                Console.WriteLine("Voulez-vous continuer ? (o/n)");
                reponse = Console.ReadLine().ToLower();

            }while(reponse != "o");
*/
            /// Exercice 7
/*
            int mode;
            do
            {
                Console.WriteLine("1 : pour saisir un montant Hors Taxes");
                Console.WriteLine("2 : pour saisir un montant TTC");
                mode = int.Parse(Console.ReadLine());
                Enum.Parse(typeof(TypeMontant), Console.ReadLine());

            } while (mode.Equals(TypeMontant.HT) || mode.Equals(TypeMontant.TTC));
*/
            /// Exercice 8
/*
            int[] nombresAffectationRapide = { 3, 2, 1 };
            string[,] nomsprenoms = { 
                { "stephane", "leenhardt" }, 
                { "jen", "kelly" }, 
                { "jacques", "vernier" } 
            };

            foreach (var nom in nomsprenoms)
            {
                Console.WriteLine(nom);
            }

            Array.Sort(nombresAffectationRapide);
            foreach (var nombre in nombresAffectationRapide)
            {
                Console.WriteLine(nombre);
            }

            for (int i = 0; i < nomsprenoms.GetLength(0); i++)
            {
                Console.WriteLine(nomsprenoms[i, 0]);
            }
*/
            /// Exercice 9

            string chemin = Console.ReadLine();
            char[] caractere = { '\\' };

            string filename = Path.GetFileName(chemin);

            Console.WriteLine(filename);


            /// 4. Saut et gestion des erreurs
            


        }
    }
}
