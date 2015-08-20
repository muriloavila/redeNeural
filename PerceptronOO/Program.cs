using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rdn = new Random();
            //Entrada x1 = new Entrada();
            //Entrada x2 = new Entrada();

            ////valores
            //x1.Valor = 0.0462;
            //x2.Valor = 0.0548;
            
            ////bias
            //double bias = 1;
            //double pesoBias = rdn.NextDouble();
            //Console.WriteLine(x1.Peso);


            //Entrada[] x = new Entrada[2] { x1, x2 };
            //Rede redeP = new Rede();
            //int classe = redeP.Perceptron(x, bias, pesoBias, -1, 0);
            //if(classe == 1){
            //    Console.WriteLine("Neuronio 1");
            //} else {
            //    Console.WriteLine("Neuronio 2");
            //}

            //Entrada y1 = new Entrada();
            //Entrada y2 = new Entrada();

            //y1.Valor = 0.0665;
            //y2.Valor = 0.0572;

            //y2.Peso = x1.Peso;
            //y2.Peso = x2.Peso;


            //Entrada[] y = new Entrada[2] { y1, y2 };
            //Rede redeQ = new Rede();
            //int classe2 = redeP.Perceptron(y, bias, pesoBias, 1, 0);
            //if (classe2 == 1)
            //{
            //    Console.WriteLine("Neuronio 1");
            //}
            //else
            //{
            //    Console.WriteLine("Neuronio 2");
            //}


            //Entrada z1 = new Entrada();
            //Entrada z2 = new Entrada();

            //z1.Valor = 0.0665;
            //z2.Valor = 0.0572;

            //y2.Peso = x1.Peso;
            //y2.Peso = x2.Peso;


            //Entrada[] z = new Entrada[2] { z1, z2 };
            //Rede redeU = new Rede();
            //int classe3 = redeP.Perceptron(y, bias, pesoBias);
            //if (classe3 == 1)
            //{
            //    Console.WriteLine("Neuronio 1");
            //}
            //else
            //{
            //    Console.WriteLine("Neuronio 2");
            //}

            //Entrada a1 = new Entrada();
            //Entrada a2 = new Entrada();

            //a1.Valor = 0.1;
            //a1.Valor = 0.1;

            //a1.Peso = x1.Peso;
            //a2.Peso = x2.Peso;

            //Entrada[] a = new Entrada[2] { a1, a2 };
            //int classeA = redeP.Perceptron(a, bias, pesoBias);
            //if (classeA == 1)
            //{
            //    Console.WriteLine("Neuronio 1");
            //}
            //else
            //{
            //    Console.WriteLine("Neuronio 2");
            //}

            Entrada x1 = new Entrada();
            Entrada x2 = new Entrada();
            Entrada x3 = new Entrada();

            x1.Valor = 0;
            x2.Valor = 0;
            x3.Valor = 1;

            x1.Peso = 0.4;
            x2.Peso = -0.6;
            x3.Peso = 0.6;

            double bias = -1;
            double pesoBias = 0.5;
            double txAprendizagem = 0.5;

            string classes;

            Entrada[] x = new Entrada[3] { x1, x2, x3 };
            Rede rede = new Rede();
            int classe = rede.Perceptron(x, bias, pesoBias, -1, 0);
            
            Console.WriteLine("Padrão: " + x1.Valor + " " + x2.Valor + " " + x3.Valor + " | "+ classe);

            x1.Valor = 1;
            x2.Valor = 1;
            x3.Valor = 0;
            classe = rede.Perceptron(x, bias, pesoBias, 1, 0);

            Console.WriteLine("Padrão: " + x1.Valor + " " + x2.Valor + " " + x3.Valor + " | " + classe);

            x1.Valor = 1;
            x2.Valor = 1;
            x3.Valor = 1;
            classe = rede.Perceptron(x, bias, pesoBias);
            if (classe == 1)
            {
                classes = "Classe 1";
            }
            else
            {
                classes = "Classe 0";
            }
            Console.WriteLine("Padrão: " + x1.Valor + " " + x2.Valor + " " + x3.Valor + " | " + classes);

            x1.Valor = 0;
            x2.Valor = 0;
            x3.Valor = 0;
            classe = rede.Perceptron(x, bias, pesoBias);
            if (classe == 1)
            {
                classes = "Classe 1";
            }
            else
            {
                classes = "Classe 0";
            }
            Console.WriteLine("Padrão: " + x1.Valor + " " + x2.Valor + " " + x3.Valor + " | " + classes);

            x1.Valor = 1;
            x2.Valor = 0;
            x3.Valor = 0;
            classe = rede.Perceptron(x, bias, pesoBias);
            if (classe == 1)
            {
                classes = "Classe 1";
            }
            else
            {
                classes = "Classe 0";
            }
            Console.WriteLine("Padrão: " + x1.Valor + " " + x2.Valor + " " + x3.Valor + " | " + classes);

            x1.Valor = 0;
            x2.Valor = 1;
            x3.Valor = 1;
            classe = rede.Perceptron(x, bias, pesoBias);
            if (classe == 1)
            {
                classes = "Classe 1";
            }
            else
            {
                classes = "Classe 0";
            }
            Console.WriteLine("Padrão: " + x1.Valor + " " + x2.Valor + " " + x3.Valor + " | " + classes);

            Console.Read();


        }
    }
}
