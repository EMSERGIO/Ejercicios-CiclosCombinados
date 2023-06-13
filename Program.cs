using System;

namespace Progama6
{
    class Program
    {
        static void Main(string[] args)
        {
            // CICLOS CONVINADOS.
            // FOR CON FOR.
            // int prom, acu = 0, n;

            // for (int x = 0; x < 10; x++)
            // {
            //     acu = 0;
            //     for (int y = 0; y < 10; y++)
            //     {
            //         Console.WriteLine("Ingrese la Edad:");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;
            
            //     }
            //     prom = acu/20;
            //     Console.WriteLine("El promedio es: " + prom);
            // }

            // //FOR CON WHILE.

            // for (int x = 0; x < 10; x++)
            // {

            //   Console.WriteLine("Ingrese su edad");
            //   n = int.Parse(Console.ReadLine());
            //   acu = 0;
            //   con = 0;

                // while (n != 0){
                    // acu += n;
                    // con++;
                    // Console.WriteLine("Ingrese su edad:");
                    // n = int.Parse(Console.ReadLine());
                // }
                // prom = acu / con;
                // Console.WriteLine("El promedio es: " + prom);
            
            // }






            //......................................................................................

            // Ejercicio 6

            // 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla
            // cuántos de esos números son primos.


            // int n, con, conPrimo = 0;

            // for (int x = 0; x < 5; x++)
            // {
                // Console.WriteLine("Ingrese un munero:");
                // n = int.Parse(Console.ReadLine());

                // con = 0;
                // for (int y = 1; y <= n; y++)
                // {             
                    // if(n % y == 0){
                        // con++;
                    // }
                // }
                // if(con == 2){
                    // conPrimo ++;   
                // }
            // }
            // Console.WriteLine("LA CANTIDAD DE NUMEROS PRIMOS SON:" + conPrimo);


            //......................................................................................

            // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
            // Se pide determinar e informar:
            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.


            // int n, conImpar, conNumeros, grupoImparesMaximo = 0, min, conOrdenados = 0;
            // double porcentajeImpares,porcentajeMaximo = -1;
            // bool banderaOrdenados = false;

            // for (int x = 0; x < 2; x++)
            // {
                // conNumeros = 0;
                // conImpar = 0;
                // banderaOrdenados = true;
                // Console.WriteLine("Ingrese un numero");
                // n = int.Parse(Console.ReadLine());
                // min = n;
                // while (n != 0)
                // {
                    // conNumeros++;
                    // if (n % 2 != 0){
                        // conImpar++;                       
                    // }
                    // if(n >= min){
                        // min = n;
                    // }else{
                        // banderaOrdenados = false;
                    // }                                                             
                    // Console.WriteLine("Ingrese un numero");
                    // n = int.Parse(Console.ReadLine());
                // }
                // porcentajeImpares = conImpar * 100 / conNumeros;
                // if (porcentajeImpares > porcentajeMaximo){
                    // porcentajeMaximo = porcentajeImpares;
                    // grupoImparesMaximo = x + 1;
                // }
                // if (banderaOrdenados){
                    // conOrdenados++;
                // }
            // }
            // Console.WriteLine("El numero de grupo con mayor porcentaje de numeros impares es: " + grupoImparesMaximo);
            // Console.WriteLine("La cantidad de grupos con numeros ordenados es:" + conOrdenados);

            //..........................................................................................

            //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
            //  El fin de la carga se notifica con un número negativo. 
            //  Luego mostrar cuántos números tiene cada lista

            // int n, con, numeroGrupo = 0, acu;

            // do
            // {
                // acu = 0;
                // numeroGrupo++;
                // con = 0;
                // Console.WriteLine("Ingrese un numero");
                // n = int.Parse(Console.ReadLine());
                // while (n > 0)
                // {
                    // con++;
                    // acu += n;
                    // n = int.Parse(Console.ReadLine());
                    
                // }
                // Console.WriteLine("Del grupo: " + numeroGrupo + ", la cantidad de numeros es: " + con + ", y la suma de ellos es: " + acu);

            // }while(n >= 0);

           

        }
    }
}

