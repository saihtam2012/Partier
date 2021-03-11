using System;
using System.Collections.Generic;
using System.Text;

namespace MatCro.Partier.Kerne
{
    public class PartiSpil
    {

        public bool PasserSammen(string parti, string leder)
        {
            string[] partier = HentPartier();
            string[] partiledere = HentPartiledere();
            int p = FindStringIArray(parti, partier);
            int pl = FindStringIArray(leder, partiledere);
            if (p == pl)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        public int FindStringIArray(string navn, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (navn == array[i])
                {
                    return i;
                }                
            }
            return -1;
        }


        public string UdskrivArray(string[] array) 
        {
            string t = $"Der er {array.Length} i samlingen\r\n";
            for (int i = 0; i < array.Length; i++)
            {
                t+=i + " " + array[i] + "\r\n";
            }
            return t;
        } 

        public string[] BlandArray(string[] array)
        {
      
            string[] nyt = (string[])array.Clone();
            Random rnd = new Random();

            for (int c = 0; c < 100; c++)
            {
                for (int i = 0; i < nyt.Length; i++)
                {
                    int tal = rnd.Next(0, array.Length);
                    string s = nyt[i];
                    nyt[i] = nyt[tal];
                    nyt[tal] = s;
                } 
            }
            return nyt;            
        }  


        public string[] HentPartier()
        {
            string[] partier = {
                "Radikale venstre",
                "Socialdemokratiet",
                "Venstre",
                "Enhedslisten",
                "Dansk Folkeparti",
                "Nye Borgerlige",
                "Det Konservative Folkeparti",
                "Socialistisk Folkeparti",
                "Liberal Alliance",
                "Alternativet"
            };
            return partier;
        }

        public string[] HentPartiledere()
        {
            string[] partiledere =
            {
                "Sofie Carsten Nielsen",
                "Mette Frederiksen",
                "Jakob Ellemann-Jensen",
                "Mai Villadsen",
                "Kristian Thulesen Dahl",
                "Pernille Vermund",
                "Søren Pape Poulsen",
                "Pia Olsen Dyhr",
                "Alex Vanopslagh",
                "Bente Holm Villadsen"
            };
            return partiledere;
        }

        //public int LægSammen(int tal1, int tal2)
        //{
        //    int res = tal1 + tal2;
        //    return res;        
        //}

        //public int TrækFra(int tal1, int tal2)
        //{
        //    int res = tal1 - tal2;
        //    return res;
        //}

        //public int TrækFraSpecial(int tal1, int tal2)
        //{

        //    int sek = DateTime.Now.Second;
        //    if (sek % 2 == 0)
        //    {
        //        return tal1 - tal2;

        //    }
        //    else
        //    {
        //        return 0;
        //    }
            


        //}

        //public void SkrivUd (string tekst)
        //{
        //    Console.WriteLine(" - " + tekst);
        //} 





    }
}
