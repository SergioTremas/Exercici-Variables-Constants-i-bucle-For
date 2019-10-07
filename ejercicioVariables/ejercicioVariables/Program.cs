using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom, cognom1, cognom2;
            int dia, any, mes;

            nom = "Sergio";
            cognom1 = "Tremosa";
            cognom2 = "Jorrillo";
            dia = 27;
            any = 1983;
            mes = 01;
            string frase= "";
            

            Console.WriteLine(nom + " " + cognom1 + " " + cognom2 + " " + dia + "/" + mes + "/" + any);

            const int traspas= 1948;
            const int tiempo = 4;
            int cantidad=0;
            bool traspasNeix = false;

            for(int x = traspas; x<= any; x = x+ tiempo)
            {
                cantidad++;

                if(x== any)
                {
                    traspasNeix = true;

                                 

                }
                
            }

            if (traspasNeix)
            {
                frase = "L'any de naixament es de traspas"; ;
            }
            else
            {
                frase = "L'any de naixament no es de traspas";
            }


            Console.WriteLine(frase);

            Console.WriteLine("quantitat de anys de traspas " + cantidad);

            Console.WriteLine("");

            string nomSencer = nom + " "+ cognom1+ " " + cognom2;
            string dataSecer = dia.ToString() + "/" + mes.ToString() + "/" + any.ToString();

            Console.WriteLine("Mi nombre es " + nomSencer + "\n" + "Vaig néixer " + dataSecer + "\n" + frase);

            Console.ReadKey(true);

        }
    }
}
