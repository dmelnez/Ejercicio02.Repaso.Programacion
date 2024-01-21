using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Repaso.Programacion.Servicios
{
    internal class ValidacionImplementacion : ValidacionInterfaz
    {
        public bool validacionNumeroEntero(int numeroIntro)
        {
            bool validacionNumero = false;

            if (numeroIntro >= 10)
            {

                validacionNumero = false;
            }

            else
            {
                Console.WriteLine("[¡ERROR!]");
                validacionNumero = true;

            }

            return validacionNumero;



        }
    }
}
