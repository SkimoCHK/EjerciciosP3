using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosP3
{
    public class Ejercicios
    {

        public void ArrayBidimensionalEnteros()
        {
            int[,] enteros = new int[3, 3];
            enteros[0, 0] = 1;
            enteros[0, 1] = 2;
            enteros[0, 2] = 3;

            enteros[1, 0] = 4;
            enteros[1, 1] = 5;
            enteros[1, 2] = 6;

            enteros[2, 0] = 7;
            enteros[2, 1] = 8;
            enteros[2, 2] = 9;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.WriteLine(enteros[x, y]);

                }
            }
            


        }
        public void ArrayBidimensionalColores()
        {
            string[,] colores = new string[2, 2];
            colores[0, 0] = "Rojo";
            colores[0, 1] = "Azul";

            colores[1, 0] = "Verde";
            colores[1, 1] = "Naranja";


            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Console.WriteLine(colores[x, y]);

                }
            }


        }

        public void SumaElementosMatriz()
        {
            double [,] numerosReales = new double[4, 3];
            numerosReales[0, 0] = 1.5;
            numerosReales[0, 1] = 1.3;
            numerosReales[0, 2] = 2.8;

            numerosReales[1, 0] = 4.5;
            numerosReales[1, 1] = 1.7;
            numerosReales[1, 2] = 3.4;

            numerosReales[2, 0] = 9.9;
            numerosReales[2, 1] = 12.2;
            numerosReales[2, 2] = 8.1;

            numerosReales[3, 0] = 6.8;
            numerosReales[3, 1] = 14.6;
            numerosReales[3, 2] = 21.4;
            double  suma = 0;
            for(int x = 0; x<4; x++)
            {

                for (int z = 0; z < 3; z++)
                {
                    Console.WriteLine("Los valores de los elementos en la matriz bidimensional son:");
                    Console.WriteLine(numerosReales[x, z] );
                    suma += numerosReales[x, z];


                }

            }
            Console.WriteLine($"Y la suma de cada elemento de la matriz da un total de: {suma}");

        }

        //Declara y crea una matriz bidimensional de caracteres de tamaño 2x4.
        //Llena la matriz con caracteres alfabéticos y luego imprime la matriz en forma de tabla.
        public void MatrizAlfabetica()
        {
            char[,] alfabeto = new char[2, 4];
            alfabeto[0, 0] = 'A';
            alfabeto[0, 1] = 'B';
            alfabeto[0, 2] = 'C';
            alfabeto[0, 3] = 'D';

            alfabeto[1, 0] = 'E';
            alfabeto[1, 1] = 'F';
            alfabeto[1, 2] = 'G';
            alfabeto[1, 3] = 'H';

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(alfabeto[x, y].ToString().PadRight(2));
                }
                Console.WriteLine();
            }
        }




    }
}
