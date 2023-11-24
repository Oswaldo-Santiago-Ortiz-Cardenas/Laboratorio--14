using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_14
{
    public class Program
    {
        static void Main(string[] args)
        {
            PantallasyOperaciones.Menu();
            do
            {
                switch (PantallasyOperaciones.opc)
                {
                    case 1:
                        PantallasyOperaciones.EncuestadeVacunacion();
                        break;
                    case 2:
                        PantallasyOperaciones.Datos();
                        break;
                    case 3:
                        PantallasyOperaciones.Resultados();
                        break;
                    case 4:
                        PantallasyOperaciones.Busqueda();
                        break;
                }
            } while (PantallasyOperaciones.opc != 5);
        }
    }
}
