using System;

namespace UnicamMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questo programma calcola l'ipotenusa e gli angoli interni fornendo la lunghezza di due cateti");

            Console.Write("Inserisci la lunghezza del primo cateto: ");
            string cateto1Testuale = Console.ReadLine();

            Console.Write("Inserisci la lunghezza del secondo cateto: ");
            string cateto2Testuale = Console.ReadLine();

            decimal ipotenusa = 0;
            decimal angolo1 = 90;
            decimal angolo2 = 0;
            decimal angolo3 = 0;
            decimal cateto1 = Convert.ToDecimal(cateto1Testuale);
            decimal cateto2 = Convert.ToDecimal(cateto2Testuale);


            //TO DO
            ipotenusa =(decimal) Math.Sqrt(Math.Pow((double) cateto1,2)  + Math.Pow((double)cateto2,2));
            angolo2 = (decimal) (180/Math.PI * Math.Asin((double)(cateto1/ipotenusa)));
            angolo3 = (decimal) (180/ Math.PI * Math.Asin((double)(cateto2/ipotenusa)));
            Console.WriteLine($"L'ipotenusa misura {ipotenusa.ToString("N2")}");
            Console.WriteLine($"I tre angoli interni misurano {angolo1.ToString("N2")} gradi, {angolo2.ToString("N2")} gradi e {angolo3.ToString("N2")} gradi.");

            Console.ReadKey();
        }
    }
}
