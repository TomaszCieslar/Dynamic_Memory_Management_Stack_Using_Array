using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Memory_Management_Stack_Using_Array
{
    class Pila
    {
        int valor_actual;
        int cantidad_valores;
        int[] valores_pila;

        public Pila(int cantidad_valores)
        {
            valor_actual = 0;
            this.cantidad_valores = cantidad_valores;

            valores_pila = new int[cantidad_valores];
        }

        public void Apilar(int valor)
        {
            if (valor_actual < cantidad_valores)
            {
                valores_pila[valor_actual] = valor;
                valor_actual++;
            }

        }

        public int Desapilar()
        {
            if (valor_actual > 0)
            {
                valor_actual -= 1;
                return valores_pila[valor_actual];
            }
            return 0;
        }
    }
}
