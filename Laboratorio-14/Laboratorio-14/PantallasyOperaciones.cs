using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_14
{
    public class PantallasyOperaciones
    {
        public static int opc;
        public static int contador = 0;
        public static string[] vacuna = new string[1000];
        public static string[] id = new string[1000];
        public static int[] edades = new int[1000];
        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("" +
            "================================\n"+
            "Encuesta Covid-19\n"+
            "================================\n"+
            "1: Realizar encuesta\n"+
            "2: Mostrar Datos de la encuesta\n"+
            "3: Mostrar Resultados\n"+
            "4: Buscar Personas por edad\n"+
            "5: Salir\n"+
            "================================\n");
            Console.Write("Ingrese una opcion: ");
            opc = int.Parse(Console.ReadLine());
            return opc;
        }
        public static int EncuestadeVacunacion()
        {
            Console.Clear();
            Console.WriteLine("" +
            "================================\n" +
            "Encuesta de Vacunación\n" +
            "================================\n");
            Console.Write("Que edad tienes?: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("" +
            "Te has vacunado\n" +
            "1: Sí\n" +
            "2: No\n" +
            "===============================\n");
            Console.Write("Ingrese una opción: ");
            int opcV = int.Parse(Console.ReadLine());
            id[contador] = contador.ToString("D4");
            edades[contador] = edad;
            vacuna[contador] = (opcV == 1) ? "Si" : "No";
            Console.Clear();
            Console.WriteLine("" +
            "================================\n" +
            "Encuesta de Vacunación\n" +
            "================================\n"+
            "\n"+
            "\n"+
            "¡Gracias por participar!\n"+
            "\n"+
            "\n"+
            "================================\n");
            Console.Write("Presione una tecla...");
            _ = id[contador];
            contador++;
            Console.ReadKey();
            return Menu();
        }
        public static int Datos()
        {
            Console.Clear();
            Console.WriteLine("" +
            "================================\n" +
            "Datos de la encuesta\n" +
            "================================\n");
            Console.WriteLine("" +
            "ID    | Edad | Vacunado\n" +
            "=======================\n");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"{id[i]}   | {edades[i]}   | {vacuna[i]}");
            }
            Console.WriteLine("" +
            "================================\n");
            Console.Write("Presione una tecla para regresar...");
            Console.ReadKey();
            return Menu();
        }
        public static int Resultados()
        {
            Console.Clear();
            Console.WriteLine("" +
            "===================================\n" +
            "Resultados de la encuesta\n" +
            "===================================\n" +
            $"{CVacunados()} personas se han vacunado\n" +
            $"{CNoVacunados()} personas no se han vacunado\n" +
            "\n"+
            $"Existen:\n" +
            $"{PersonasPorEdad(1, 20)} personas entre 01 y 20 años\n" +
            $"{PersonasPorEdad(21, 30)} personas entre 21 y 30 años\n" +
            $"{PersonasPorEdad(31, 40)} personas entre 31 y 40 años\n" +
            $"{PersonasPorEdad(41, 50)} personas entre 41 y 50 años\n" +
            $"{PersonasPorEdad(51, 60)} personas entre 51 y 60 años\n" +
            $"{PersonasPorEdad(61, int.MaxValue)} personas de más de 61 años\n" +
            "===================================\n");
            Console.Write("Presione una tecla para regresar...");
            Console.ReadKey();
            return Menu();
        }
        public static int CVacunados()
        {
            int cont = 0;
            for (int i = 0; i < contador; i++)
            {
                if (vacuna[i] == "Si")
                {
                    cont++;
                }
            }
            return cont;
        }

        public static int CNoVacunados()
        {
            int cont = 0;
            for (int i = 0; i < contador; i++)
            {
                if (vacuna[i] == "No")
                {
                    cont++;
                }
            }
            return cont;
        }
        public static int PersonasPorEdad(int eMin, int eMax)
        {
            int cont = 0;
            for (int i = 0; i < contador; i++)
            {
                if (edades[i] >= eMin && edades[i] <= eMax)
                {
                    cont++;
                }
            }
            return cont;
        }
        public static int Busqueda()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Buscar Personas por Edad");
            Console.WriteLine("================================");
            Console.Write("¿Qué edad quieres buscar?: ");
            int ebd;
            if (int.TryParse(Console.ReadLine(), out ebd))
            {
                int vacunadosEdad = 0;
                int NOvacunadosEdad = 0;
                for (int i = 0; i < contador; i++)
                {
                    if (edades[i] == ebd)
                    {
                        if (vacuna[i] == "Si")
                        {
                            vacunadosEdad++;
                        }
                        else
                        {
                            NOvacunadosEdad++;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"{vacunadosEdad.ToString("D2")} se vacunaron");
                Console.WriteLine($"{NOvacunadosEdad.ToString("D2")} no se vacunaron");
                Console.WriteLine();
                Console.WriteLine("================================");
                Console.Write("Presione una tecla para regresar ...");
                Console.ReadKey();
            }
            return Menu();
        }
    }
}
