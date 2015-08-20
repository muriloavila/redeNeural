using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redeNeuralOO
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] dados = new double[3, 4] { { 0, 0, 1, 1 }, { 0, 1, 0, 1 }, {-1,-1,-1,-1} };
            /*
             * dados =
             * | 0    0   1   1|
             * | 0    1   0   1|
             * 
             * entrada1 0, 0 pesos 0,0
             * entrada2 0, 1 pesos 0,0
             * entrada3 1, 0 pesos 0,0
             * entrada4 1, 1 pesos 0,0
             */
            double bias = -1;
             /* bias = -1
             */
            Random rdn = new Random();
            double[] pesos = new double[3] { rdn.NextDouble(), rdn.NextDouble(), rdn.NextDouble() };
             /* pesos = [0 0 0 0]
             */
            double[] valoresEsperados = new double[4] { 0, 1, 1, 1 };
             /* valores esperados = [0 1 1 1]
             */
            somatoria(dados, pesos, valoresEsperados);
            Console.Read();
            

        }

        private static void somatoria(double[,] dados, double[] pesos, double[] valoresEsperados)
        {
            double y;
            double soma = 0;
            double atual;
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    soma += dados[x, i] * pesos[x] + dados[2,i];
                    atual = dados[x, i];
                }
                atual = atual;
                if (soma >= 0)
                {
                    y = 1;
                }
                else
                {
                    y = -1;
                }
                if (y != valoresEsperados[i]) {
                    treino(pesos[i], y, valoresEsperados[i], 0.5, atual);
                }
            }
        }

        private static double treino(double peso, double y, double valorEsperado, double txAprendizagem, double x)
        {
            double pesoNovo = 0;
            pesoNovo = peso + txAprendizagem * x * (y - valorEsperado);
            return pesoNovo;
        }

    }
}
