using System;
using ClasseBase.Model.Housing;


namespace ClasseBase.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INDIRIZZO: \n" +
                "(Via Numero,Città CAP)\n");
            var addressString = Console.ReadLine();
            var address = Indirizzo.Parse(addressString);
            Console.WriteLine(address);
            Console.ReadLine();
        }
    }
}
