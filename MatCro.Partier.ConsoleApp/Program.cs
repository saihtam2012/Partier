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
            //string[] partier = p.HentPartier();
            //string[] partiledere = p.HentPartiledere();



            //string[] partierBlandede = p.BlandArray(partier);
            //string[] ledereBlandede = p.BlandArray(partiledere);
            //Console.WriteLine(p.UdskrivArray(partier)); 
            //Console.WriteLine( );
            //Console.WriteLine(p.UdskrivArray(partierBlandede));


            //string[] t = { "A", "B", "C" };
            //Console.WriteLine(p.UdskrivArray(t)); 
            //string[] tb = p.BlandArray(t);
            //Console.WriteLine(p.UdskrivArray(tb));

            //Console.WriteLine(p.FindStringIArray("x", t));


            Console.WriteLine(p.PasserSammen("Venstre", "Jakob Ellemann-ensen"));

        }



    }
}
