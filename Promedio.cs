using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    internal class Promedio
    {
        int contador = 0;
        double acumular = 0;

        public void agregarValor(double valor)
        {
            contador++;
            acumular += valor;
        }
        public double calcularPromedio() 
        {
            if (contador != 0) 
            {
            return acumular/ contador;
            }
            return 0;
        }
    }
}
