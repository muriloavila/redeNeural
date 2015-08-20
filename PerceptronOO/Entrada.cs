using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronOO
{
    class Entrada
    {
        static Random rdn = new Random();
        private double valor;
        private double peso = rdn.NextDouble();

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public Entrada treinar(Entrada entrada, double txAprendizado, double desejado, int classe, double pesoBias, double bias)
        {
           
            entrada.Peso = entrada.Peso + (txAprendizado * (desejado - classe) * entrada.Valor);
            pesoBias = (pesoBias + txAprendizado * (desejado - classe) * bias);
            this.Peso = entrada.Peso;
            return entrada;
        }
    }
}
