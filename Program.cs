using System;
using System.Collections.Generic;

namespace Ejercicio100num
{
    public class Program
    {
        public static List<int> numeros = new List<int>();
        static int ingreso; 
        public static int max = 0;
        public static int min = 100;
        public static float prom = 0.0f;
        static void Main(string[] args)
          {
              do 
              {
                  Console.WriteLine("Ingrese un numero del 0 al 100");
                  ingreso = Convert.ToInt16(Console.ReadLine());
                  comprobar();
              }
              while (numeros.Count != 10);
              Operaciones ope = new Operaciones(); 
              ope.maximo();
              ope.minimo();
              ope.promedio();
              Console.WriteLine("El numero maximo ingresado es {0}, el minimo es {1} y el promedio de los numeros es {2}",max,min,prom);
          }      
        public static int comprobar()
        {
            if (ingreso>100|ingreso<0)
                {
                    Console.WriteLine("El numero ingresado no es correcto. Ingrese un numero de 0 al 100");
                }
            else 
            {
                    agregar();
            }
                return ingreso;
        }
        public static List<int> agregar()
        {
            numeros.Add(ingreso);
            return numeros;
        }


    }
}
