using System;

namespace UnicamMath
{
    class Program
    {
        static void Main(string[] args)
        {
            double ipotenusa = 0;
            double angolo1 = 90;
            double angolo2 = 0;
            double angolo3 = 0;
            double cateto1 = 0;
            double cateto2 = 0;
           
            Console.WriteLine("Questo programma calcola l'ipotenusa e gli angoli interni fornendo la lunghezza di due cateti");

            Console.Write("Inserisci la lunghezza del primo cateto: ");
            string cateto1Testuale = Console.ReadLine();
            bool cateto1Valido = Double.TryParse(cateto1Testuale, out cateto1);
            if(!cateto1Valido){
                Console.WriteLine("Il valore inserito non è valido.");
                return;
            }

            Console.Write("Inserisci la lunghezza del secondo cateto: ");
            string cateto2Testuale = Console.ReadLine();
            bool cateto2Valido = Double.TryParse(cateto2Testuale, out cateto2);
            if(!cateto2Valido){
                Console.WriteLine("Il valore inserito non è valido.");
                return;
            }

            


            //TO DO
            ipotenusa =Math.Sqrt(Math.Pow( cateto1,2)  + Math.Pow(cateto2,2));
            angolo2 = 180/Math.PI * Math.Asin(cateto1/ipotenusa);
            angolo3 =  180/ Math.PI * Math.Asin(cateto2/ipotenusa);
            Console.WriteLine($"L'ipotenusa misura {ipotenusa.ToString("N2")}");
            Console.WriteLine($"I tre angoli interni misurano {angolo1.ToString("N2")} gradi, {angolo2.ToString("N2")} gradi e {angolo3.ToString("N2")} gradi.");

            Console.ReadKey();
        }
    }
}
