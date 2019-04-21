using System;

namespace Dynamic_Memory_Management_Stack_Using_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementing a stack using array

            bool depurando = true;

            Pila miPila = new Pila(5);

            miPila.Apilar(4);
            miPila.Apilar(5);

            Console.WriteLine(miPila.Desapilar());
            Console.WriteLine(miPila.Desapilar());

            if (depurando)
                Console.ReadLine();
        }
    }
}
