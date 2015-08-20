using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redePerceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double u;
            Random rdn = new Random();
            //Rede Neural Perceptron para a tabela verdade OR
            double[,] dados = new double[4, 2] { { 0, 0 }, { 0, 1 }, { 1, 0 }, { 1, 1 } };
            double[] pesos = new double[2] { rdn.NextDouble(), rdn.NextDouble() };
            double[] d = new double[4] { 0, 0, 0, 1 };
            double bias = -1;
            Console.WriteLine(pesos[0]);
            pesos[0] = treinar(pesos[0], d[0], 1, dados[0, 0]);
            Console.WriteLine(pesos[0]);
            Somatoria(dados, pesos, bias, d);

            Console.Read();
        }
        
        public static void Somatoria(double[,] dados, double[] pesos, double bias)
        {
            double soma = 0;
            double u = 0;
            for (int i = 0; i < dados.GetLength(0); i++)
            {
                for (int x = 0; x < dados.GetLength(1); x++)
                {
                    soma += dados[i, x] * pesos[x];
                }
                if (soma >= 0)
                {
                    u = 1;
                }
                else
                {
                    u = -1;
                }
                Console.WriteLine(u);   
            }
        }
        
        public static void Somatoria(double[,] dados, double[] pesos, double bias, double[] d)
        {
            double soma = 0;
            double u = 0;
            bool erro = true;
            int x, i;
            
                
                for (i = 0; i < dados.GetLength(0); i++)
                {
                   
                        soma = 0;
                        erro = false;
                        for (x = 0; x < dados.GetLength(1); x++)
                        {
                            soma += dados[i, x] * pesos[x];
                        }
                        if (soma >= 0)
                        {
                            u = 1;
                        }
                        else
                        {
                            u = -1;
                        }
                        if (d[i] != u)
                        {
                            for (int a = 0; a < x; a++)
                            {
                                
                                
                            }
                        
                    }
                    
            }
        }
        
        public static double treinar(double peso, double d, double u, double x)
        {
            double txAprendiz = 0.5;
            double pesoAtualizado = peso + txAprendiz * (d - u) * x; ;
            Console.WriteLine(pesoAtualizado);
            return pesoAtualizado;
        }


    }
}
