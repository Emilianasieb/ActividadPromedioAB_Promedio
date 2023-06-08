using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPromedio
{
    internal class Promedio
    {
        private double resultado;
        private int cantidad;

        public Promedio()
        {
            resultado = 0;
            cantidad = 0;
        }

        public void AgregarValor(double valor)
        {
            resultado += valor;
            cantidad++;
        }
        public double CalcularPromedio()
        {
            if (cantidad == 0)
            {
                return 0;
            }
            return resultado / cantidad;
        }
    }
}