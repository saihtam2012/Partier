using System;
using MatCro.Partier.Kerne;

namespace MatCro.Partier.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

           
            //int r = p.LægSammen(15, 2);
            //Console.WriteLine(r);
            
            //Console.WriteLine(p.TrækFra(309, 23));

            //Console.WriteLine(p.TrækFraSpecial(10, 5));
            
            //p.SkrivUd("test");                 

            
            PartiSpil p = new PartiSpil();
            string[] partier = p.HentPartier();
            string[] partiledere = p.HentPartiledere();


            for (int i = 0; i < partier.Length; i++)
            {
                Console.WriteLine(partier[i] + " " + partiledere[i]);
            }



        }



    }
}
