using System;
using System.Collections.Generic;
using Ejercicio100num;

public class Operaciones : Program

{
    public  Operaciones ()
    {

    }
            public int maximo()
        {
            foreach(var k in numeros)
            {                
                if (k>max)
                {
                    max = k;
                }
            }
            return max;
        }
        public int minimo()
        {
            foreach(var l in numeros)
            {
                if (min>l)
                {
                    min = l;
                }
            }
            return min;
        }

        public float promedio()
        {
            foreach(var r in numeros)
            {
                prom = prom + r;
            }
            prom = (prom/10.0f);
            return prom;
        }
}