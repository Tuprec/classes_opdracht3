using System;
using System.Collections;
using System.Collections.Generic;

namespace classes_opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTitel, strAnswer, strUitgever;
            int intAantal = 0;
            List<CD> cden = new List<CD>();

            do
            {   
                Console.Write("Wilt u een liedje toevoegen aan de CD (minstens 1)? (Y/N) ");
                strAnswer = Console.ReadLine().ToUpper();

                strTitel = title();
                strUitgever = Uitgever();                

                CD cd = new CD(strTitel, strUitgever);
                cden.Add(cd);
                intAantal++;

            } while (strAnswer == "Y");
            Eind_Product_Tonen(intAantal, cden);
            
        }

        private static void Eind_Product_Tonen(int intAantal, List<CD> cden)
        {
            Console.WriteLine($"Het totaal aantal liedjes op de cd is: {intAantal}");
            foreach CD liedje in cden{ }

            Console.ReadLine();
        }

        private static string Uitgever()
        {
            string strUitgever;

            Console.Write("Geef de Uitgever: ");
            strUitgever = Console.ReadLine();

            return strUitgever;
        }

        private static string title()
        {
            string strTitel;

            Console.Write("Geef de title: ");
            strTitel = Console.ReadLine();

            return strTitel;
        }
    }
}
