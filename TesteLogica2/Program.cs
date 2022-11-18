using System;
using System.Collections;

namespace TesteLogica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variáveis de escopo

            var listaArray = new ArrayList() { 2, 7, 11, 15 };
            int soma = 0;

            #endregion

            for (int i = 0; i < listaArray.Count; i++)
            {
                var retorno = Convert.ToInt32(listaArray[i]);

                if (retorno == 7 || retorno == 15)
                { 
                    
                    soma += Convert.ToInt32(listaArray[i]);

                    if (soma == 22)
                    {
                        Console.WriteLine($"A soma de 7 + 15 é {soma}");
                    }

                }
                else
                {
                    Console.WriteLine($"O número {listaArray[i]} não faz parte do calculo");
                }

            }
        }
    }
}
