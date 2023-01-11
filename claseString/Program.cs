using System;

namespace claseString
{
    internal class Program
    {
        private const string V = "intenzivno ";

        static void Main(string[] args)
        {
            string recenica = "Danas radimo s klasom string!";


            Console.WriteLine("Broj znakova u rečenici: {0}",
                recenica.Length);

            Console.WriteLine("Ispis malim slovima: {0} " + "\nIspis velikim slovima: {1}",
                recenica.ToLower(), recenica.ToUpper());

            Console.WriteLine(recenica.Substring(0, 5));
            Console.WriteLine(recenica.Substring(recenica.Length - 5, 5));

            Console.WriteLine(recenica.Replace("Danas", "Sutra"));

            string[] rijeci = recenica.Split(' ');
            for (int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }
          

            Console.WriteLine(recenica.IndexOf("radimo"));
            Console.WriteLine(recenica.Insert(recenica.IndexOf("radimo"), "intenzivno "));


            Console.ReadKey();

            
        }
    }
}
