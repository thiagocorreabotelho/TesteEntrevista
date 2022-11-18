using System;
using System.Collections;

namespace TesteLogica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variáveis de escopo

            var listaOriginal = new ArrayList() { 7, 5, 3, 9, 6, 4, 1 };
            var novaLista = listaOriginal;
            int soma = 0;

            #endregion

            #region Exibição da lista original

            for (int i = 0; i < listaOriginal.Count; i++)
            {
                Console.WriteLine($@"Lista original é {listaOriginal[i]} ");
            }

            #endregion
          
            // Apenas para pular de linha
            Console.WriteLine();

            #region Calculo da nova lista

            for (int i = 0; i < novaLista.Count; i++)
            {
                var retorno = Convert.ToInt32(novaLista[i]);

                if (retorno == 9)
                    novaLista[i] = 5;

                if (retorno == 4)
                    novaLista.RemoveAt(i);

                soma += Convert.ToInt32(novaLista[i]);

                Console.WriteLine($@"Lista para substituir é {novaLista[i]}");
            }

            #endregion

            // Apenas para pular de linha
            Console.WriteLine();

            Console.WriteLine($"O resultado da somatória da nova lista é de {soma}");
        }
    }
}
