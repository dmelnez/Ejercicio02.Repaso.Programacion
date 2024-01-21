namespace Ejercicio02.Repaso.Programacion.Servicios;

class Program
{

    public static void Main(string[] args)
    {
        SolicitacionInterfaz sol = new SolicitacionImplementacion();

        ValidacionInterfaz val = new ValidacionImplementacion();

        OperativaInterfaz op = new OperativaImplementacion();

        int numeroIntro;

        do
        {
            numeroIntro = sol.solicitacionNumero();


        }

        while (val.validacionNumeroEntero(numeroIntro));

        op.multiplosNumeroIntro(numeroIntro);



      
    }


}