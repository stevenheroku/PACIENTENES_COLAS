using PACIENTENES_COLAS.Clinica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACIENTENES_COLAS
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            int n;
            string nompaciente = "";
            string apellidospac = "";
            string direccion="";

            //PEDIMOS CUANTOS PACIENTES VAMMOS AGREGAR A LA COLA
            Console.Write("CUANTOS PACIETES DESEA INGRESAR A LA CLINICA *SALUDENT* ");
            n = Convert.ToInt32(Console.ReadLine());

            //HACEMOS LA COLA
            colas cola = new colas(n);


            do
            {

                Console.WriteLine("OPCIONES DE LA CLINICA   *SALUDENT*");
                Console.WriteLine("1. AGREGAR PACIENTE: ");
                Console.WriteLine("2. ATENDER PACIENTES E IRLOS ELIMINANDO CONFORME SU TURNO AGREGADO: ");
                Console.WriteLine("3. Salir: \n");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        int contadorpacientes = 1;

                        //LE AGREGAMOS PACIENTES A LA COLA

                        Console.WriteLine("\n AGREGAMOS LOS DATOS DEL PACIENTES");
                        for (int i = 0; i < n; i++)
                        {

                            
                            Console.WriteLine("\n Nombre del Paciente: "+ contadorpacientes);
                            nompaciente = (Console.ReadLine());
                            Console.WriteLine("Apellido del Paciente: " +contadorpacientes);
                            apellidospac = (Console.ReadLine());


                            if (cola.agregar( nompaciente))
                            {
                                Console.WriteLine("AGREGADO AL REGISTRO EL PACIENTE:  " + nompaciente+" "+apellidospac   );

                            }
                            else if (cola.esta_llena())
                            {
                                Console.WriteLine("YA ESTAN LLENOS LOS CUPOS DE LA CLINICA\n");
                            }

                            contadorpacientes++;
                        }

                        break;

                    case 2:
                        //LE EXTRAEMOS ELEMENTOS A LA COLA
                        Console.WriteLine("\nATENDER PACIENTES  EN ORDEN");
                        while (cola.extraer(ref nompaciente))
                        {
                            Console.WriteLine("DATOS DEL PACIENTE A ATENDER  NOMBRE:  " + nompaciente +"\n");
                            Console.WriteLine("EL PACIENTE "+ nompaciente + " FUE ELIMINADO DE LA COLA\n");
                            Console.WriteLine("ATENDER AL SIGUIENTE PACIENTE");
                            Console.ReadLine();

                            if (cola.esta_vacia())
                            {
                                Console.WriteLine("YA ESTAN ATENDIDOS TODOS LOS PACIENTES");
                                Console.ReadLine();
                            }

                        }
                        Console.ReadKey();
                        break;
                    case 0:

                        break;
                }

            } while (opcion != 3);

        }
    }
}
