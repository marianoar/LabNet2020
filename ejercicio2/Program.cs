using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1) Realizar una método que al ingresar un valor genere una simple excepción al intentar 
             * hacer una división por cero. Esta misma excepción deberá ser capturada, 
             * mostrando el mensaje de la excepción y siempre deberá avisar cuando terminó de 
             * realizarse la operación haya sido exitosa o no.*/
            
            int numero;
            string ingreso;
            bool isNumber, isNumberDivisor;
            int operacion;
            int dividendo, divisor;
            float resultado=-1;
            string mensaje = string.Empty;
            bool flag=false;

            Console.WriteLine(" - - - Ejercicio 2 - - -");
            Console.WriteLine();
            Console.WriteLine(" Punto 1:");
            Console.WriteLine();
            Console.Write(" Ingrese un numero: ");

            ingreso = Console.ReadLine();

            isNumber = int.TryParse(ingreso, out numero);

            while (!isNumber)
            {
                Console.Write("Error. Ingrese nuevamente: ");
                ingreso = Console.ReadLine();
                isNumber = int.TryParse(ingreso, out numero);
            }
            
            try
            {
                operacion = numero / 0;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin de la operacion");
                Console.WriteLine("Pulse una tecla para continuar...");
            }
            Console.ReadKey();

            /*2) Realizar un método que permita ingresar 2 números (dividendo y divisor) 
             * y realice la división de los mismos. Se deberán mostrar el resultado 
             * (Si es un Unit Test tener en cuenta los Assert). 
             * Si hay una excepción de división por cero se deberá mostrar el siguiente mensaje: 
             * “Solo Chuck Norris divide por cero!” (Se acepta todo tipo de creatividad) más 
             * el mensaje de la excepción propia. También se deberá capturar una excepción 
             * si el usuario no ingresa ningún número o el mismo no es un número válido, 
             * informando la situación de “Seguro Ingreso una letra o no ingreso nada!”.*/
            Console.Clear();
            Console.WriteLine(" - - - Ejercicio 2 - - -");
            Console.WriteLine();
            Console.WriteLine(" Punto 2:");
            Console.WriteLine();
            Console.Write(" Ingrese un numero dividendo: ");

            ingreso = Console.ReadLine();

            isNumber = int.TryParse(ingreso, out dividendo);

            Console.Write(" Ingrese un divisor: ");

            ingreso = Console.ReadLine();

            isNumberDivisor = int.TryParse(ingreso, out divisor);
            try
            {
                if ((!isNumber) || (!isNumberDivisor))
                {
                    throw new IngresoInvalidoException();
                }
                resultado = dividendo / divisor;
            }

            catch (DivideByZeroException ex)
            {
                mensaje= "Solo Chuck Norris divide por Cero! - " + ex.Message;
                Console.WriteLine(mensaje);
                flag = true;
            }
            catch (IngresoInvalidoException ex)
            {
                mensaje = "Seguro Ingreso una letra o no ingreso nada!";
                Console.WriteLine(mensaje);
                flag = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                flag = true;
            }
            finally
            {
                if ((!flag)&&(resultado!=-1))
                {
                    Console.WriteLine($" El resultado de la division es:{resultado}.");
                }
                else
                {
                    Console.WriteLine(" Hubo un error, no hay resultado para mostrar");
                }
            }
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
            /*3) Realizar un método en una clase “Logic”, llamado desde la “presentación” (Consola, UnitTest, Etc.), 
             * que dispare una excepción. La misma deberá ser capturada por la “presentación”.
             * Deberá mostrar el mensaje de la excepción y el tipo de la excepción. */
            Console.Clear();
            Console.WriteLine(" - - - Ejercicio 2 - - -");
            Console.WriteLine();
            Console.WriteLine(" Punto 3:");
            Console.WriteLine();
            try
            {
                Logic.LanzarExcepcion();
            }
            catch (Exception e)
            {
                Console.WriteLine("Capturo Exception: {0}",e.Message);
            }
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
            /*4) Volver a realizar el ejercicio anterior pero esta vez la lógica deberá simplemente 
             * devolver un tipo de excepción personalizada y ser capturada por la misma aplicación
             * */
            Console.Clear();
            Console.WriteLine(" - - - Ejercicio 2 - - -");
            Console.WriteLine();
            Console.WriteLine(" Punto 4:");
            Console.WriteLine();
            try
            {
                Logic.LanzarExcepcionPersonalizada();
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        Console.WriteLine("Pulse una tecla para continuar...");
        Console.ReadKey();
        }
    }
}
