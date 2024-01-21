using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Repaso.Programacion.Servicios
{
    internal class SolicitacionImplementacion : SolicitacionInterfaz
    {
        public int solicitacionNumero()
        {

            Console.WriteLine("Introduzca un Numero ");
            Console.WriteLine("[ATENCION] - Numero Entero");
            int numeroIntroducido = Convert.ToInt32(Console.ReadLine());
            return numeroIntroducido;



        }

    }
}
