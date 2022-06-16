using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendedoresYProductos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vendedor> ListVendedores = new List<Vendedor>();


            Console.CursorLeft = 30;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Bienvenido al registro de ventas y productos");

            Console.WriteLine("Ingrese 's' para ingresar datos o 'n': ");
            string acceso = Console.ReadLine();

            while (acceso == "s")
            {
                Vendedor Vend = new Vendedor();

                Console.WriteLine("Ingrese el nombre del vendedor");

                Vend.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido del vendendor");

                Vend.Apellido = Console.ReadLine();

                Console.WriteLine("Ingrese el DNI");

                Vend.DNI = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j<12; j++) //12 por los 12 mese del año
                {
                    Meses mes = new Meses();

                    Console.WriteLine("Ingrese el nombre del producto:");

                    mes.NombProd = Console.ReadLine();

                    Console.WriteLine("Ingrese el precio del producto:");

                    mes.Precio = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el numero del mes:");

                    mes.NumeroDeMes = Convert.ToInt32(Console.ReadLine());

                    Vend.Mes.Add(mes);
                }
                Console.WriteLine("Ingrese 's' para continuar o 'n' para terminar y mostrar:");

                acceso = Console.ReadLine();

                Console.Clear();
                ListVendedores.Add(Vend);
            }

            for (int i= 0; i<ListVendedores.Count; i++)
            {
                Vendedor Empleado = ListVendedores[i]; //El objeto 'Empleado', con esto, ya tiene cargado
                                                       // toda la lista de List 'ListVendedores' y sus anidamientos

                Console.WriteLine("Nombre del vendedor: " + " " + Empleado.Nombre);
                Console.WriteLine("Apellido del vendedor: " + " " + Empleado.Apellido);



                for (int j=0; j< Empleado.Mes.Count; j++) 
                {
                    Console.WriteLine("Ventas del mes:" + " " + Empleado.Mes[j].NombProd);
                    Console.WriteLine("Precio del producto vendido:" + " " + Empleado.Mes[j].Precio);
                }

            }
            
            Console.ReadKey();
        }
    }
}
