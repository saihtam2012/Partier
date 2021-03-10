using System;
using System.Collections.Generic;
using System.Text;

namespace MatCro.Partier.Kerne
{
    public class PartiSpil
    {

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
