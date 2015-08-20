using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redeNeural
{
    class Program
    {
        static Random rdn = new Random();
        static double x1 = 0;
        static double x2 = 1;
        static double w0 = rdn.NextDouble();
        static double w1 = rdn.NextDouble();
        static double w2 = rdn.NextDouble();
        static double bias = -1;
        static int esperadoX = -1;

        static void Main(string[] args)
        {
            int classe;
            double Soma = (x1 * w1) + (x2 * w2) + bias;
            if (Soma < 0)
            {
                classe = -1;
            }
            else
            {
                classe = 1;
            }
            Console.WriteLine(x1.ToString() + " " + x2.ToString() + " = " + classe.ToString());
            while (classe != esperadoX)
            {
                double n = 0.05;
                    w0 = w0 + n * x1 * (esperadoX - classe);
                    w1 = w1 * n * x2 * (esperadoX - classe);
                    w2 = w2 * n * bias * (esperadoX - classe);
                Soma = (x1 * w1) + (x2 * w2) + bias;
                if (Soma < 0)
                {
                    classe = -1;
                }
                else
                {
                    classe = 1;
                }
            }

            Console.WriteLine(x1.ToString() + " " + x2.ToString() + " = " + classe.ToString());
            Console.Read();
            double y1 = 1;
            double y2 = 1;
            double valorespradoY = 1;

            
            Soma = (y1 * w1) + (y2 * w2) + bias;
            if (Soma < 0)
            {
                classe = -1;
            }
            else
            {
                classe = 1;
            }
            
            while (classe != valorespradoY)
            {
                double n = 0.05;
                w0 = w0 + n * x1 * (valorespradoY - classe);
                w1 = w1 * n * x2 * (valorespradoY - classe);
                w2 = w2 * n * bias * (valorespradoY - classe);
                Soma = (x1 * w1) + (x2 * w2) + bias;
                if (Soma < 0)
                {
                    classe = -1;
                }
                else
                {
                    classe = 1;
                }
            }
            Console.WriteLine("y1: " + y1.ToString() + " y2: " + y2.ToString() + " = " + classe.ToString() + " pesos: " + w0.ToString() + w1.ToString() + w2.ToString());
            Console.ReadKey();
        }
    }
}
