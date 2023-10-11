namespace EjerciciosP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Ejercicios ejercicios = new Ejercicios();

            Console.WriteLine("Hola, ¿qué problema desea probar? (1-4)");
            Console.WriteLine("1.- Imprimir valores de una matriz bidimensional 3x3");
            Console.WriteLine("2.- Imprimir los nombres de colores en una matriz bidimensional 2x2");
            Console.WriteLine("3.- Mostrar suma de valores decimales en una matriz bidimensional 4x3");
            Console.WriteLine("4.- Mostrar caracteres en formato de tabla de una matriz 2x4");

            int problema = Convert.ToInt32(Console.ReadLine());

            switch (problema)
            {
                case 1:
                    ejercicios.ArrayBidimensionalEnteros();
                    break;
                case 2:
                    ejercicios.ArrayBidimensionalColores();
                    break;

                case 3:
                    ejercicios.SumaElementosMatriz();
                    break;

                case 4:
                    ejercicios.MatrizAlfabetica();
                    break;

                default: Console.WriteLine("Selecciona una opción válida por favor");
                    break;
            }
            


        }
    }
}