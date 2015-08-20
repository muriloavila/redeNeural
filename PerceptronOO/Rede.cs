using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronOO
{
    class Rede
    {



        public int Perceptron(Entrada[] entrada, double bias, double pesoBias)
        {
            double soma = 0;
            int classe;
            //soma
            foreach (Entrada x in entrada)
            {
                soma += x.Valor * x.Peso;
            }
            soma += bias * pesoBias;
            if (soma >= 0)
            {
                classe = 1;
            }
            else
            {
                classe = -1;
            }
            return classe;
        }

        //Sobreescrever
        public int Perceptron(Entrada[] entrada, double bias, double pesoBias, double desejado, int limite)
        {
            double soma = 0;
            int classe;
            bool erro = true;
            int count = 0;
            //soma
            do{
                erro = false;
                foreach (Entrada x in entrada)
                {
                    soma += x.Valor * x.Peso;
                }
                soma += bias * pesoBias;
                if (soma >= limite)
                {
                    classe = 1;
                }
                else
                {
                    classe = -1;
                }
                if (classe != desejado)
                {
                    erro = true;
                    foreach (Entrada x in entrada)
                    {
                        x.treinar(x, 0.5, desejado, classe, pesoBias, bias); 
                    }
                    
                }
                count++;
            } while (erro == true || count < 3000);
            
            return classe;
        }

       
    }
}
