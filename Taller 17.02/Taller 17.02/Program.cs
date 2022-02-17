namespace TallerConceptosFundamentales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             17/02/2022
            Calcular quincena 
             Calcular el sueldo quincenal, tomando en cuenta los siguientes parámetros:
            • $ 1.050.000 por quincena
            • Bono de 10% de profesionalización a los que tienen título universitario
            • Bono quincenal de transporte de $ 120.000
            • Bono de alimentación de $ 25.000 por día laborado
            Deducciones:
            o 2% Seguro Colectivo
            o 1% Paro Forzoso
            o 2% EPS
            o 2% Caja de compensación*/

            double bSueldoQuincena;
            string cAux;
            int nContador;

            bSueldoQuincena = 0;
            nContador = 0;

            while (nContador < 1)
            {
                Console.WriteLine("Tiene usted un titulo Universitario?");
                cAux = Console.ReadLine();

                if (cAux == "si" | cAux == "Si")
                {
                    bSueldoQuincena = 1050000 + 120000 + (25000 * 15) + (1050000 * 0.1);
                    nContador = 1;
                }
                else if (cAux == "no" | cAux == "No")
                {
                    bSueldoQuincena = 1050000 + 120000 + (25000 * 15);
                    nContador = 1;
                }
                else
                {
                    Console.WriteLine("Recuerde que debe escribir si o no o Si o No ");
                }
            }

            bSueldoQuincena = bSueldoQuincena - (bSueldoQuincena * 0.07);

            Console.WriteLine("Su quincena es: " + bSueldoQuincena);
            Console.readkey();
        }
    }
}
