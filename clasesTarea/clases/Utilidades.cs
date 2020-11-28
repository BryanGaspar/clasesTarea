using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesTarea.clases
{
    class Utilidades
    {
        class Utilidades
        {
            /// <summary>
            /// La función calcula el factorial de un numero
            /// </summary>
            /// <param name="num">Numero a factorar</param>
            /// <returns>factorizacion de un numero</returns>
            public static long factorial(int num)
            {
                long fac = 1;
                if (num == 0)
                    return 1;  //retorna y abandona la función

                for (int i = 1; i <= num; i++)
                    fac *= i;

                return fac;
            }
            public static int SumaFactorial(int inicio, int fin)
            {
                int sum = 0, fac = 1, i;
                for (i = inicio; i <= fin; i++)
                {
                    fac *= i;
                    sum += fac;
                    return sum;
                }
            }
        }
}
